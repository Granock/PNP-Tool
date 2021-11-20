using Microsoft.EntityFrameworkCore;
using PNP_Services.Databases.Core.SettingDB.Model;
using PNP_Services.Services.Core.LoggerService;

namespace PNP_Services.Databases.Core.SettingDB
{
    public class SettingContext : DbContext
    {
        #region DbSets
        public DbSet<Setting> Settings { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.LogTo(message => LoggerFactory.DBLogging(message, "SettingContext"))
                      .UseSqlite(DbInitializer.GetDBConnectionString(DBEnum.Setting));
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>()
                .HasKey(x => x.SettingGUID);
        }
    }
}
