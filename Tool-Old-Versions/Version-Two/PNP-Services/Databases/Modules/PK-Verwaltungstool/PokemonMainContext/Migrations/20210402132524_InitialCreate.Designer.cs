// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext;

namespace PNP_Services.Databases.Modules.PKVerwaltungstool.PokemonMainContext.Migrations
{
    [DbContext(typeof(PokMainContext))]
    [Migration("20210402132524_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.Pokemon", b =>
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

                    b.Property<Guid>("TrainerGUID")
                        .HasColumnType("TEXT");

                    b.HasKey("PokemonGUID");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonAbility", b =>
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

                    b.Property<Guid?>("PokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Target")
                        .HasColumnType("TEXT");

                    b.HasKey("AbilityGUID");

                    b.HasIndex("PokemonGUID");

                    b.ToTable("PokemonAbility");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonAdditionalInfo", b =>
                {
                    b.Property<Guid>("InfoGUID")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DataPresetGUID")
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

                    b.ToTable("PokemonAdditionalInfo");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonCapability", b =>
                {
                    b.Property<Guid>("CapabilityGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Frequency")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("CapabilityGUID");

                    b.HasIndex("PokemonGUID");

                    b.ToTable("PokemonCapability");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonEdge", b =>
                {
                    b.Property<Guid>("EdgeGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("EdgeGUID");

                    b.HasIndex("PokemonGUID");

                    b.ToTable("PokemonEdge");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonMove", b =>
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

                    b.Property<int>("LearnLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MoveClass")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MoveName")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Range")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TypicalMove")
                        .HasColumnType("INTEGER");

                    b.HasKey("MoveGUID");

                    b.HasIndex("PokemonGUID");

                    b.ToTable("PokemonMove");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonSkill", b =>
                {
                    b.Property<Guid>("SkillGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<int>("SkillType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value2")
                        .HasColumnType("TEXT");

                    b.HasKey("SkillGUID");

                    b.HasIndex("PokemonGUID");

                    b.ToTable("PokemonSkill");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonStat", b =>
                {
                    b.Property<Guid>("StatGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PokemonGUID")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatValue")
                        .HasColumnType("INTEGER");

                    b.HasKey("StatGUID");

                    b.HasIndex("PokemonGUID");

                    b.ToTable("PokemonStat");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonAbility", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.Pokemon", "Pokemon")
                        .WithMany("PokemonAbilities")
                        .HasForeignKey("PokemonGUID");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonAdditionalInfo", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.Pokemon", "Pokemon")
                        .WithOne("AdditionalInfo")
                        .HasForeignKey("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonAdditionalInfo", "InfoGUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonCapability", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.Pokemon", "Pokemon")
                        .WithMany("PokemonCapabilities")
                        .HasForeignKey("PokemonGUID");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonEdge", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.Pokemon", "Pokemon")
                        .WithMany("PokemonEdges")
                        .HasForeignKey("PokemonGUID");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonMove", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.Pokemon", "Pokemon")
                        .WithMany("PokemonMoves")
                        .HasForeignKey("PokemonGUID");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonSkill", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.Pokemon", "Pokemon")
                        .WithMany("PokemonSkills")
                        .HasForeignKey("PokemonGUID");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.PokemonStat", b =>
                {
                    b.HasOne("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.Pokemon", "Pokemon")
                        .WithMany("PokemonStats")
                        .HasForeignKey("PokemonGUID");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.PokemonMainContext.Model.Pokemon", b =>
                {
                    b.Navigation("AdditionalInfo");

                    b.Navigation("PokemonAbilities");

                    b.Navigation("PokemonCapabilities");

                    b.Navigation("PokemonEdges");

                    b.Navigation("PokemonMoves");

                    b.Navigation("PokemonSkills");

                    b.Navigation("PokemonStats");
                });
#pragma warning restore 612, 618
        }
    }
}
