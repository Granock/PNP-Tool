using PNP_Services.Services.Core.SettingsService.Structure;
using System;
using System.Linq.Expressions;

namespace PNP_Services.Services.Core.SettingsService
{
    public interface ISettingsService
    {
        /// <summary>
        /// Returns a Specific Setting
        /// </summary>
        /// <typeparam name="T">Type of the Setting</typeparam>
        /// <param name="expr">The setting</param>
        /// <returns>Value of our Setting</returns>
        public T GetSetting<T>(Expression<Func<Settings,T>> expr);

        /// <summary>
        /// Saves a Setting to the DB
        /// </summary>
        /// <typeparam name="T">Type of the Setting</typeparam>
        /// <param name="expr">the Setting</param>
        /// <param name="value">new Value</param>
        public void SetSetting<T>(Expression<Func<Settings,T>> expr, T value);

        /// <summary>
        /// Saves a Setting to the DB
        /// </summary>
        /// <typeparam name="T">Type of the Setting</typeparam>
        /// <param name="Settingname">the Setting</param>
        /// <param name="value">new Value</param>
        public void SetSetting<T>(string Settingname, T value);
    }
}
