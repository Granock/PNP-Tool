using Microsoft.EntityFrameworkCore;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model;
using PNP_Services.Services.Core.LoggerService;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext
{
    public class PokMainContext : DbContext
    {
        #region DatabaseSets
        public DbSet<Pokemon> Pokemons { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.LogTo(message => LoggerFactory.DBLogging(message,"PokemonMainContext"))
                      .UseSqlite(DbInitializer.GetDBConnectionString(DBEnum.PKVerwaltungPokMain));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region RelationConfig
            modelBuilder.Entity<Pokemon>()
                .HasMany(x => x.PokemonStats)
                .WithOne(x => x.Pokemon);
            modelBuilder.Entity<Pokemon>()
                .HasMany(x => x.PokemonSkills)
                .WithOne(x => x.Pokemon);
            modelBuilder.Entity<Pokemon>()
                .HasMany(x => x.PokemonEdges)
                .WithOne(x => x.Pokemon);
            modelBuilder.Entity<Pokemon>()
                .HasMany(x => x.PokemonCapabilities)
                .WithOne(x => x.Pokemon);
            modelBuilder.Entity<Pokemon>()
                .HasMany(x => x.PokemonAbilities)
                .WithOne(x => x.Pokemon);
            modelBuilder.Entity<Pokemon>()
                .HasMany(x => x.PokemonMoves)
                .WithOne(x => x.Pokemon);
            modelBuilder.Entity<Pokemon>()
                .HasOne(x => x.AdditionalInfo)
                .WithOne(x => x.Pokemon)
                .HasForeignKey<PokemonAdditionalInfo>(x => x.InfoGUID);
            #endregion
        }
    }
}
