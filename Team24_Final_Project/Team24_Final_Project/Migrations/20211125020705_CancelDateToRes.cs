using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team24_Final_Project.Migrations
{
    public partial class CancelDateToRes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelByDate",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "CancelByDate",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelByDate",
                table: "Reservations");

            migrationBuilder.AddColumn<DateTime>(
                name: "CancelByDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
