using Microsoft.EntityFrameworkCore;
using PNP.Services.Service.Databases.Modules.Pokemon.Models.PokemonContext;
using PNP.Services.Service.Enumerators.Settings;
using PNP.Services.Service.Services.GlobalSettings;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Contexts
{
    public class PokemonMainContext : DbContext
    {
        #region DatabaseSets
        public DbSet<Models.PokemonContext.Pokemon> Pokemons { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(GlobalProperties.GetDatabaseConnectionString(DBEnum.PokemonMainDB));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region KeyConfig
            modelBuilder.Entity<Models.PokemonContext.Pokemon>()
                .HasKey(x => x.PokemonGUID);
            modelBuilder.Entity<PokemonAbility>()
                .HasKey(x => x.AbilityGUID);
            modelBuilder.Entity<PokemonAdditionalInfo>()
                .HasKey(x => x.InfoGUID);
            modelBuilder.Entity<PokemonCapability>()
                .HasKey(x => x.CapabilityGUID);
            modelBuilder.Entity<PokemonEdge>()
                .HasKey(x => x.EdgeGUID);
            modelBuilder.Entity<PokemonMove>()
                .HasKey(x => x.MoveGUID);
            modelBuilder.Entity<PokemonSkill>()
                .HasKey(x => x.SkillGUID);
            modelBuilder.Entity<PokemonStat>()
                .HasKey(x => x.StatGUID);
            #endregion

            #region RelationConfig
            modelBuilder.Entity<Models.PokemonContext.Pokemon>()
                .HasMany(x => x.PokemonStats)
                .WithOne(x => x.Pokemon);
            modelBuilder.Entity<Models.PokemonContext.Pokemon>()
                .HasMany(x => x.PokemonSkills)
                .WithOne(x => x.Pokemon);
            modelBuilder.Entity<Models.PokemonContext.Pokemon>()
                .HasMany(x => x.PokemonEdges)
                .WithOne(x => x.Pokemon);
            modelBuilder.Entity<Models.PokemonContext.Pokemon>()
                .HasMany(x => x.PokemonCapabilities)
                .WithOne(x => x.Pokemon);
            modelBuilder.Entity<Models.PokemonContext.Pokemon>()
                .HasMany(x => x.PokemonAbilities)
                .WithOne(x => x.Pokemon);
            modelBuilder.Entity<Models.PokemonContext.Pokemon>()
                .HasMany(x => x.PokemonMoves)
                .WithOne(x => x.Pokemon);
            modelBuilder.Entity<Models.PokemonContext.Pokemon>()
                .HasOne(x => x.AdditionalInfo)
                .WithOne(x => x.Pokemon)
                .HasForeignKey<PokemonAdditionalInfo>(x => x.InfoGUID);
            #endregion
        }
    }
}
