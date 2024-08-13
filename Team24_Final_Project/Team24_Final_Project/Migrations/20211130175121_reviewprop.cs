using Microsoft.EntityFrameworkCore.Migrations;

namespace Team24_Final_Project.Migrations
{
    public partial class reviewprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GuestRating",
                table: "Properties",
                newName: "AdminReview");

            migrationBuilder.AddColumn<bool>(
                name: "AcceptReject",
                table: "Reviews",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptReject",
                table: "Reviews");

            migrationBuilder.RenameColumn(
                name: "AdminReview",
                table: "Properties",
                newName: "GuestRating");
        }
    }
}
