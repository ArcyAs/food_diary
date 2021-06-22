using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDiary.Data.Migrations
{
    public partial class doubleWeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("0405c093-3d76-4b90-ac9c-1ba591034b3c"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("32388af9-962f-4881-b668-a3f0a61bdc59"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("5481db95-0bc3-4d56-b8d2-a4cab6d553da"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("6906f912-8eb2-4c0f-b5a9-08288222b61e"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("7063f9ef-26bc-43ca-acca-9b91d5ba1092"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("8b32f5a0-2c03-453f-85f1-dff55b68659b"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("9adf38d9-f81d-406e-b8b5-1647c8addfce"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("9bec2c59-f035-4c13-9755-93c95c58bfc7"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("9fecb131-1eff-4d06-9942-f1eb3ddf22fd"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("a95da58f-c682-42ac-adcd-3a37e1c21abf"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("ab830a76-934b-411c-97e3-2ea71126411b"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("b8889f37-b769-4a45-9e03-cb8652f563bb"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("ba4ad949-6c06-49f6-bb3d-f7b13c0106bc"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("cc0f13df-19a5-4d19-a5c7-1ca41b162c79"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("ccacce22-3460-4b11-9cac-fbe7093907cb"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("cced40b0-a01d-4378-a790-4fba64f41cec"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("d964a63f-cef3-485f-b123-183aef8f73e6"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("ef485af6-26c9-448a-b9c8-0ce71d60e141"));

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("94d898a7-ddd2-4c6e-a884-363b726e42c4"), 52, 10, 345, "Muesli (Almond)", 12, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("f1691dde-9bc9-4995-ab6d-b95827a27d8b"), 15, 1, 68, "Kiwifruit", 1, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("aed8e3b3-c2ff-43b5-a693-c8f7bb0fc259"), 14, 1, 93, "Beans", 7, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("461e776f-d257-4017-9ac6-4c1a214c4372"), 14, 1, 93, "Cannellini Beans", 7, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("f6317c54-00e6-4437-83cb-d6db2110a685"), 11, 1, 70, "Lentils", 4, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("0ca9e50c-6c05-4e9e-9bf2-cd38dbab7ab6"), 15, 0, 96, "Chickpeas", 8, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("f5ef116d-16a4-4d07-a2d5-9db065eb1eb1"), 16, 0, 89, "Kidney Beans", 5, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("4f3d3915-84e5-4f94-8448-160c677febbd"), 15, 1, 98, "Butter Beans", 7, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("5c45791c-2343-482b-82db-c4c5bbd43df1"), 12, 57, 666, "Tahini", 26, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("7735c43d-2410-467a-99f8-aad00ee32685"), 18, 51, 644, "Peanut Butter", 28, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("4afd69bd-aa0c-4a07-a3b3-de10abafbf8e"), 12, 50, 610, "Peanut Butter", 28, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("c27fec45-5380-4716-9bb2-c4ab0f65df81"), 17, 19, 262, "Hummus", 6, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("d5290c4f-4e51-4a41-9b3e-621ba6bd194f"), 16, 9, 166, "Hummus (Lite)", 5, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("1710f014-1cde-456d-8841-6faa3fb2aedd"), 5, 11, 149, "Hummus", 8, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("af442727-f0ea-4b25-9301-144a31d15ca7"), 0, 9, 144, "Firm Tofu", 16, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("cee3610a-3497-4a2c-b356-06fee97d5178"), 60, 10, 383, "Wholegrain Rolled Oats", 13, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("1d7437c4-bc1c-4e42-ba8e-999d6638b4b2"), 14, 0, 58, "Apple (Granny Smith)", 0, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("79304dca-aee7-4dbd-9615-ad9b6f6cc4f5"), 14, 0, 58, "Apple (Pink Lady)", 0, 100.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("0ca9e50c-6c05-4e9e-9bf2-cd38dbab7ab6"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("1710f014-1cde-456d-8841-6faa3fb2aedd"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("1d7437c4-bc1c-4e42-ba8e-999d6638b4b2"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("461e776f-d257-4017-9ac6-4c1a214c4372"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("4afd69bd-aa0c-4a07-a3b3-de10abafbf8e"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("4f3d3915-84e5-4f94-8448-160c677febbd"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("5c45791c-2343-482b-82db-c4c5bbd43df1"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("7735c43d-2410-467a-99f8-aad00ee32685"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("79304dca-aee7-4dbd-9615-ad9b6f6cc4f5"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("94d898a7-ddd2-4c6e-a884-363b726e42c4"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("aed8e3b3-c2ff-43b5-a693-c8f7bb0fc259"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("af442727-f0ea-4b25-9301-144a31d15ca7"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("c27fec45-5380-4716-9bb2-c4ab0f65df81"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("cee3610a-3497-4a2c-b356-06fee97d5178"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("d5290c4f-4e51-4a41-9b3e-621ba6bd194f"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("f1691dde-9bc9-4995-ab6d-b95827a27d8b"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("f5ef116d-16a4-4d07-a2d5-9db065eb1eb1"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("f6317c54-00e6-4437-83cb-d6db2110a685"));

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("d964a63f-cef3-485f-b123-183aef8f73e6"), 52, 10, 345, "Muesli (Almond)", 12, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("32388af9-962f-4881-b668-a3f0a61bdc59"), 15, 1, 68, "Kiwifruit", 1, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("ab830a76-934b-411c-97e3-2ea71126411b"), 14, 1, 93, "Beans", 7, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("ba4ad949-6c06-49f6-bb3d-f7b13c0106bc"), 14, 1, 93, "Cannellini Beans", 7, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("7063f9ef-26bc-43ca-acca-9b91d5ba1092"), 11, 1, 70, "Lentils", 4, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("0405c093-3d76-4b90-ac9c-1ba591034b3c"), 15, 0, 96, "Chickpeas", 8, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("ccacce22-3460-4b11-9cac-fbe7093907cb"), 16, 0, 89, "Kidney Beans", 5, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("cc0f13df-19a5-4d19-a5c7-1ca41b162c79"), 15, 1, 98, "Butter Beans", 7, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("9fecb131-1eff-4d06-9942-f1eb3ddf22fd"), 12, 57, 666, "Tahini", 26, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("b8889f37-b769-4a45-9e03-cb8652f563bb"), 18, 51, 644, "Peanut Butter", 28, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("cced40b0-a01d-4378-a790-4fba64f41cec"), 12, 50, 610, "Peanut Butter", 28, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("8b32f5a0-2c03-453f-85f1-dff55b68659b"), 17, 19, 262, "Hummus", 6, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("a95da58f-c682-42ac-adcd-3a37e1c21abf"), 16, 9, 166, "Hummus (Lite)", 5, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("ef485af6-26c9-448a-b9c8-0ce71d60e141"), 5, 11, 149, "Hummus", 8, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("5481db95-0bc3-4d56-b8d2-a4cab6d553da"), 0, 9, 144, "Firm Tofu", 16, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("9adf38d9-f81d-406e-b8b5-1647c8addfce"), 60, 10, 383, "Wholegrain Rolled Oats", 13, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("6906f912-8eb2-4c0f-b5a9-08288222b61e"), 14, 0, 58, "Apple (Granny Smith)", 0, 100.0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein", "Weight" },
                values: new object[] { new Guid("9bec2c59-f035-4c13-9755-93c95c58bfc7"), 14, 0, 58, "Apple (Pink Lady)", 0, 100.0 });
        }
    }
}
