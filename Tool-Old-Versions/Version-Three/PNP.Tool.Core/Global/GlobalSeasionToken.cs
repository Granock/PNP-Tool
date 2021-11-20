using System;

namespace PNP.Tool.Core.Global
{
    public static class GlobalSeasionToken
    {
        public static void CreateToken()
        {
            StartUpTime = DateTime.UtcNow;
        }

        public static void RegisterSystem(Guid systemGuid) {
            SystemGuid = systemGuid;
        }

        #region Token-Properties

        public static DateTime StartUpTime { get; private set; }
        public static Guid? SystemGuid { get; private set; }

        #endregion
    }
}
