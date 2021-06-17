using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDiary.Data.Migrations
{
    public partial class UserExtend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("0a4b16c9-a845-4b4b-9c89-df16e5161397"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("1b473345-b880-439c-9901-fc0aa31762e2"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("1b5b4fc5-93d9-4fba-bb5d-2e7cbcd0d07d"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("1b94c01e-68cd-4691-8053-0b44978e3d5e"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("1dd111ac-803a-4c3b-a218-c1043f720167"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("2056a86e-253b-4534-b39f-0ce9318877d3"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("20603ca3-722f-40e3-aa7f-14a5c1c5cd16"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("44d920a0-bb20-4717-8da0-8102efb54d4f"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("5363c48b-e716-46fe-a757-4ec56edc30cd"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("5ee7f854-c876-4121-829f-108f818be6ed"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("822d2d52-eef5-49ea-8c97-a8c87863da0c"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("b0b2bd1e-f090-4ef2-b1b0-c8f097fa888d"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("b5bfadfd-e12a-4e48-9dfd-ff1f3ca3a0c9"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("bf311838-3ee4-452c-9fb4-9bb80c7bd131"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("e7cca7a9-b0d8-4ce8-b294-5ee14da3ac3f"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("e98e68c6-6e93-49e0-a112-b7c182502cb9"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("ec5f2a2e-f197-41da-8162-43b95e4ae8fa"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("fc5026a1-a6e8-402c-bae1-2b614b0a4e2e"));

            migrationBuilder.AddColumn<Guid>(
                name: "DiaryId",
                table: "UserDetailsEntities",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "DiaryEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    IdProduct = table.Column<Guid>(type: "TEXT", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    Kcal = table.Column<int>(type: "INTEGER", nullable: false),
                    AddDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryEntities", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaryEntities");

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

            migrationBuilder.DropColumn(
                name: "DiaryId",
                table: "UserDetailsEntities");

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("ec5f2a2e-f197-41da-8162-43b95e4ae8fa"), 52, 10, 345, "Muesli (Almond)", 12 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("1dd111ac-803a-4c3b-a218-c1043f720167"), 15, 1, 68, "Kiwifruit", 1 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("2056a86e-253b-4534-b39f-0ce9318877d3"), 14, 1, 93, "Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("44d920a0-bb20-4717-8da0-8102efb54d4f"), 14, 1, 93, "Cannellini Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("b0b2bd1e-f090-4ef2-b1b0-c8f097fa888d"), 11, 1, 70, "Lentils", 4 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("e7cca7a9-b0d8-4ce8-b294-5ee14da3ac3f"), 15, 0, 96, "Chickpeas", 8 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("822d2d52-eef5-49ea-8c97-a8c87863da0c"), 16, 0, 89, "Kidney Beans", 5 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("1b473345-b880-439c-9901-fc0aa31762e2"), 15, 1, 98, "Butter Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("5363c48b-e716-46fe-a757-4ec56edc30cd"), 12, 57, 666, "Tahini", 26 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("1b94c01e-68cd-4691-8053-0b44978e3d5e"), 18, 51, 644, "Peanut Butter", 28 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("e98e68c6-6e93-49e0-a112-b7c182502cb9"), 12, 50, 610, "Peanut Butter", 28 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("20603ca3-722f-40e3-aa7f-14a5c1c5cd16"), 17, 19, 262, "Hummus", 6 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("fc5026a1-a6e8-402c-bae1-2b614b0a4e2e"), 16, 9, 166, "Hummus (Lite)", 5 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("b5bfadfd-e12a-4e48-9dfd-ff1f3ca3a0c9"), 5, 11, 149, "Hummus", 8 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("5ee7f854-c876-4121-829f-108f818be6ed"), 0, 9, 144, "Firm Tofu", 16 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("0a4b16c9-a845-4b4b-9c89-df16e5161397"), 60, 10, 383, "Wholegrain Rolled Oats", 13 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("bf311838-3ee4-452c-9fb4-9bb80c7bd131"), 14, 0, 58, "Apple (Granny Smith)", 0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("1b5b4fc5-93d9-4fba-bb5d-2e7cbcd0d07d"), 14, 0, 58, "Apple (Pink Lady)", 0 });
        }
    }
}
