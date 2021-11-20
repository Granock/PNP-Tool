using Microsoft.Extensions.DependencyInjection;
using PNP_Services.Services.Core.LoggerService.LoggerImplementations;
using PNP_Services.Services.Core.SettingsService;
using PNP_Services.Services.Core.SettingsService.Structure;
using System;
using System.Collections.Generic;
using System.IO;

namespace PNP_Services.Services.Core.LoggerService
{
    public static class LoggerFactory
    {
        private static string _LogDirectory = "";
        private static string _FileName = "";
        private static ILogger DBLogger = null;

        #region GetLogger
        /// <summary>
        /// Only for Registering LoggingServices
        /// </summary>
        /// <param name="sp">ServiceProvider</param>
        /// <param name="SpecificLogger">if a Specific Logger is needed</param>
        /// <returns></returns>
        public static ILogger GetLogger(IServiceProvider sp, string SpecificLogger = null)
        {
            if(sp != null)
            { 
                _LogDirectory = sp.GetRequiredService<ISettingsService>().GetSetting(x => x.LogFilePath);
                if (!Directory.Exists(_LogDirectory))
                { Directory.CreateDirectory(_LogDirectory); }
            }

            return GetLogger(SpecificLogger);
        }

        /// <summary>
        /// Creates a Logger for Erros, Warnings an Infos
        /// </summary>
        /// <param name="SpecificLogger">If a Special Logger is needed</param>
        /// <returns></returns>
        public static ILogger GetLogger(string SpecificLogger = null)
        { return GetLoggerInternal(SpecificLogger); }
        #endregion

        /// <summary>
        /// Logs all Errors and Messages from the DBs directly, by
        /// internaly saving an instance of ILogger for this purpose
        /// </summary>
        /// <param name="message">the Message</param>
        /// <param name="context">the context, which provides the Error/Message</param>
        public static void DBLogging(string message,string context)
        {
            if(DBLogger == null)
            { 
                DBLogger = GetLogger("DBLogger");
                DBLogger.SetNormSender("Databases");
                DBLogger.SetNormArgs(new List<string>());
                DBLogger.LogInfo("New DBLogger-Instance Created");
            }
            DBLogger.LogInfo(message,context);
        }

        private static ILogger GetLoggerInternal(string SpecificLogger = null)
        {
            return SpecificLogger switch
            {
                null => new BaseLogger(_LogDirectory, CreateFileName()),
                _ => new BaseLogger(_LogDirectory, CreateFileName()),
            };
        }

        private static string CreateFileName()
        {
            if(string.IsNullOrWhiteSpace(_FileName))
            { _FileName = $"{SeasionToken.StartUpTime.ToShortDateString()}_Logging.log"; }
            return _FileName;
        }
    }
}
