﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PNP.Services.Service.Databases.Modules.Pokemon.Contexts;

namespace PNP.Services.Service.Migrations
{
    [DbContext(typeof(PokemonDataContext))]
    partial class PokemonDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.DataAbility", b =>
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

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.DataCapability", b =>
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

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.DataEdge", b =>
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

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.DataMove", b =>
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

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PokemonPreset", b =>
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

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetAbility", b =>
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

                    b.ToTable("PresetAbility");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetAdditionalInfo", b =>
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

                    b.ToTable("PresetAdditionalInfo");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetCapability", b =>
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

                    b.ToTable("PresetCapability");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetEdge", b =>
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

                    b.ToTable("PresetEdge");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetEvolutionInfo", b =>
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

                    b.ToTable("PresetEvolutionInfo");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetMove", b =>
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

                    b.ToTable("PresetMove");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetSkill", b =>
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

                    b.ToTable("PresetSkill");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetStat", b =>
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

                    b.ToTable("PresetStat");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetAbility", b =>
                {
                    b.HasOne("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PokemonPreset", "DataPokemon")
                        .WithMany("PresetAbilities")
                        .HasForeignKey("DataPokemonPokemonGUID");

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetAdditionalInfo", b =>
                {
                    b.HasOne("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PokemonPreset", "DataPokemon")
                        .WithOne("AdditionalInfo")
                        .HasForeignKey("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetAdditionalInfo", "InfoGUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetCapability", b =>
                {
                    b.HasOne("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PokemonPreset", "DataPokemon")
                        .WithMany("PresetCapabilities")
                        .HasForeignKey("DataPokemonPokemonGUID");

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetEdge", b =>
                {
                    b.HasOne("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PokemonPreset", "DataPokemon")
                        .WithMany("PresetEdges")
                        .HasForeignKey("DataPokemonPokemonGUID");

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetEvolutionInfo", b =>
                {
                    b.HasOne("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PokemonPreset", "Evolution0")
                        .WithMany()
                        .HasForeignKey("Evolution0PokemonGUID");

                    b.HasOne("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PokemonPreset", "Evolution1")
                        .WithMany()
                        .HasForeignKey("Evolution1PokemonGUID");

                    b.HasOne("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PokemonPreset", "Evolution2")
                        .WithMany()
                        .HasForeignKey("Evolution2PokemonGUID");

                    b.HasOne("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetAdditionalInfo", "PresetAdditionalInfo")
                        .WithOne("EvolutionInfo")
                        .HasForeignKey("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetEvolutionInfo", "EvolutionInfoGUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evolution0");

                    b.Navigation("Evolution1");

                    b.Navigation("Evolution2");

                    b.Navigation("PresetAdditionalInfo");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetMove", b =>
                {
                    b.HasOne("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PokemonPreset", "DataPokemon")
                        .WithMany("PresetMoveList")
                        .HasForeignKey("DataPokemonPokemonGUID");

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetSkill", b =>
                {
                    b.HasOne("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PokemonPreset", "DataPokemon")
                        .WithMany("PresetSkills")
                        .HasForeignKey("DataPokemonPokemonGUID");

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetStat", b =>
                {
                    b.HasOne("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PokemonPreset", "DataPokemon")
                        .WithMany("PresetStats")
                        .HasForeignKey("DataPokemonPokemonGUID");

                    b.Navigation("DataPokemon");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PokemonPreset", b =>
                {
                    b.Navigation("AdditionalInfo");

                    b.Navigation("PresetAbilities");

                    b.Navigation("PresetCapabilities");

                    b.Navigation("PresetEdges");

                    b.Navigation("PresetMoveList");

                    b.Navigation("PresetSkills");

                    b.Navigation("PresetStats");
                });

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.DataContext.PresetAdditionalInfo", b =>
                {
                    b.Navigation("EvolutionInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
