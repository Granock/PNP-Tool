using Microsoft.EntityFrameworkCore;
using PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext;
using PNP.Services.Service.Enumerators.Settings;
using PNP.Services.Service.Services.GlobalSettings;

namespace PNP.Services.Service.Databases.Modules.Pokemon.Contexts
{
    public class PokemonDataContext : DbContext 
    {
        #region DatabaseSets
        public DbSet<PokemonPreset> PokemonPresets { get; set; }
        public DbSet<DataAbility> DataAbilities { get; set; }
        public DbSet<DataCapability> DataCapabilities { get; set; }
        public DbSet<DataEdge> DataEdges { get; set; }
        public DbSet<DataMove> DataMoves { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(GlobalProperties.GetDatabaseConnectionString(DBEnum.PokemonDataDB));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region KeyConfig DataModels
            modelBuilder.Entity<DataAbility>()
                .HasKey(x => x.AbilityGUID);
            modelBuilder.Entity<DataCapability>()
                .HasKey(x => x.CapabilityGUID);
            modelBuilder.Entity<DataEdge>()
                .HasKey(x => x.EdgeGUID);
            modelBuilder.Entity<DataMove>()
                .HasKey(x => x.MoveGUID);
            #endregion

            #region KeyConfig PresetModels
            modelBuilder.Entity<PokemonPreset>()
                .HasKey(x => x.PokemonGUID);
            modelBuilder.Entity<PresetStat>()
                .HasKey(x => x.StatGUID);
            modelBuilder.Entity<PresetSkill>()
                .HasKey(x => x.SkillGUID);
            modelBuilder.Entity<PresetEdge>()
                .HasKey(x => x.EdgeGUID);
            modelBuilder.Entity<PresetCapability>()
                .HasKey(x => x.CapabilityGUID);
            modelBuilder.Entity<PresetAbility>()
                .HasKey(x => x.AbilityGUID);
            modelBuilder.Entity<PresetMove>()
                .HasKey(x => x.MoveGUID);
            modelBuilder.Entity<PresetAdditionalInfo>()
                .HasKey(x => x.InfoGUID);
            modelBuilder.Entity<PresetEvolutionInfo>()
                .HasKey(x => x.EvolutionInfoGUID);
            #endregion

            #region RelationConfig PresetModels
            modelBuilder.Entity<PokemonPreset>()
                .HasMany(x => x.PresetStats)
                .WithOne(x => x.DataPokemon);
            modelBuilder.Entity<PokemonPreset>()
                .HasMany(x => x.PresetSkills)
                .WithOne(x => x.DataPokemon);
            modelBuilder.Entity<PokemonPreset>()
                .HasMany(x => x.PresetEdges)
                .WithOne(x => x.DataPokemon);
            modelBuilder.Entity<PokemonPreset>()
                .HasMany(x => x.PresetCapabilities)
                .WithOne(x => x.DataPokemon);
            modelBuilder.Entity<PokemonPreset>()
                .HasMany(x => x.PresetAbilities)
                .WithOne(x => x.DataPokemon);
            modelBuilder.Entity<PokemonPreset>()
                .HasMany(x => x.PresetMoveList)
                .WithOne(x => x.DataPokemon);
            modelBuilder.Entity<PokemonPreset>()
                .HasOne(x => x.AdditionalInfo)
                .WithOne(x => x.DataPokemon)
                .HasForeignKey<PresetAdditionalInfo>(x => x.InfoGUID);
            modelBuilder.Entity<PresetAdditionalInfo>()
                .HasOne(x => x.EvolutionInfo)
                .WithOne(x => x.PresetAdditionalInfo)
                .HasForeignKey<PresetEvolutionInfo>(x => x.EvolutionInfoGUID);
            #endregion
        }
    }
}
