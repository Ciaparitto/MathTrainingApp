using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathTrainingApp.Migrations
{
    public partial class UserMigration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AllAnswers",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BadAnswers",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoodAnswers",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillLvl",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BadAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GoodAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SkillLvl",
                table: "AspNetUsers");
        }
    }
}
