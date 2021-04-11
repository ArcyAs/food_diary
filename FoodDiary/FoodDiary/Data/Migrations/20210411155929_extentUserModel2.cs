using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDiary.Data.Migrations
{
    public partial class extentUserModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActivityLevel",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Bmi",
                table: "AspNetUsers",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Bmr",
                table: "AspNetUsers",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "AspNetUsers",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityLevel",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Bmi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Bmr",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "AspNetUsers");
        }
    }
}
