using Microsoft.Extensions.DependencyInjection;
using PNP_Services.Databases;
using PNP_Services.Databases.Core.HistoryDB;
using PNP_Services.Databases.Core.SettingDB;
using PNP_Services.Services.Core.HistoryService;
using PNP_Services.Services.Core.LanguageService;
using PNP_Services.Services.Core.LoggerService;
using PNP_Services.Services.Core.SettingsService;
using System;
using System.Collections.Generic;

namespace PNP_Services
{
    public static class GlobalServiceProvider
    {
        #region Properties
        private static readonly IServiceCollection _serviceCollection = new ServiceCollection();
        private static  IServiceProvider _serviceProvider = null;
        #endregion

        #region Function

        /// <summary>
        /// Get an Instance of the specified Service
        /// </summary>
        /// <typeparam name="T">Interface, of whom specific Service should be created</typeparam>
        /// <returns></returns>
        public static T GetRequiredService<T>()
        { return _serviceProvider.GetRequiredService<T>(); }

        public static void RegisterServices(List<IRegister> registers = null)
        {
            //Register Local DBs
            _serviceCollection.AddDbContext<HistoryContext>();
            DbInitializer.Initialize(new HistoryContext());
            _serviceCollection.AddDbContext<SettingContext>();
            DbInitializer.Initialize(new SettingContext());

            //Register Local Services
            _serviceCollection.AddScoped<ISettingsService, SettingsService>();
            _serviceCollection.AddScoped(sp => LoggerFactory.GetLogger(sp));
            _serviceCollection.AddScoped<IHistoryService, HistoryService>();
            _serviceCollection.AddScoped<ILanguageService, LanguageService>();

            //Register all external Services
            if(registers != null && registers.Count > 0)
            { registers.ForEach(r => r.Register(_serviceCollection)); }

            //Build Provider
            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }
        #endregion
    }
}
