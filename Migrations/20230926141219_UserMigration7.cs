using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathTrainingApp.Migrations
{
    public partial class UserMigration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Exp",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Exp",
                table: "AspNetUsers");
        }
    }
}
