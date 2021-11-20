using System;
using System.Collections.Generic;
using System.IO;

namespace PNP.Tool.Services.Core.Logger.LoggerImplementations
{
    class BaseLogger : ILogger
    {
        #region Properties

        private readonly string _LogFileName;
        private readonly string _LogDirectory;
        private string _NormSender = "BaseLogger";
        private List<string> _NormArgs = new();

        #endregion

        #region Error
        public void LogError(Exception error, string sender = null, List<string> Args = null)
        { WriteLogMessage("Error", error.Message, sender, Args); }

        public void LogError(string error, string sender = null, List<string> Args = null)
        { WriteLogMessage("Error", error, sender, Args); }
        #endregion

        #region Info
        public void LogInfo(Exception info, string sender = null, List<string> Args = null)
        { WriteLogMessage("Info", info.Message, sender, Args); }

        public void LogInfo(string info, string sender = null, List<string> Args = null)
        { WriteLogMessage("Info", info, sender, Args); }
        #endregion

        #region Warning
        public void LogWarning(Exception warning, string sender = null, List<string> Args = null)
        { WriteLogMessage("Warning", warning.Message, sender, Args); }

        public void LogWarning(string warning, string sender = null, List<string> Args = null)
        { WriteLogMessage("Warning", warning, sender, Args);
        }
        #endregion

        #region Generell
        public void SetNormArgs(List<string> Args)
        { _NormArgs = Args; }

        public void SetNormSender(string sender)
        { _NormSender = sender; }

        public BaseLogger(string LogDirectory, string LogFileName)
        {
            _LogDirectory = LogDirectory;
            _LogFileName = LogFileName;
        }

        private void WriteLogMessage(string type, string Message, string sender = null, List<string> Args = null)
        {

            string activeSender = string.IsNullOrWhiteSpace(sender) ? _NormSender : sender;
            List<string> activeArgs = Args == null || Args.Count == 0 ? _NormArgs : Args;

            Message = $"<LogEntry: | {type}: {Message} | Sender = {activeSender} ";
            foreach (string Arg in activeArgs)
            { Message += $"| Arg: {Arg} "; }
            Message += $"| Logged on: {DateTime.Now:G} >\n\n";

            File.AppendAllText(_LogDirectory + _LogFileName, Message);
        }
        #endregion
    }
}
