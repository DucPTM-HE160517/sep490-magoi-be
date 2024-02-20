using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class Added_Session_DbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0028d2e6-2502-4567-8533-9b935c5c0a7f"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0479eb67-3c7b-42df-bb0b-9ec46fc160cc"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0e7a7e3d-4dac-4c2b-a67f-02e3be08b831"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0fb60b7c-e7d0-47a2-a120-d4ba5b47e7f7"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("1624794a-e759-493b-b896-8d5997ebfacb"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("3fa20d35-b649-4d6f-993d-227561ce08b1"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("4ca5b6f4-2ab8-498f-9e4a-43f10e0be773"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("5049c8a2-c907-4e95-8f9f-6412f4bf9c39"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("7740180b-5dfe-42e2-a9ea-8fd47d04f72e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("91fd3cf6-eb4e-4ee3-9093-5fc83c98354d"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("a2019937-caaa-4a8b-816d-a433bed1b497"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c39d30c5-f716-4a55-8be6-5f9f0437f895"));

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    ExpoToken = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.ExpoToken);
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[,]
                {
                    { new Guid("0df79f6f-8261-406e-abce-f74b79851750"), "Bàn 3", 2 },
                    { new Guid("1eaa0dcb-c1eb-4dc1-abdd-82393fce875e"), "Bàn 10", 3 },
                    { new Guid("21c95749-9a82-402b-865b-35c595d5bb18"), "Bàn 8", 1 },
                    { new Guid("4c26dd96-dcc3-48db-9ad2-813d98331013"), "Bàn 6", 1 },
                    { new Guid("8c611345-7eb4-4fa1-b067-af5bcffec647"), "Bàn 5", 2 },
                    { new Guid("910cd7f3-394d-41d2-a084-fc7f2d5e8a7e"), "Bàn 9", 1 },
                    { new Guid("b35194f1-3795-49a2-b68b-4c674c31cd16"), "Bàn 7", 1 },
                    { new Guid("b451465f-6983-4103-a931-bf9baf6194d4"), "Bàn 4", 2 },
                    { new Guid("d25603d9-9ce9-4f16-8152-c37ac3ce5aa3"), "Bàn 12", 3 },
                    { new Guid("d573d186-c0f2-44ae-8731-206678518f50"), "Bàn 1", 2 },
                    { new Guid("e68e913d-29de-4264-92a7-4cf4230eb925"), "Bàn 2", 2 },
                    { new Guid("f2338aad-59cf-4a3e-a583-8b9e147d36c5"), "Bàn 11", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0df79f6f-8261-406e-abce-f74b79851750"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("1eaa0dcb-c1eb-4dc1-abdd-82393fce875e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("21c95749-9a82-402b-865b-35c595d5bb18"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("4c26dd96-dcc3-48db-9ad2-813d98331013"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8c611345-7eb4-4fa1-b067-af5bcffec647"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("910cd7f3-394d-41d2-a084-fc7f2d5e8a7e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("b35194f1-3795-49a2-b68b-4c674c31cd16"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("b451465f-6983-4103-a931-bf9baf6194d4"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("d25603d9-9ce9-4f16-8152-c37ac3ce5aa3"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("d573d186-c0f2-44ae-8731-206678518f50"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("e68e913d-29de-4264-92a7-4cf4230eb925"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("f2338aad-59cf-4a3e-a583-8b9e147d36c5"));

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[,]
                {
                    { new Guid("0028d2e6-2502-4567-8533-9b935c5c0a7f"), "Bàn 6", 1 },
                    { new Guid("0479eb67-3c7b-42df-bb0b-9ec46fc160cc"), "Bàn 5", 2 },
                    { new Guid("0e7a7e3d-4dac-4c2b-a67f-02e3be08b831"), "Bàn 1", 2 },
                    { new Guid("0fb60b7c-e7d0-47a2-a120-d4ba5b47e7f7"), "Bàn 8", 1 },
                    { new Guid("1624794a-e759-493b-b896-8d5997ebfacb"), "Bàn 2", 2 },
                    { new Guid("3fa20d35-b649-4d6f-993d-227561ce08b1"), "Bàn 12", 3 },
                    { new Guid("4ca5b6f4-2ab8-498f-9e4a-43f10e0be773"), "Bàn 9", 1 },
                    { new Guid("5049c8a2-c907-4e95-8f9f-6412f4bf9c39"), "Bàn 11", 3 },
                    { new Guid("7740180b-5dfe-42e2-a9ea-8fd47d04f72e"), "Bàn 7", 1 },
                    { new Guid("91fd3cf6-eb4e-4ee3-9093-5fc83c98354d"), "Bàn 3", 2 },
                    { new Guid("a2019937-caaa-4a8b-816d-a433bed1b497"), "Bàn 4", 2 },
                    { new Guid("c39d30c5-f716-4a55-8be6-5f9f0437f895"), "Bàn 10", 3 }
                });
        }
    }
}
