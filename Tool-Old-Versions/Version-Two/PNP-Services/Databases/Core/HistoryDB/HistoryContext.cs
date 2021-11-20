using Microsoft.EntityFrameworkCore;
using PNP_Services.Databases.Core.HistoryDB.Model;
using PNP_Services.Services.Core.LoggerService;

namespace PNP_Services.Databases.Core.HistoryDB
{
    public class HistoryContext : DbContext
    {
        #region DbSets
        public DbSet<HistoryEntry> Entries { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.LogTo(message => LoggerFactory.DBLogging(message, "HistoryContext"))
                      .UseSqlite(DbInitializer.GetDBConnectionString(DBEnum.History));
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HistoryEntry>()
                .HasKey(x => x.EntryGUID);
        }
    }
}
