using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDiary.Data.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Target",
                table: "UserDetailsEntities",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Target",
                table: "UserDetailsEntities");
        }
    }
}
