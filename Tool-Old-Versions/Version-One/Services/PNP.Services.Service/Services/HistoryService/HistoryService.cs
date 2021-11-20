using PNP.Services.Service.Databases;
using PNP.Services.Service.Databases.HistoryDatabase;
using System;

namespace PNP.Services.Service.Services.HistoryService
{
    public static class HistoryService
    {
        private static readonly HistoryContext _historyContext;

        static HistoryService()
        {
            _historyContext = new HistoryContext();
            DBInitializer.Initialize(_historyContext);
        }

        public static async void WriteHistory(Guid ObjectGUID,string EntryValue)
        {
            await _historyContext.AddAsync(new HistoryEntry() { EntryObjectGUID = ObjectGUID, EntryValue = EntryValue });
            await _historyContext.SaveChangesAsync();
        }
    }
}
