using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PNP_Services.Databases.Core.HistoryDB.Migrations
{
    public partial class TimeStampAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EntryTime",
                table: "Entries",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EntryTime",
                table: "Entries");
        }
    }
}
