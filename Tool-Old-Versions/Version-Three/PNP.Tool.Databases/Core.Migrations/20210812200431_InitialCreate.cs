using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PNP.Tool.Databases.Core.Migrations
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
                name: "SettingEntry",
                columns: table => new
                {
                    GUID = table.Column<Guid>(type: "TEXT", nullable: false),
                    SettingName = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingEntry", x => x.GUID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorieEntry");

            migrationBuilder.DropTable(
                name: "SettingEntry");
        }
    }
}
