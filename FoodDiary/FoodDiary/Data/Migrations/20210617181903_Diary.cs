using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDiary.Data.Migrations
{
    public partial class Diary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Fat",
                table: "ProductEntities",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("6edfeb91-464c-4ea0-8d34-67b5d0061553"), 52, 10, 345, "Muesli (Almond)", 12 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("1661e023-6b96-4182-9148-a7836dc88b25"), 15, 1, 68, "Kiwifruit", 1 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("618d43f6-2175-4b0e-b174-6e9e1bc2bed5"), 14, 1, 93, "Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("a70e0d07-dad1-4399-87cd-44ca471f472f"), 14, 1, 93, "Cannellini Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("3f108c99-9853-47c1-bb39-31f0f0406f4e"), 11, 1, 70, "Lentils", 4 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("9d51d07e-f978-4a5c-bab4-e049a36cbadc"), 15, 0, 96, "Chickpeas", 8 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("fb8e0b2d-7c38-4294-a006-260177000d74"), 16, 0, 89, "Kidney Beans", 5 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("53545d7e-1394-4cb9-9530-52e19ec9dbda"), 15, 1, 98, "Butter Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("ee7b8375-e26a-4110-89ad-bb228ca9ada8"), 12, 57, 666, "Tahini", 26 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("f0c0c9e9-1cd8-4fb9-a592-6cc46a149284"), 18, 51, 644, "Peanut Butter", 28 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("4ad11665-7a29-435f-bac4-0c423a30c8d5"), 12, 50, 610, "Peanut Butter", 28 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("8b1e966a-2e89-4ec3-9542-022648bfcb76"), 17, 19, 262, "Hummus", 6 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("9d69b063-1bbd-451c-b1bf-216a5dbb9371"), 16, 9, 166, "Hummus (Lite)", 5 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("d8215978-c69b-4475-996a-8007d08fab84"), 5, 11, 149, "Hummus", 8 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("13101464-979e-487d-84bd-40da1954f7ca"), 0, 9, 144, "Firm Tofu", 16 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("ca082324-0993-4332-a889-94fbbdca652e"), 60, 10, 383, "Wholegrain Rolled Oats", 13 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("d25ff7f9-b554-486a-89bc-20cae82ce933"), 14, 0, 58, "Apple (Granny Smith)", 0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("d3a3305a-a845-4742-ab70-c16e6aafb1c7"), 14, 0, 58, "Apple (Pink Lady)", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("13101464-979e-487d-84bd-40da1954f7ca"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("1661e023-6b96-4182-9148-a7836dc88b25"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("3f108c99-9853-47c1-bb39-31f0f0406f4e"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("4ad11665-7a29-435f-bac4-0c423a30c8d5"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("53545d7e-1394-4cb9-9530-52e19ec9dbda"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("618d43f6-2175-4b0e-b174-6e9e1bc2bed5"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("6edfeb91-464c-4ea0-8d34-67b5d0061553"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("8b1e966a-2e89-4ec3-9542-022648bfcb76"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("9d51d07e-f978-4a5c-bab4-e049a36cbadc"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("9d69b063-1bbd-451c-b1bf-216a5dbb9371"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("a70e0d07-dad1-4399-87cd-44ca471f472f"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("ca082324-0993-4332-a889-94fbbdca652e"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("d25ff7f9-b554-486a-89bc-20cae82ce933"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("d3a3305a-a845-4742-ab70-c16e6aafb1c7"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("d8215978-c69b-4475-996a-8007d08fab84"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("ee7b8375-e26a-4110-89ad-bb228ca9ada8"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("f0c0c9e9-1cd8-4fb9-a592-6cc46a149284"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("fb8e0b2d-7c38-4294-a006-260177000d74"));

            migrationBuilder.AlterColumn<double>(
                name: "Fat",
                table: "ProductEntities",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
