using PNP_Services.Databases.Core.HistoryDB;
using PNP_Services.Databases.Core.HistoryDB.Model;
using System;
using System.Threading.Tasks;

namespace PNP_Services.Services.Core.HistoryService
{
    public class HistoryService : IHistoryService
    {
        private readonly HistoryContext _historyContext;
        
        public HistoryService(HistoryContext historyContext)
        { _historyContext = historyContext; }

        public async Task WriteHistoryAsync(string Entry)
        {
            _historyContext.Add(new HistoryEntry() { EntryValue = Entry, EntryTime = DateTime.Now });
            await _historyContext.SaveChangesAsync();
        }
    }
}
