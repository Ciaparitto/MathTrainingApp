using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathTrainingApp.Migrations
{
    public partial class UserMigration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
            name: "BadAnswers",
            table: "AspNetUsers");

            migrationBuilder.DropColumn(
          name: "GoodAnswers",
          table: "AspNetUsers");

            migrationBuilder.DropColumn(
          name: "AllAnswers",
          table: "AspNetUsers");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
