using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PNP.Tool.Databases.PokemonVerwaltung.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistorieEntry",
                columns: table => new
                {
                    GUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    ChangeDescription = table.Column<string>(type: "TEXT", nullable: true),
                    ObjectBeforChange = table.Column<string>(type: "TEXT", nullable: true),
                    ObjectAfterChange = table.Column<string>(type: "TEXT", nullable: true),
                    TrackedObjectFK = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorieEntry", x => x.GUID);
                });

            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    GUID = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.GUID);
                });

            migrationBuilder.CreateTable(
                name: "PokemonAbility",
                columns: table => new
                {
                    GUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Frequency = table.Column<string>(type: "TEXT", nullable: true),
                    Target = table.Column<string>(type: "TEXT", nullable: true),
                    Effect = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    PokemonFK = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonAbility", x => x.GUID);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    GUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Pokedex = table.Column<int>(type: "INTEGER", nullable: false),
                    Athletics = table.Column<string>(type: "TEXT", nullable: true),
                    Acrobatics = table.Column<string>(type: "TEXT", nullable: true),
                    Combat = table.Column<string>(type: "TEXT", nullable: true),
                    Stealth = table.Column<string>(type: "TEXT", nullable: true),
                    Perception = table.Column<string>(type: "TEXT", nullable: true),
                    Focus = table.Column<string>(type: "TEXT", nullable: true),
                    BaseHP = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseAttack = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseDefense = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseSPAttack = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseSPDefense = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseSpeed = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<string>(type: "TEXT", nullable: true),
                    Weight = table.Column<string>(type: "TEXT", nullable: true),
                    Weightclass = table.Column<int>(type: "INTEGER", nullable: false),
                    Type1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Type2 = table.Column<int>(type: "INTEGER", nullable: true),
                    GenderRatio = table.Column<string>(type: "TEXT", nullable: true),
                    EggGroup = table.Column<string>(type: "TEXT", nullable: true),
                    HatchRate = table.Column<string>(type: "TEXT", nullable: true),
                    Diet = table.Column<string>(type: "TEXT", nullable: true),
                    Habitat = table.Column<string>(type: "TEXT", nullable: true),
                    EvolutionLevel1 = table.Column<int>(type: "INTEGER", nullable: true),
                    EvolutionPokemon1 = table.Column<Guid>(type: "TEXT", nullable: true),
                    EvolutionLevel2 = table.Column<int>(type: "INTEGER", nullable: true),
                    EvolutionPokemon2 = table.Column<Guid>(type: "TEXT", nullable: true),
                    WildcardAbilityIsBasic = table.Column<bool>(type: "INTEGER", nullable: false),
                    BasicAbilityFK = table.Column<Guid>(type: "TEXT", nullable: false),
                    WildcardAbilityFK = table.Column<Guid>(type: "TEXT", nullable: false),
                    AdvancedAbilityFK = table.Column<Guid>(type: "TEXT", nullable: false),
                    AdvancedAbility2FK = table.Column<Guid>(type: "TEXT", nullable: false),
                    HighAbilityFK = table.Column<Guid>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: true),
                    ExperiencePoints = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    Nature = table.Column<string>(type: "TEXT", nullable: true),
                    AllocatedHP = table.Column<int>(type: "INTEGER", nullable: true),
                    AllocatedAttack = table.Column<int>(type: "INTEGER", nullable: true),
                    AllocatedDefense = table.Column<int>(type: "INTEGER", nullable: true),
                    AllocatedSPAttack = table.Column<int>(type: "INTEGER", nullable: true),
                    AllocatedSPDefense = table.Column<int>(type: "INTEGER", nullable: true),
                    AllocatedSpeed = table.Column<int>(type: "INTEGER", nullable: true),
                    TrainerFK = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.GUID);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonAbility_AdvancedAbility2FK",
                        column: x => x.AdvancedAbility2FK,
                        principalTable: "PokemonAbility",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonAbility_AdvancedAbilityFK",
                        column: x => x.AdvancedAbilityFK,
                        principalTable: "PokemonAbility",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonAbility_BasicAbilityFK",
                        column: x => x.BasicAbilityFK,
                        principalTable: "PokemonAbility",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonAbility_HighAbilityFK",
                        column: x => x.HighAbilityFK,
                        principalTable: "PokemonAbility",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_PokemonAbility_WildcardAbilityFK",
                        column: x => x.WildcardAbilityFK,
                        principalTable: "PokemonAbility",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Trainer_TrainerFK",
                        column: x => x.TrainerFK,
                        principalTable: "Trainer",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokemonCapability",
                columns: table => new
                {
                    GUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    PokemonFK = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonCapability", x => x.GUID);
                    table.ForeignKey(
                        name: "FK_PokemonCapability_Pokemon_PokemonFK",
                        column: x => x.PokemonFK,
                        principalTable: "Pokemon",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonEdge",
                columns: table => new
                {
                    GUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    PokemonFK = table.Column<Guid>(type: "TEXT", nullable: true),
                    TrainerPokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonEdge", x => x.GUID);
                    table.ForeignKey(
                        name: "FK_PokemonEdge_Pokemon_PokemonFK",
                        column: x => x.PokemonFK,
                        principalTable: "Pokemon",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonEdge_Pokemon_TrainerPokemonGUID",
                        column: x => x.TrainerPokemonGUID,
                        principalTable: "Pokemon",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokemonMove",
                columns: table => new
                {
                    GUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    AC = table.Column<int>(type: "INTEGER", nullable: false),
                    CritsOn = table.Column<int>(type: "INTEGER", nullable: false),
                    DamageBase = table.Column<int>(type: "INTEGER", nullable: false),
                    DamageType = table.Column<int>(type: "INTEGER", nullable: false),
                    Range = table.Column<string>(type: "TEXT", nullable: true),
                    Effect = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    LearnLevel = table.Column<int>(type: "INTEGER", nullable: true),
                    TypicalMove = table.Column<bool>(type: "INTEGER", nullable: true),
                    MoveClass = table.Column<int>(type: "INTEGER", nullable: true),
                    PokemonFK = table.Column<Guid>(type: "TEXT", nullable: true),
                    TrainerPokemonFK = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonMove", x => x.GUID);
                    table.ForeignKey(
                        name: "FK_PokemonMove_Pokemon_PokemonFK",
                        column: x => x.PokemonFK,
                        principalTable: "Pokemon",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonMove_Pokemon_TrainerPokemonFK",
                        column: x => x.TrainerPokemonFK,
                        principalTable: "Pokemon",
                        principalColumn: "GUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_AdvancedAbility2FK",
                table: "Pokemon",
                column: "AdvancedAbility2FK");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_AdvancedAbilityFK",
                table: "Pokemon",
                column: "AdvancedAbilityFK");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_BasicAbilityFK",
                table: "Pokemon",
                column: "BasicAbilityFK");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_HighAbilityFK",
                table: "Pokemon",
                column: "HighAbilityFK");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_TrainerFK",
                table: "Pokemon",
                column: "TrainerFK");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_WildcardAbilityFK",
                table: "Pokemon",
                column: "WildcardAbilityFK");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonAbility_PokemonFK",
                table: "PokemonAbility",
                column: "PokemonFK");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonCapability_PokemonFK",
                table: "PokemonCapability",
                column: "PokemonFK");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonEdge_PokemonFK",
                table: "PokemonEdge",
                column: "PokemonFK");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonEdge_TrainerPokemonGUID",
                table: "PokemonEdge",
                column: "TrainerPokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMove_PokemonFK",
                table: "PokemonMove",
                column: "PokemonFK");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMove_TrainerPokemonFK",
                table: "PokemonMove",
                column: "TrainerPokemonFK");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonAbility_Pokemon_PokemonFK",
                table: "PokemonAbility",
                column: "PokemonFK",
                principalTable: "Pokemon",
                principalColumn: "GUID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokemonAbility_AdvancedAbility2FK",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokemonAbility_AdvancedAbilityFK",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokemonAbility_BasicAbilityFK",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokemonAbility_HighAbilityFK",
                table: "Pokemon");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemon_PokemonAbility_WildcardAbilityFK",
                table: "Pokemon");

            migrationBuilder.DropTable(
                name: "HistorieEntry");

            migrationBuilder.DropTable(
                name: "PokemonCapability");

            migrationBuilder.DropTable(
                name: "PokemonEdge");

            migrationBuilder.DropTable(
                name: "PokemonMove");

            migrationBuilder.DropTable(
                name: "PokemonAbility");

            migrationBuilder.DropTable(
                name: "Pokemon");

            migrationBuilder.DropTable(
                name: "Trainer");
        }
    }
}
