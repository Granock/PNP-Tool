using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PNP_Services.Databases.Modules.PKVerwaltungstool.PokemonMainContext.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    PokemonGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    TrainerGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Pokedex = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    ExperiencePoints = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.PokemonGUID);
                });

            migrationBuilder.CreateTable(
                name: "PokemonAbility",
                columns: table => new
                {
                    AbilityGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    PokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Frequency = table.Column<string>(type: "TEXT", nullable: true),
                    Target = table.Column<string>(type: "TEXT", nullable: true),
                    Effect = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonAbility", x => x.AbilityGUID);
                    table.ForeignKey(
                        name: "FK_PokemonAbility_Pokemons_PokemonGUID",
                        column: x => x.PokemonGUID,
                        principalTable: "Pokemons",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokemonAdditionalInfo",
                columns: table => new
                {
                    InfoGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataPresetGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Height = table.Column<string>(type: "TEXT", nullable: true),
                    Weight = table.Column<string>(type: "TEXT", nullable: true),
                    Weightclass = table.Column<int>(type: "INTEGER", nullable: false),
                    Type1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Type2 = table.Column<int>(type: "INTEGER", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    GenderRatio = table.Column<string>(type: "TEXT", nullable: true),
                    EggGroup = table.Column<string>(type: "TEXT", nullable: true),
                    HatchRate = table.Column<string>(type: "TEXT", nullable: true),
                    Diet = table.Column<string>(type: "TEXT", nullable: true),
                    Habitat = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonAdditionalInfo", x => x.InfoGUID);
                    table.ForeignKey(
                        name: "FK_PokemonAdditionalInfo_Pokemons_InfoGUID",
                        column: x => x.InfoGUID,
                        principalTable: "Pokemons",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonCapability",
                columns: table => new
                {
                    CapabilityGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    PokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    Frequency = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonCapability", x => x.CapabilityGUID);
                    table.ForeignKey(
                        name: "FK_PokemonCapability_Pokemons_PokemonGUID",
                        column: x => x.PokemonGUID,
                        principalTable: "Pokemons",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokemonEdge",
                columns: table => new
                {
                    EdgeGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    PokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonEdge", x => x.EdgeGUID);
                    table.ForeignKey(
                        name: "FK_PokemonEdge_Pokemons_PokemonGUID",
                        column: x => x.PokemonGUID,
                        principalTable: "Pokemons",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokemonMove",
                columns: table => new
                {
                    MoveGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    LearnLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    TypicalMove = table.Column<bool>(type: "INTEGER", nullable: false),
                    MoveClass = table.Column<int>(type: "INTEGER", nullable: false),
                    PokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    MoveName = table.Column<string>(type: "TEXT", nullable: true),
                    AC = table.Column<int>(type: "INTEGER", nullable: false),
                    CritsOn = table.Column<int>(type: "INTEGER", nullable: false),
                    DamageBase = table.Column<int>(type: "INTEGER", nullable: false),
                    DamageType = table.Column<int>(type: "INTEGER", nullable: false),
                    Range = table.Column<string>(type: "TEXT", nullable: true),
                    Effect = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonMove", x => x.MoveGUID);
                    table.ForeignKey(
                        name: "FK_PokemonMove_Pokemons_PokemonGUID",
                        column: x => x.PokemonGUID,
                        principalTable: "Pokemons",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokemonSkill",
                columns: table => new
                {
                    SkillGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    PokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    SkillType = table.Column<int>(type: "INTEGER", nullable: false),
                    Value1 = table.Column<string>(type: "TEXT", nullable: true),
                    Value2 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonSkill", x => x.SkillGUID);
                    table.ForeignKey(
                        name: "FK_PokemonSkill_Pokemons_PokemonGUID",
                        column: x => x.PokemonGUID,
                        principalTable: "Pokemons",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokemonStat",
                columns: table => new
                {
                    StatGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    PokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    StatType = table.Column<int>(type: "INTEGER", nullable: false),
                    StatValue = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonStat", x => x.StatGUID);
                    table.ForeignKey(
                        name: "FK_PokemonStat_Pokemons_PokemonGUID",
                        column: x => x.PokemonGUID,
                        principalTable: "Pokemons",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonAbility_PokemonGUID",
                table: "PokemonAbility",
                column: "PokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonCapability_PokemonGUID",
                table: "PokemonCapability",
                column: "PokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonEdge_PokemonGUID",
                table: "PokemonEdge",
                column: "PokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonMove_PokemonGUID",
                table: "PokemonMove",
                column: "PokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonSkill_PokemonGUID",
                table: "PokemonSkill",
                column: "PokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonStat_PokemonGUID",
                table: "PokemonStat",
                column: "PokemonGUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonAbility");

            migrationBuilder.DropTable(
                name: "PokemonAdditionalInfo");

            migrationBuilder.DropTable(
                name: "PokemonCapability");

            migrationBuilder.DropTable(
                name: "PokemonEdge");

            migrationBuilder.DropTable(
                name: "PokemonMove");

            migrationBuilder.DropTable(
                name: "PokemonSkill");

            migrationBuilder.DropTable(
                name: "PokemonStat");

            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
