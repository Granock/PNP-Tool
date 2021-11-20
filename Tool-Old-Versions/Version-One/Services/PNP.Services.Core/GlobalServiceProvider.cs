using Microsoft.Extensions.DependencyInjection;
using PNP.Services.Service.Databases;
using PNP.Services.Service.Databases.Modules.Pokemon.Contexts;
using PNP.Services.Service.Interfaces;
using PNP.Services.Service.Services.IconService;
using PNP.Services.Service.Services.LanguageService;
using System;

namespace PNP.Services.Core
{
    public static class GlobalServiceProvider
    {
        #region Properties
        private static readonly IServiceCollection _serviceCollection = new ServiceCollection();
        private static readonly IServiceProvider _serviceProvider;
        #endregion

        #region Function
        static GlobalServiceProvider()
        {
            //Register Services
            RegisterServices();
            //Create Provider
            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }

        public static T GetRequiredService<T>()
        { return _serviceProvider.GetRequiredService<T>(); }

        public static IServiceProvider GetServiceProvider()
        { return _serviceProvider; }

        private static void RegisterServices()
        {
            //Adding Services
            #region GlobalServices
            _serviceCollection.AddScoped<ILanguageService, LanguageService>();
            _serviceCollection.AddScoped<IIconService, IconService>();
            #endregion

            #region Module.Pokemon
            DBInitializer.Initialize(new PokemonMainContext());
            DBInitializer.Initialize(new TrainerContext());
            DBInitializer.Initialize(new PokemonDataContext());
            _serviceCollection.AddDbContext<PokemonMainContext>();
            _serviceCollection.AddDbContext<TrainerContext>();
            _serviceCollection.AddDbContext<PokemonDataContext>();
            #endregion
        }
        #endregion
    }
}
