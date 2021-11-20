using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PNP.Services.Service.Migrations
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
                name: "PresetAbility",
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
                    table.PrimaryKey("PK_PresetAbility", x => x.AbilityGUID);
                    table.ForeignKey(
                        name: "FK_PresetAbility_PokemonPresets_DataPokemonPokemonGUID",
                        column: x => x.DataPokemonPokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PresetAdditionalInfo",
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
                    table.PrimaryKey("PK_PresetAdditionalInfo", x => x.InfoGUID);
                    table.ForeignKey(
                        name: "FK_PresetAdditionalInfo_PokemonPresets_InfoGUID",
                        column: x => x.InfoGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PresetCapability",
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
                    table.PrimaryKey("PK_PresetCapability", x => x.CapabilityGUID);
                    table.ForeignKey(
                        name: "FK_PresetCapability_PokemonPresets_DataPokemonPokemonGUID",
                        column: x => x.DataPokemonPokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PresetEdge",
                columns: table => new
                {
                    EdgeGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataPokemonPokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresetEdge", x => x.EdgeGUID);
                    table.ForeignKey(
                        name: "FK_PresetEdge_PokemonPresets_DataPokemonPokemonGUID",
                        column: x => x.DataPokemonPokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PresetMove",
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
                    table.PrimaryKey("PK_PresetMove", x => x.MoveGUID);
                    table.ForeignKey(
                        name: "FK_PresetMove_PokemonPresets_DataPokemonPokemonGUID",
                        column: x => x.DataPokemonPokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PresetSkill",
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
                    table.PrimaryKey("PK_PresetSkill", x => x.SkillGUID);
                    table.ForeignKey(
                        name: "FK_PresetSkill_PokemonPresets_DataPokemonPokemonGUID",
                        column: x => x.DataPokemonPokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PresetStat",
                columns: table => new
                {
                    StatGUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataPokemonPokemonGUID = table.Column<Guid>(type: "TEXT", nullable: true),
                    StatType = table.Column<int>(type: "INTEGER", nullable: false),
                    StatValue = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresetStat", x => x.StatGUID);
                    table.ForeignKey(
                        name: "FK_PresetStat_PokemonPresets_DataPokemonPokemonGUID",
                        column: x => x.DataPokemonPokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PresetEvolutionInfo",
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
                    table.PrimaryKey("PK_PresetEvolutionInfo", x => x.EvolutionInfoGUID);
                    table.ForeignKey(
                        name: "FK_PresetEvolutionInfo_PokemonPresets_Evolution0PokemonGUID",
                        column: x => x.Evolution0PokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresetEvolutionInfo_PokemonPresets_Evolution1PokemonGUID",
                        column: x => x.Evolution1PokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresetEvolutionInfo_PokemonPresets_Evolution2PokemonGUID",
                        column: x => x.Evolution2PokemonGUID,
                        principalTable: "PokemonPresets",
                        principalColumn: "PokemonGUID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresetEvolutionInfo_PresetAdditionalInfo_EvolutionInfoGUID",
                        column: x => x.EvolutionInfoGUID,
                        principalTable: "PresetAdditionalInfo",
                        principalColumn: "InfoGUID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PresetAbility_DataPokemonPokemonGUID",
                table: "PresetAbility",
                column: "DataPokemonPokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PresetCapability_DataPokemonPokemonGUID",
                table: "PresetCapability",
                column: "DataPokemonPokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PresetEdge_DataPokemonPokemonGUID",
                table: "PresetEdge",
                column: "DataPokemonPokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PresetEvolutionInfo_Evolution0PokemonGUID",
                table: "PresetEvolutionInfo",
                column: "Evolution0PokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PresetEvolutionInfo_Evolution1PokemonGUID",
                table: "PresetEvolutionInfo",
                column: "Evolution1PokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PresetEvolutionInfo_Evolution2PokemonGUID",
                table: "PresetEvolutionInfo",
                column: "Evolution2PokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PresetMove_DataPokemonPokemonGUID",
                table: "PresetMove",
                column: "DataPokemonPokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PresetSkill_DataPokemonPokemonGUID",
                table: "PresetSkill",
                column: "DataPokemonPokemonGUID");

            migrationBuilder.CreateIndex(
                name: "IX_PresetStat_DataPokemonPokemonGUID",
                table: "PresetStat",
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
                name: "PresetAbility");

            migrationBuilder.DropTable(
                name: "PresetCapability");

            migrationBuilder.DropTable(
                name: "PresetEdge");

            migrationBuilder.DropTable(
                name: "PresetEvolutionInfo");

            migrationBuilder.DropTable(
                name: "PresetMove");

            migrationBuilder.DropTable(
                name: "PresetSkill");

            migrationBuilder.DropTable(
                name: "PresetStat");

            migrationBuilder.DropTable(
                name: "PresetAdditionalInfo");

            migrationBuilder.DropTable(
                name: "PokemonPresets");
        }
    }
}
