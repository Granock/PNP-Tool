using System;

namespace PNP_Services
{
    public static class SeasionToken
    {
        public static void CreateToken()
        {
            StartUpTime = DateTime.UtcNow;
        }

        #region Token-Properties

        public static DateTime StartUpTime { get; private set; }

        #endregion
    }
}
