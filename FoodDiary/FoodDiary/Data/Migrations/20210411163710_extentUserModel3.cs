using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDiary.Data.Migrations
{
    public partial class extentUserModel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ActivityLevel",
                table: "AspNetUsers",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ActivityLevel",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");
        }
    }
}
