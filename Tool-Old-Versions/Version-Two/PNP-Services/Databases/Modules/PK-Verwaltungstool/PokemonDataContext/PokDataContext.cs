using Microsoft.EntityFrameworkCore;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Data;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset;
using PNP_Services.Services.Core.LoggerService;

namespace PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext
{
    public class PokDataContext : DbContext
    {
        #region DatabaseSets
        public DbSet<PokCompletePreset> PokemonPresets { get; set; }
        public DbSet<PokDataAbility> DataAbilities { get; set; }
        public DbSet<PokDataCapability> DataCapabilities { get; set; }
        public DbSet<PokDataEdge> DataEdges { get; set; }
        public DbSet<PokDataMove> DataMoves { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.LogTo(message => LoggerFactory.DBLogging(message, "PokemonDataContext"))
                      .UseSqlite(DbInitializer.GetDBConnectionString(DBEnum.PkVerwaltungPokData));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region RelationConfig PresetModels
            modelBuilder.Entity<PokCompletePreset>()
                .HasMany(x => x.PresetStats)
                .WithOne(x => x.DataPokemon);
            modelBuilder.Entity<PokCompletePreset>()
                .HasMany(x => x.PresetSkills)
                .WithOne(x => x.DataPokemon);
            modelBuilder.Entity<PokCompletePreset>()
                .HasMany(x => x.PresetEdges)
                .WithOne(x => x.DataPokemon);
            modelBuilder.Entity<PokCompletePreset>()
                .HasMany(x => x.PresetCapabilities)
                .WithOne(x => x.DataPokemon);
            modelBuilder.Entity<PokCompletePreset>()
                .HasMany(x => x.PresetAbilities)
                .WithOne(x => x.DataPokemon);
            modelBuilder.Entity<PokCompletePreset>()
                .HasMany(x => x.PresetMoveList)
                .WithOne(x => x.DataPokemon);
            modelBuilder.Entity<PokCompletePreset>()
                .HasOne(x => x.AdditionalInfo)
                .WithOne(x => x.DataPokemon)
                .HasForeignKey<PokPresetAdditionalInfo>(x => x.InfoGUID);
            modelBuilder.Entity<PokPresetAdditionalInfo>()
                .HasOne(x => x.EvolutionInfo)
                .WithOne(x => x.PresetAdditionalInfo)
                .HasForeignKey<PokPresetEvolutionInfo>(x => x.EvolutionInfoGUID);
            #endregion
        }
    }
}
