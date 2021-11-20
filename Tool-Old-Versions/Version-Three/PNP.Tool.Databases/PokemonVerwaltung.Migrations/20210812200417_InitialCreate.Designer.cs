﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PNP.Tool.Databases.PokemonVerwaltung;

namespace PNP.Tool.Databases.PokemonVerwaltung.Migrations
{
    [DbContext(typeof(PokemonContext))]
    [Migration("20210812200417_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("PNP.Tool.Models.Base.HistorieEntry", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ChangeDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjectAfterChange")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjectBeforChange")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TrackedObjectFK")
                        .HasColumnType("TEXT");

                    b.HasKey("GUID");

                    b.ToTable("HistorieEntry");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability.PokemonBaseAbility", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Effect")
                        .HasColumnType("TEXT");

                    b.Property<string>("Frequency")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Target")
                        .HasColumnType("TEXT");

                    b.HasKey("GUID");

                    b.ToTable("PokemonAbility");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PokemonBaseAbility");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Capability.PokemonCapability", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PokemonFK")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("GUID");

                    b.HasIndex("PokemonFK");

                    b.ToTable("PokemonCapability");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Edge.PokemonBaseEdge", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("GUID");

                    b.ToTable("PokemonEdge");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PokemonBaseEdge");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move.PokemonBaseMove", b =>
                {
                    b.Property<Guid>("GUID")
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

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Effect")
                        .HasColumnType("TEXT");

                    b.Property<string>("Range")
                        .HasColumnType("TEXT");

                    b.HasKey("GUID");

                    b.ToTable("PokemonMove");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PokemonBaseMove");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.PokedexPokemon", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Acrobatics")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AdvancedAbility2FK")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AdvancedAbilityFK")
                        .HasColumnType("TEXT");

                    b.Property<string>("Athletics")
                        .HasColumnType("TEXT");

                    b.Property<int>("BaseAttack")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseDefense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseHP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseSPAttack")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseSPDefense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseSpeed")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("BasicAbilityFK")
                        .HasColumnType("TEXT");

                    b.Property<string>("Combat")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diet")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EggGroup")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EvolutionLevel1")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EvolutionLevel2")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("EvolutionPokemon1")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("EvolutionPokemon2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Focus")
                        .HasColumnType("TEXT");

                    b.Property<string>("GenderRatio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Habitat")
                        .HasColumnType("TEXT");

                    b.Property<string>("HatchRate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Height")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("HighAbilityFK")
                        .HasColumnType("TEXT");

                    b.Property<string>("Perception")
                        .HasColumnType("TEXT");

                    b.Property<int>("Pokedex")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Stealth")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type1")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Type2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Weight")
                        .HasColumnType("TEXT");

                    b.Property<int>("Weightclass")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("WildcardAbilityFK")
                        .HasColumnType("TEXT");

                    b.Property<bool>("WildcardAbilityIsBasic")
                        .HasColumnType("INTEGER");

                    b.HasKey("GUID");

                    b.HasIndex("AdvancedAbility2FK");

                    b.HasIndex("AdvancedAbilityFK");

                    b.HasIndex("BasicAbilityFK");

                    b.HasIndex("HighAbilityFK");

                    b.HasIndex("WildcardAbilityFK");

                    b.ToTable("Pokemon");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PokedexPokemon");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Trainer.BaseTrainer", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.HasKey("GUID");

                    b.ToTable("Trainer");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability.PokemonAbility", b =>
                {
                    b.HasBaseType("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability.PokemonBaseAbility");

                    b.Property<Guid>("PokemonFK")
                        .HasColumnType("TEXT");

                    b.HasIndex("PokemonFK");

                    b.HasDiscriminator().HasValue("PokemonAbility");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Edge.PokemonEdge", b =>
                {
                    b.HasBaseType("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Edge.PokemonBaseEdge");

                    b.Property<Guid>("PokemonFK")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TrainerPokemonGUID")
                        .HasColumnType("TEXT");

                    b.HasIndex("PokemonFK");

                    b.HasIndex("TrainerPokemonGUID");

                    b.HasDiscriminator().HasValue("PokemonEdge");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move.PokemonLearnMove", b =>
                {
                    b.HasBaseType("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move.PokemonBaseMove");

                    b.Property<int>("LearnLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoveClass")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("PokemonFK")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TypicalMove")
                        .HasColumnType("INTEGER");

                    b.HasIndex("PokemonFK");

                    b.HasDiscriminator().HasValue("PokemonLearnMove");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.TrainerPokemon", b =>
                {
                    b.HasBaseType("PNP.Tool.Models.PokemonVerwaltung.Pokemon.PokedexPokemon");

                    b.Property<int>("AllocatedAttack")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AllocatedDefense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AllocatedHP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AllocatedSPAttack")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AllocatedSPDefense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AllocatedSpeed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExperiencePoints")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nature")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("TrainerFK")
                        .HasColumnType("TEXT");

                    b.HasIndex("TrainerFK");

                    b.HasDiscriminator().HasValue("TrainerPokemon");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move.PokemonMove", b =>
                {
                    b.HasBaseType("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move.PokemonLearnMove");

                    b.Property<Guid>("TrainerPokemonFK")
                        .HasColumnType("TEXT");

                    b.HasIndex("TrainerPokemonFK");

                    b.HasDiscriminator().HasValue("PokemonMove");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Capability.PokemonCapability", b =>
                {
                    b.HasOne("PNP.Tool.Models.PokemonVerwaltung.Pokemon.PokedexPokemon", "Pokemon")
                        .WithMany("PokemonCapabilities")
                        .HasForeignKey("PokemonFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.PokedexPokemon", b =>
                {
                    b.HasOne("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability.PokemonBaseAbility", "AdvancedAbility2")
                        .WithMany()
                        .HasForeignKey("AdvancedAbility2FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability.PokemonBaseAbility", "AdvancedAbility")
                        .WithMany()
                        .HasForeignKey("AdvancedAbilityFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability.PokemonBaseAbility", "BasicAbility")
                        .WithMany()
                        .HasForeignKey("BasicAbilityFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability.PokemonBaseAbility", "HighAbility")
                        .WithMany()
                        .HasForeignKey("HighAbilityFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability.PokemonBaseAbility", "WildcardAbility")
                        .WithMany()
                        .HasForeignKey("WildcardAbilityFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdvancedAbility");

                    b.Navigation("AdvancedAbility2");

                    b.Navigation("BasicAbility");

                    b.Navigation("HighAbility");

                    b.Navigation("WildcardAbility");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Ability.PokemonAbility", b =>
                {
                    b.HasOne("PNP.Tool.Models.PokemonVerwaltung.Pokemon.TrainerPokemon", "Pokemon")
                        .WithMany("PokemonAbilites")
                        .HasForeignKey("PokemonFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Edge.PokemonEdge", b =>
                {
                    b.HasOne("PNP.Tool.Models.PokemonVerwaltung.Pokemon.PokedexPokemon", "Pokemon")
                        .WithMany()
                        .HasForeignKey("PokemonFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PNP.Tool.Models.PokemonVerwaltung.Pokemon.TrainerPokemon", null)
                        .WithMany("PokemonEdges")
                        .HasForeignKey("TrainerPokemonGUID");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move.PokemonLearnMove", b =>
                {
                    b.HasOne("PNP.Tool.Models.PokemonVerwaltung.Pokemon.PokedexPokemon", "Pokemon")
                        .WithMany("PokemonLearnMoves")
                        .HasForeignKey("PokemonFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.TrainerPokemon", b =>
                {
                    b.HasOne("PNP.Tool.Models.PokemonVerwaltung.Trainer.BaseTrainer", "Trainer")
                        .WithMany()
                        .HasForeignKey("TrainerFK");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.Move.PokemonMove", b =>
                {
                    b.HasOne("PNP.Tool.Models.PokemonVerwaltung.Pokemon.TrainerPokemon", "TrainerPokemon")
                        .WithMany("PokemonMoves")
                        .HasForeignKey("TrainerPokemonFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainerPokemon");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.PokedexPokemon", b =>
                {
                    b.Navigation("PokemonCapabilities");

                    b.Navigation("PokemonLearnMoves");
                });

            modelBuilder.Entity("PNP.Tool.Models.PokemonVerwaltung.Pokemon.TrainerPokemon", b =>
                {
                    b.Navigation("PokemonAbilites");

                    b.Navigation("PokemonEdges");

                    b.Navigation("PokemonMoves");
                });
#pragma warning restore 612, 618
        }
    }
}