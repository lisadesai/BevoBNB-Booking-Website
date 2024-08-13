using Microsoft.EntityFrameworkCore.Migrations;

namespace Team24_Final_Project.Migrations
{
    public partial class AddedOrderSubtotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "OrderSubtotal",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderSubtotal",
                table: "Orders");
        }
    }
}
