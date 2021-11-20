using Microsoft.EntityFrameworkCore;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.TrainerMainContext.Model;
using PNP_Services.Services.Core.LoggerService;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.TrainerMainContext
{
    public class TrMainContext : DbContext
    {
        #region DatabaseSets
        public DbSet<Trainer> Trainers { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.LogTo(message => LoggerFactory.DBLogging(message, "TrainerContext"))
                      .UseSqlite(DbInitializer.GetDBConnectionString(DBEnum.PkVerwaltungTrMain));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
