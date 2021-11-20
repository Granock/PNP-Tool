using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PNP_Services.Databases.Modules.PKVerwaltungstool.PokemonDataContext.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataAbilities",
                columns: table => new
                {
                    AbilityGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Frequency = table.Column<string>(type: "TEXT", nullable: true),
                    Target = table.Column<string>(type: "TEXT", nullable: true),
                    Effect = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataAbilities", x => x.AbilityGUID);
                });

            migrationBuilder.CreateTable(
                name: "DataCapabilities",
                columns: table => new
                {
                    CapabilityGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    Frequency = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCapabilities", x => x.CapabilityGUID);
                });

            migrationBuilder.CreateTable(
                name: "DataEdges",
                columns: table => new
                {
                    EdgeGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataEdges", x => x.EdgeGUID);
                });

            migrationBuilder.CreateTable(
                name: "DataMoves",
                columns: table => new
                {
                    MoveGUID = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    table.PrimaryKey("PK_DataMoves", x => x.MoveGUID);
                });

            migrationBuilder.CreateTable(
                name: "PokemonPresets",
                columns: table => new
                {
                    PokemonGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Pokedex = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    ExperiencePoints = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonPresets", x => x.PokemonGUID);
                });

            migrationBuilder.CreateTable(
                name: "PokPresetAbility",
                columns: table => new
                {
                    AbilityGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataPokemonPokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Frequency = table.Column<string>(type: "TEXT", nullable: true),
                    Target = table.Column<string>(type: "TEXT", nullable: true),
                    Effect = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokPresetAbility", x => x.AbilityGUID);
                    table.ForeignKey(
                        name: "FK_PokPresetAbility_PokemonPresets_DataPokemonPokemonGUID",
                        column: x => x.DataPokemonPokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokPresetAdditionalInfo",
                columns: table => new
                {
                    InfoGUID = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    table.PrimaryKey("PK_PokPresetAdditionalInfo", x => x.InfoGUID);
                    table.ForeignKey(
                        name: "FK_PokPresetAdditionalInfo_PokemonPresets_InfoGUID",
                        column: x => x.InfoGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokPresetCapability",
                columns: table => new
                {
                    CapabilityGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataPokemonPokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    Frequency = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokPresetCapability", x => x.CapabilityGUID);
                    table.ForeignKey(
                        name: "FK_PokPresetCapability_PokemonPresets_DataPokemonPokemonGUID",
                        column: x => x.DataPokemonPokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokPresetEdge",
                columns: table => new
                {
                    EdgeGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataPokemonPokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokPresetEdge", x => x.EdgeGUID);
                    table.ForeignKey(
                        name: "FK_PokPresetEdge_PokemonPresets_DataPokemonPokemonGUID",
                        column: x => x.DataPokemonPokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokPresetMove",
                columns: table => new
                {
                    MoveGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    LearnLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    TypicalMove = table.Column<bool>(type: "INTEGER", nullable: false),
                    MoveClass = table.Column<int>(type: "INTEGER", nullable: false),
                    DataPokemonPokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
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
                    table.PrimaryKey("PK_PokPresetMove", x => x.MoveGUID);
                    table.ForeignKey(
                        name: "FK_PokPresetMove_PokemonPresets_DataPokemonPokemonGUID",
                        column: x => x.DataPokemonPokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokPresetSkill",
                columns: table => new
                {
                    SkillGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataPokemonPokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    SkillType = table.Column<int>(type: "INTEGER", nullable: false),
                    Value1 = table.Column<string>(type: "TEXT", nullable: true),
                    Value2 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokPresetSkill", x => x.SkillGUID);
                    table.ForeignKey(
                        name: "FK_PokPresetSkill_PokemonPresets_DataPokemonPokemonGUID",
                        column: x => x.DataPokemonPokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokPresetStat",
                columns: table => new
                {
                    StatGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataPokemonPokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    StatType = table.Column<int>(type: "INTEGER", nullable: false),
                    StatValue = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokPresetStat", x => x.StatGUID);
                    table.ForeignKey(
                        name: "FK_PokPresetStat_PokemonPresets_DataPokemonPokemonGUID",
                        column: x => x.DataPokemonPokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PokPresetEvolutionInfo",
                columns: table => new
                {
                    EvolutionInfoGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Evolution0PokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    Evolution1PokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    Evolution2PokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    EvolutionLevel1 = table.Column<int>(type: "INTEGER", nullable: true),
                    HasEvolution = table.Column<bool>(type: "INTEGER", nullable: false),
                    EvolutionLevel2 = table.Column<int>(type: "INTEGER", nullable: true),
                    HasSecondEvolution = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokPresetEvolutionInfo", x => x.EvolutionInfoGUID);
                    table.ForeignKey(
                        name: "FK_PokPresetEvolutionInfo_PokemonPresets_Evolution0PokemonGUID",
                        column: x => x.Evolution0PokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokPresetEvolutionInfo_PokemonPresets_Evolution1PokemonGUID",
                        column: x => x.Evolution1PokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokPresetEvolutionInfo_PokemonPresets_Evolution2PokemonGUID",
                        column: x => x.Evolution2PokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PokPresetEvolutionInfo_PokPresetAdditionalInfo_EvolutionInfoGUID",
                        column: x => x.EvolutionInfoGUID,
                        principalTable: "PokPresetAdditionalInfo",
                        principalColumn: "InfoGUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokPresetAbility_DataPokemonPokemonGUID",
                table: "PokPresetAbility",
                column: "DataPokemonPokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokPresetCapability_DataPokemonPokemonGUID",
                table: "PokPresetCapability",
                column: "DataPokemonPokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokPresetEdge_DataPokemonPokemonGUID",
                table: "PokPresetEdge",
                column: "DataPokemonPokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokPresetEvolutionInfo_Evolution0PokemonGUID",
                table: "PokPresetEvolutionInfo",
                column: "Evolution0PokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokPresetEvolutionInfo_Evolution1PokemonGUID",
                table: "PokPresetEvolutionInfo",
                column: "Evolution1PokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokPresetEvolutionInfo_Evolution2PokemonGUID",
                table: "PokPresetEvolutionInfo",
                column: "Evolution2PokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokPresetMove_DataPokemonPokemonGUID",
                table: "PokPresetMove",
                column: "DataPokemonPokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokPresetSkill_DataPokemonPokemonGUID",
                table: "PokPresetSkill",
                column: "DataPokemonPokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PokPresetStat_DataPokemonPokemonGUID",
                table: "PokPresetStat",
                column: "DataPokemonPokemonGUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataAbilities");

            migrationBuilder.DropTable(
                name: "DataCapabilities");

            migrationBuilder.DropTable(
                name: "DataEdges");

            migrationBuilder.DropTable(
                name: "DataMoves");

            migrationBuilder.DropTable(
                name: "PokPresetAbility");

            migrationBuilder.DropTable(
                name: "PokPresetCapability");

            migrationBuilder.DropTable(
                name: "PokPresetEdge");

            migrationBuilder.DropTable(
                name: "PokPresetEvolutionInfo");

            migrationBuilder.DropTable(
                name: "PokPresetMove");

            migrationBuilder.DropTable(
                name: "PokPresetSkill");

            migrationBuilder.DropTable(
                name: "PokPresetStat");

            migrationBuilder.DropTable(
                name: "PokPresetAdditionalInfo");

            migrationBuilder.DropTable(
                name: "PokemonPresets");
        }
    }
}
