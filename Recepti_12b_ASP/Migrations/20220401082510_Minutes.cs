using Microsoft.EntityFrameworkCore.Migrations;

namespace Recepti_12b_ASP.Migrations
{
    public partial class Minutes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CookMinutes",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrepareMinutes",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CookMinutes",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "PrepareMinutes",
                table: "Recipes");
        }
    }
}
