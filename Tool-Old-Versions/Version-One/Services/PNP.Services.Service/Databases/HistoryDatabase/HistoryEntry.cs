using System;

namespace PNP.Services.Service.Databases.HistoryDatabase
{
    public class HistoryEntry
    {
        #region Properties
        public Guid EntryGUID { get; set; }
        public string EntryValue { get; set; }
        public Guid EntryObjectGUID { get; set; }
        #endregion
    }
}
