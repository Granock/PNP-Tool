using Microsoft.EntityFrameworkCore;
using PNP.Services.Service.Databases.Modules.Pokemon.Models.TrainerContext;
using PNP.Services.Service.Enumerators.Settings;
using PNP.Services.Service.Services.GlobalSettings;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Contexts
{
    public class TrainerContext : DbContext
    {
        #region DatabaseSets
        public DbSet<Trainer> Trainers { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(GlobalProperties.GetDatabaseConnectionString(DBEnum.TrainerMainDB));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region KeyConfig
            modelBuilder.Entity<Trainer>()
                .HasKey(x => x.TrainerGUID);
            #endregion
        }
    }
}
