using Microsoft.EntityFrameworkCore.Migrations;

namespace Panse.Migrations
{
    public partial class AddRePasswordsToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RePasswords",
                columns: table => new
                {
                    pass = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RePasswords", x => x.pass);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RePasswords");
        }
    }
}
