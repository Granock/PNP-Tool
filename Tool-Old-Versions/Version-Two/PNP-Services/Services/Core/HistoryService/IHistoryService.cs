using System.Threading.Tasks;

namespace PNP_Services.Services.Core.HistoryService
{
    public interface IHistoryService
    {
        /// <summary>
        /// Writes an Entry to the HistoryDB
        /// </summary>
        /// <param name="Entry">Entry</param>
        public Task WriteHistoryAsync(string Entry);
    }
}
