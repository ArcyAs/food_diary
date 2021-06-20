using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDiary.Data.Migrations
{
    public partial class diaryextand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("0b1ef0a3-1984-4cf1-82b0-a174a88f3786"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("12cf5520-3df5-4103-93c8-9d55be78ee73"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("263aea4b-4316-4f9c-a837-813908d5d954"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("32482016-a0ba-4da3-b7a8-7e806cd25b08"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("3c714377-d7b7-42b2-a90a-923596e4fc35"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("3d200e80-af26-412a-83e1-3d1ac5ce4f2d"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("50f360cc-5071-47fb-b971-858c04c1eeb9"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("5dd592e4-f37c-427d-8d6d-4a94fb4cbc12"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("75235a30-d559-4957-bf29-2071a4491e0f"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("8c617a09-a008-4fbc-a95d-76d756298cdf"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("9be8e82e-eef8-49d8-b77c-dff5288fda72"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("a0bb7f13-946c-433f-a891-063daadf7095"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("ae2fdcaf-72fa-43a6-a9f3-1149a346002f"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("c3e97641-9a0b-44bf-bd9e-eae5384bbb4f"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("caab22e0-22e8-4bf9-8562-f302d6569415"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("d8148c99-aee4-4960-87dd-79d0fd0384e0"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("eccfd536-b7b4-4bcb-a371-4393ec1b8e36"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("f8474ee0-fc0b-4f44-857a-6534a8030aca"));

            migrationBuilder.AddColumn<Guid>(
                name: "DiaryId",
                table: "DiaryEntities",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("223b95c7-ee79-4fda-8cee-6fc7225236d4"), 52, 10, 345, "Muesli (Almond)", 12 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("b35474b4-0e51-42c8-9d20-1cbdbf7c5c73"), 15, 1, 68, "Kiwifruit", 1 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("c90a778d-7bdf-4625-a6be-8e81b675352b"), 14, 1, 93, "Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("28fd734c-f091-418e-989f-c558026f800e"), 14, 1, 93, "Cannellini Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("fb94a646-1460-4944-959f-5647a2fd953d"), 11, 1, 70, "Lentils", 4 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("70818e23-2236-4660-9ca9-35d46825e3ed"), 15, 0, 96, "Chickpeas", 8 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("672b9cca-c2e1-4763-aee1-0778e2fa1688"), 16, 0, 89, "Kidney Beans", 5 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("4e51d9cf-6e67-41f8-ac4c-4433d5deeeb1"), 15, 1, 98, "Butter Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("fff819ac-ac63-4b47-924c-6220274ebf3a"), 12, 57, 666, "Tahini", 26 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("26253da1-4033-4574-9038-15982bf1807b"), 18, 51, 644, "Peanut Butter", 28 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("20d1b75e-94c7-4503-b21a-d7ccbee9384d"), 12, 50, 610, "Peanut Butter", 28 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("78f5788e-920c-4b97-a8cb-51425dc0e6cd"), 17, 19, 262, "Hummus", 6 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("8b070d24-3b5f-4069-9a89-e4d929e69188"), 16, 9, 166, "Hummus (Lite)", 5 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("916d4bc6-3982-40d5-abd6-7153568545bd"), 5, 11, 149, "Hummus", 8 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("6e0c0740-c809-4290-8ce8-20ca3612a7ca"), 0, 9, 144, "Firm Tofu", 16 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("4b8a5fa3-8c47-4edb-a5b3-fa6937254347"), 60, 10, 383, "Wholegrain Rolled Oats", 13 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("37f41d07-1cb4-4f69-9e37-b14d284a2cd2"), 14, 0, 58, "Apple (Granny Smith)", 0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("0b2fa161-654d-4805-b932-8f6bf4a1ea86"), 14, 0, 58, "Apple (Pink Lady)", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("0b2fa161-654d-4805-b932-8f6bf4a1ea86"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("20d1b75e-94c7-4503-b21a-d7ccbee9384d"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("223b95c7-ee79-4fda-8cee-6fc7225236d4"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("26253da1-4033-4574-9038-15982bf1807b"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("28fd734c-f091-418e-989f-c558026f800e"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("37f41d07-1cb4-4f69-9e37-b14d284a2cd2"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("4b8a5fa3-8c47-4edb-a5b3-fa6937254347"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("4e51d9cf-6e67-41f8-ac4c-4433d5deeeb1"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("672b9cca-c2e1-4763-aee1-0778e2fa1688"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("6e0c0740-c809-4290-8ce8-20ca3612a7ca"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("70818e23-2236-4660-9ca9-35d46825e3ed"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("78f5788e-920c-4b97-a8cb-51425dc0e6cd"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("8b070d24-3b5f-4069-9a89-e4d929e69188"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("916d4bc6-3982-40d5-abd6-7153568545bd"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("b35474b4-0e51-42c8-9d20-1cbdbf7c5c73"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("c90a778d-7bdf-4625-a6be-8e81b675352b"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("fb94a646-1460-4944-959f-5647a2fd953d"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("fff819ac-ac63-4b47-924c-6220274ebf3a"));

            migrationBuilder.DropColumn(
                name: "DiaryId",
                table: "DiaryEntities");

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("12cf5520-3df5-4103-93c8-9d55be78ee73"), 52, 10, 345, "Muesli (Almond)", 12 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("eccfd536-b7b4-4bcb-a371-4393ec1b8e36"), 15, 1, 68, "Kiwifruit", 1 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("8c617a09-a008-4fbc-a95d-76d756298cdf"), 14, 1, 93, "Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("5dd592e4-f37c-427d-8d6d-4a94fb4cbc12"), 14, 1, 93, "Cannellini Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("32482016-a0ba-4da3-b7a8-7e806cd25b08"), 11, 1, 70, "Lentils", 4 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("75235a30-d559-4957-bf29-2071a4491e0f"), 15, 0, 96, "Chickpeas", 8 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("c3e97641-9a0b-44bf-bd9e-eae5384bbb4f"), 16, 0, 89, "Kidney Beans", 5 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("50f360cc-5071-47fb-b971-858c04c1eeb9"), 15, 1, 98, "Butter Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("d8148c99-aee4-4960-87dd-79d0fd0384e0"), 12, 57, 666, "Tahini", 26 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("3d200e80-af26-412a-83e1-3d1ac5ce4f2d"), 18, 51, 644, "Peanut Butter", 28 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("caab22e0-22e8-4bf9-8562-f302d6569415"), 12, 50, 610, "Peanut Butter", 28 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("f8474ee0-fc0b-4f44-857a-6534a8030aca"), 17, 19, 262, "Hummus", 6 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("a0bb7f13-946c-433f-a891-063daadf7095"), 16, 9, 166, "Hummus (Lite)", 5 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("9be8e82e-eef8-49d8-b77c-dff5288fda72"), 5, 11, 149, "Hummus", 8 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("0b1ef0a3-1984-4cf1-82b0-a174a88f3786"), 0, 9, 144, "Firm Tofu", 16 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("3c714377-d7b7-42b2-a90a-923596e4fc35"), 60, 10, 383, "Wholegrain Rolled Oats", 13 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("ae2fdcaf-72fa-43a6-a9f3-1149a346002f"), 14, 0, 58, "Apple (Granny Smith)", 0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("263aea4b-4316-4f9c-a837-813908d5d954"), 14, 0, 58, "Apple (Pink Lady)", 0 });
        }
    }
}
