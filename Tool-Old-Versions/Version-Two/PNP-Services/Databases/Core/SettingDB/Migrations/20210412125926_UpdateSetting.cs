using Microsoft.EntityFrameworkCore.Migrations;

namespace PNP_Services.Databases.Core.SettingDB.Migrations
{
    public partial class UpdateSetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SettingEnum",
                table: "Settings");

            migrationBuilder.AddColumn<string>(
                name: "SettingName",
                table: "Settings",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SettingName",
                table: "Settings");

            migrationBuilder.AddColumn<int>(
                name: "SettingEnum",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
