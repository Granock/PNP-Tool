using System;

namespace PNP_Services.Databases.Core.HistoryDB.Model
{
    public class HistoryEntry
    {
        #region Properties
        public Guid EntryGUID { get; set; }
        public string EntryValue { get; set; }
        public DateTime EntryTime { get; set; }
        #endregion
    }
}
