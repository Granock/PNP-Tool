// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext;

namespace PNP_Services.Databases.Modules.PKVerwaltungstool.PokemonDataContext.Migrations
{
    [DbContext(typeof(PokDataContext))]
    partial class PokDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Data.PokDataAbility", b =>
                {
                    b.Property<Guid>("AbilityGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Effect")
                        .HasColumnType("TEXT");

                    b.Property<string>("Frequency")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Target")
                        .HasColumnType("TEXT");

                    b.HasKey("AbilityGUID");

                    b.ToTable("DataAbilities");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Data.PokDataCapability", b =>
                {
                    b.Property<Guid>("CapabilityGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Frequency")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("CapabilityGUID");

                    b.ToTable("DataCapabilities");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Data.PokDataEdge", b =>
                {
                    b.Property<Guid>("EdgeGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("EdgeGUID");

                    b.ToTable("DataEdges");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Data.PokDataMove", b =>
                {
                    b.Property<Guid>("MoveGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AC")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CritsOn")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DamageBase")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DamageType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Effect")
                        .HasColumnType("TEXT");

                    b.Property<string>("MoveName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Range")
                        .HasColumnType("TEXT");

                    b.HasKey("MoveGUID");

                    b.ToTable("DataMoves");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokCompletePreset", b =>
                {
                    b.Property<Guid>("PokemonGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("ExperiencePoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Pokedex")
                        .HasColumnType("INTEGER");

                    b.HasKey("PokemonGUID");

                    b.ToTable("PokemonPresets");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetAbility", b =>
                {
                    b.Property<Guid>("AbilityGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DataPokemonPokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Effect")
                        .HasColumnType("TEXT");

                    b.Property<string>("Frequency")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Target")
                        .HasColumnType("TEXT");

                    b.HasKey("AbilityGUID");

                    b.HasIndex("DataPokemonPokemonGUID");

                    b.ToTable("PokPresetAbility");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetAdditionalInfo", b =>
                {
                    b.Property<Guid>("InfoGUID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diet")
                        .HasColumnType("TEXT");

                    b.Property<string>("EggGroup")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("GenderRatio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Habitat")
                        .HasColumnType("TEXT");

                    b.Property<string>("HatchRate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Height")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type1")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Type2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Weight")
                        .HasColumnType("TEXT");

                    b.Property<int>("Weightclass")
                        .HasColumnType("INTEGER");

                    b.HasKey("InfoGUID");

                    b.ToTable("PokPresetAdditionalInfo");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetCapability", b =>
                {
                    b.Property<Guid>("CapabilityGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DataPokemonPokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Frequency")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("CapabilityGUID");

                    b.HasIndex("DataPokemonPokemonGUID");

                    b.ToTable("PokPresetCapability");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetEdge", b =>
                {
                    b.Property<Guid>("EdgeGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DataPokemonPokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("EdgeGUID");

                    b.HasIndex("DataPokemonPokemonGUID");

                    b.ToTable("PokPresetEdge");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetEvolutionInfo", b =>
                {
                    b.Property<Guid>("EvolutionInfoGUID")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Evolution0PokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Evolution1PokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Evolution2PokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EvolutionLevel1")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EvolutionLevel2")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasEvolution")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasSecondEvolution")
                        .HasColumnType("INTEGER");

                    b.HasKey("EvolutionInfoGUID");

                    b.HasIndex("Evolution0PokemonGUID");

                    b.HasIndex("Evolution1PokemonGUID");

                    b.HasIndex("Evolution2PokemonGUID");

                    b.ToTable("PokPresetEvolutionInfo");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetMove", b =>
                {
                    b.Property<Guid>("MoveGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AC")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CritsOn")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DamageBase")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DamageType")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("DataPokemonPokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Effect")
                        .HasColumnType("TEXT");

                    b.Property<int>("LearnLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoveClass")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MoveName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Range")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TypicalMove")
                        .HasColumnType("INTEGER");

                    b.HasKey("MoveGUID");

                    b.HasIndex("DataPokemonPokemonGUID");

                    b.ToTable("PokPresetMove");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetSkill", b =>
                {
                    b.Property<Guid>("SkillGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DataPokemonPokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<int>("SkillType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value2")
                        .HasColumnType("TEXT");

                    b.HasKey("SkillGUID");

                    b.HasIndex("DataPokemonPokemonGUID");

                    b.ToTable("PokPresetSkill");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetStat", b =>
                {
                    b.Property<Guid>("StatGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DataPokemonPokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatValue")
                        .HasColumnType("INTEGER");

                    b.HasKey("StatGUID");

                    b.HasIndex("DataPokemonPokemonGUID");

                    b.ToTable("PokPresetStat");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetAbility", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokCompletePreset", "DataPokemon")
                        .WithMany("PresetAbilities")
                        .HasForeignKey("DataPokemonPokemonGUID");

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetAdditionalInfo", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokCompletePreset", "DataPokemon")
                        .WithOne("AdditionalInfo")
                        .HasForeignKey("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetAdditionalInfo", "InfoGUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetCapability", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokCompletePreset", "DataPokemon")
                        .WithMany("PresetCapabilities")
                        .HasForeignKey("DataPokemonPokemonGUID");

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetEdge", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokCompletePreset", "DataPokemon")
                        .WithMany("PresetEdges")
                        .HasForeignKey("DataPokemonPokemonGUID");

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetEvolutionInfo", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokCompletePreset", "Evolution0")
                        .WithMany()
                        .HasForeignKey("Evolution0PokemonGUID");

                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokCompletePreset", "Evolution1")
                        .WithMany()
                        .HasForeignKey("Evolution1PokemonGUID");

                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokCompletePreset", "Evolution2")
                        .WithMany()
                        .HasForeignKey("Evolution2PokemonGUID");

                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetAdditionalInfo", "PresetAdditionalInfo")
                        .WithOne("EvolutionInfo")
                        .HasForeignKey("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetEvolutionInfo", "EvolutionInfoGUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evolution0");

                    b.Navigation("Evolution1");

                    b.Navigation("Evolution2");

                    b.Navigation("PresetAdditionalInfo");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetMove", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokCompletePreset", "DataPokemon")
                        .WithMany("PresetMoveList")
                        .HasForeignKey("DataPokemonPokemonGUID");

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetSkill", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokCompletePreset", "DataPokemon")
                        .WithMany("PresetSkills")
                        .HasForeignKey("DataPokemonPokemonGUID");

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetStat", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokCompletePreset", "DataPokemon")
                        .WithMany("PresetStats")
                        .HasForeignKey("DataPokemonPokemonGUID");

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokCompletePreset", b =>
                {
                    b.Navigation("AdditionalInfo");

                    b.Navigation("PresetAbilities");

                    b.Navigation("PresetCapabilities");

                    b.Navigation("PresetEdges");

                    b.Navigation("PresetMoveList");

                    b.Navigation("PresetSkills");

                    b.Navigation("PresetStats");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonDataContext.Model.Preset.PokPresetAdditionalInfo", b =>
                {
                    b.Navigation("EvolutionInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
