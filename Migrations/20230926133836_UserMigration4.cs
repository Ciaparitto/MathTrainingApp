using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathTrainingApp.Migrations
{
    public partial class UserMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
           name: "BadAnswers",
           table: "AspNetUsers",
           nullable: false,
           defaultValue: 0);
            migrationBuilder.AddColumn<int>(
           name: "AllAnswers",
           table: "AspNetUsers",
           nullable: false,
           defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
