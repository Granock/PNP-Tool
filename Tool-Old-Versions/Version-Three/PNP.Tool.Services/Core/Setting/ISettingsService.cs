using System;
using System.Linq.Expressions;
using PNP.Tool.Services.Core.Setting.Structure;

namespace PNP.Tool.Services.Core.Setting {
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
    }
}
