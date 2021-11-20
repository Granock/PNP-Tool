using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace PNP.Tool.Core.Global
{
    public static class GlobalServiceProvider
    {
        #region Properties
        private static readonly IServiceCollection _serviceCollection = new ServiceCollection();
        private static IServiceProvider _serviceProvider = null;
        #endregion

        #region Function

        /// <summary>
        /// Get an Instance of the specified Service
        /// </summary>
        /// <typeparam name="T">Interface, of whom specific Service should be created</typeparam>
        /// <returns></returns>
        public static T GetRequiredService<T>()
        { return _serviceProvider.GetRequiredService<T>(); }

        /// <summary>
        /// Register the Services
        /// </summary>
        /// <param name="registers"></param>
        public static void RegisterServices(List<IDPInjectionRegister> registers = null)
        {
            //Register all external Services
            if (registers != null && registers.Count > 0)
            { registers.ForEach(r => r.Register(_serviceCollection)); }

            //Build Provider
            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }
        #endregion
    }
}
