using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodDiary.Data.Migrations
{
    public partial class productWeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("01fd3fc8-66e1-4d4d-b3c6-b3375c69116a"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("12e31dc1-ffb4-4a06-aab9-402ba89ddb5d"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("1a62fe57-e5d3-4c34-a2a7-a5b22b8947b5"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("354d83a8-0eab-4038-88c0-c2cb80063b76"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("371b1e6f-1dac-46af-9757-1ddc4cc6d811"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("37f7631a-d3e1-4a0b-b25f-5c94a17d5470"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("4edf9a5f-aa25-4d6a-a349-7927602d691b"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("51e4cab8-194a-43aa-8ba0-6f5ade840569"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("6c23e458-0053-494a-901b-9c315b9e67de"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("7d571984-8e31-4b59-bb9a-32b701d9063a"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("9952553e-889e-4bc4-b0b6-a689b8dca4a5"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("9ceaaadb-bbbc-40a3-b8bc-c54dfa5d1e01"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("a4b5f688-fd68-4f06-9dcf-1a0ea3633630"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("af3363c6-fd4b-42da-b8df-f7b2aafd4ef2"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("b6cf197f-e6f3-47ad-8201-7208e0fb6166"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("d433524e-fa48-4159-8a56-789ecbc70633"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("e577c8cf-b1ab-4955-9abe-bbd728b8045f"));

            migrationBuilder.DeleteData(
                table: "ProductEntities",
                keyColumn: "Id",
                keyValue: new Guid("fb6dc119-0a9e-47a4-b38c-48d321cf88ba"));

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "ProductEntities",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "ProductEntities");

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("6c23e458-0053-494a-901b-9c315b9e67de"), 52, 10, 345, "Muesli (Almond)", 12 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("371b1e6f-1dac-46af-9757-1ddc4cc6d811"), 15, 1, 68, "Kiwifruit", 1 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("9ceaaadb-bbbc-40a3-b8bc-c54dfa5d1e01"), 14, 1, 93, "Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("354d83a8-0eab-4038-88c0-c2cb80063b76"), 14, 1, 93, "Cannellini Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("01fd3fc8-66e1-4d4d-b3c6-b3375c69116a"), 11, 1, 70, "Lentils", 4 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("12e31dc1-ffb4-4a06-aab9-402ba89ddb5d"), 15, 0, 96, "Chickpeas", 8 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("af3363c6-fd4b-42da-b8df-f7b2aafd4ef2"), 16, 0, 89, "Kidney Beans", 5 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("7d571984-8e31-4b59-bb9a-32b701d9063a"), 15, 1, 98, "Butter Beans", 7 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("e577c8cf-b1ab-4955-9abe-bbd728b8045f"), 12, 57, 666, "Tahini", 26 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("fb6dc119-0a9e-47a4-b38c-48d321cf88ba"), 18, 51, 644, "Peanut Butter", 28 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("a4b5f688-fd68-4f06-9dcf-1a0ea3633630"), 12, 50, 610, "Peanut Butter", 28 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("37f7631a-d3e1-4a0b-b25f-5c94a17d5470"), 17, 19, 262, "Hummus", 6 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("b6cf197f-e6f3-47ad-8201-7208e0fb6166"), 16, 9, 166, "Hummus (Lite)", 5 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("9952553e-889e-4bc4-b0b6-a689b8dca4a5"), 5, 11, 149, "Hummus", 8 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("51e4cab8-194a-43aa-8ba0-6f5ade840569"), 0, 9, 144, "Firm Tofu", 16 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("4edf9a5f-aa25-4d6a-a349-7927602d691b"), 60, 10, 383, "Wholegrain Rolled Oats", 13 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("d433524e-fa48-4159-8a56-789ecbc70633"), 14, 0, 58, "Apple (Granny Smith)", 0 });

            migrationBuilder.InsertData(
                table: "ProductEntities",
                columns: new[] { "Id", "Carb", "Fat", "Kcal", "ProductName", "Protein" },
                values: new object[] { new Guid("1a62fe57-e5d3-4c34-a2a7-a5b22b8947b5"), 14, 0, 58, "Apple (Pink Lady)", 0 });
        }
    }
}
