using Microsoft.EntityFrameworkCore;
using PNP.Services.Service.Enumerators.Settings;
using PNP.Services.Service.Services.GlobalSettings;

namespace PNP.Services.Service.Databases.HistoryDatabase
{
    public class HistoryContext : DbContext
    {
        #region DatabaseSets
        public DbSet<HistoryEntry> History { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(GlobalProperties.GetDatabaseConnectionString(DBEnum.HistoryDB));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HistoryEntry>()
                .HasKey(x => x.EntryGUID);
        }
    }
}
