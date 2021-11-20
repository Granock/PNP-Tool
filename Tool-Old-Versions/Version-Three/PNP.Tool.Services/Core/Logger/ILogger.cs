using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNP.Tool.Services.Core.Logger
{
    public interface ILogger
    {
        #region Generell
        /// <summary>
        /// Sets a normal Sender, to be put in all Log-Entrys
        /// </summary>
        /// <param name="sender">the sender</param>
        public void SetNormSender(string sender);
        /// <summary>
        /// Sets standard Arguments, which schould be included in all Log-Entrys
        /// </summary>
        /// <param name="Args">the Arguments</param>
        public void SetNormArgs(List<string> Args);
        #endregion

        #region Errors
        /// <summary>
        /// Logs an Error, with a Sender and Arguments
        /// </summary>
        /// <param name="error">the Error that needs to be logged</param>
        /// <param name="sender">optional Sender, if a different sender than standard should be used</param>
        /// <param name="Args">optional Arguments, if they schould be included</param>
        public void LogError(Exception error, string sender = null, List<string> Args = null);
        /// <summary>
        /// Logs an Error, with a Sender and Arguments
        /// </summary>
        /// <param name="error">the Error that needs to be logged</param>
        /// <param name="sender">optional Sender, if a different sender than standard should be used</param>
        /// <param name="Args">optional Arguments, if they schould be included</param>
        public void LogError(string error, string sender = null, List<string> Args = null);
        #endregion

        #region Warnings
        /// <summary>
        /// Logs a Warning, with a Sender and Arguments
        /// </summary>
        /// <param name="warning">the Warning that needs to be logged</param>
        /// <param name="sender">optional Sender, if a different sender than standard should be used</param>
        /// <param name="Args">optional Arguments, if they schould be included</param>
        public void LogWarning(Exception warning, string sender = null, List<string> Args = null);
        /// <summary>
        /// Logs a Warning, with a Sender and Arguments
        /// </summary>
        /// <param name="warning">the Warning that needs to be logged</param>
        /// <param name="sender">optional Sender, if a different sender than standard should be used</param>
        /// <param name="Args">optional Arguments, if they schould be included</param>
        public void LogWarning(string warning, string sender = null, List<string> Args = null);
        #endregion

        #region Infos
        /// <summary>
        /// Logs a Info, with a Sender and Arguments
        /// </summary>
        /// <param name="info">the Info that needs to be logged</param>
        /// <param name="sender">optional Sender, if a different sender than standard should be used</param>
        /// <param name="Args">optional Arguments, if they schould be included</param>
        public void LogInfo(Exception info, string sender = null, List<string> Args = null);
        /// <summary>
        /// Logs a Info, with a Sender and Arguments
        /// </summary>
        /// <param name="info">the Info that needs to be logged</param>
        /// <param name="sender">optional Sender, if a different sender than standard should be used</param>
        /// <param name="Args">optional Arguments, if they schould be included</param>
        public void LogInfo(string info, string sender = null, List<string> Args = null);
        #endregion
    }
}
