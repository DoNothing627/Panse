using Microsoft.EntityFrameworkCore.Migrations;

namespace Panse.Migrations
{
    public partial class AddAmountColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Rings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Necklaces",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Rings");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Necklaces");
        }
    }
}
