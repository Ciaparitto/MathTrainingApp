﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathTrainingApp.Migrations
{
    public partial class UserMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
            name: "GoodAnswers",
            table: "AspNetUsers",
            nullable: true,
            defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
