using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class Recreate_Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Foods");

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "Foods",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "FoodOrder",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "UnitPrice",
                value: 199000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "UnitPrice",
                value: 136000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "UnitPrice",
                value: 30000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "UnitPrice",
                value: 50000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "UnitPrice",
                value: 86000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "UnitPrice",
                value: 99000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "UnitPrice",
                value: 196000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "UnitPrice",
                value: 86000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "UnitPrice",
                value: 155000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "UnitPrice",
                value: 180000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "UnitPrice",
                value: 436000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "UnitPrice",
                value: 136000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "UnitPrice",
                value: 166000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "UnitPrice",
                value: 1280000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "UnitPrice",
                value: 660000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "UnitPrice",
                value: 600000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "UnitPrice",
                value: 960000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "UnitPrice",
                value: 1160000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "UnitPrice",
                value: 560000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "UnitPrice",
                value: 596000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "UnitPrice",
                value: 386000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "UnitPrice",
                value: 386000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "UnitPrice",
                value: 246000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "UnitPrice",
                value: 30000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "UnitPrice",
                value: 30000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "UnitPrice",
                value: 30000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "UnitPrice",
                value: 2600000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "UnitPrice",
                value: 580000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "UnitPrice",
                value: 246000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "UnitPrice",
                value: 660000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "UnitPrice",
                value: 166000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "UnitPrice",
                value: 226000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "UnitPrice",
                value: 166000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "UnitPrice",
                value: 66000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "UnitPrice",
                value: 80000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "UnitPrice",
                value: 106000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "UnitPrice",
                value: 98000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "UnitPrice",
                value: 86000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "UnitPrice",
                value: 126000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "UnitPrice",
                value: 80000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "UnitPrice",
                value: 60000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "UnitPrice",
                value: 25000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "UnitPrice",
                value: 25000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 44,
                column: "UnitPrice",
                value: 25000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 45,
                column: "UnitPrice",
                value: 25000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 46,
                column: "UnitPrice",
                value: 25000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 47,
                column: "UnitPrice",
                value: 25000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 48,
                column: "UnitPrice",
                value: 25000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 49,
                column: "UnitPrice",
                value: 25000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 50,
                column: "UnitPrice",
                value: 30000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 51,
                column: "UnitPrice",
                value: 20000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 52,
                column: "UnitPrice",
                value: 50000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 53,
                column: "UnitPrice",
                value: 30000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 54,
                column: "UnitPrice",
                value: 30000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 55,
                column: "UnitPrice",
                value: 1200000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 56,
                column: "UnitPrice",
                value: 1400000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 57,
                column: "UnitPrice",
                value: 1700000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 58,
                column: "UnitPrice",
                value: 46000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 59,
                column: "UnitPrice",
                value: 50000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 60,
                column: "UnitPrice",
                value: 135000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 61,
                column: "UnitPrice",
                value: 35000m);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 62,
                column: "UnitPrice",
                value: 88000m);

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "Waiting");

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "In progress");

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 3, "Served" },
                    { 4, "Finished" }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[,]
                {
                    { new Guid("2fb2cc6f-4a2f-46f1-9701-585d4fe081d3"), "Bàn 9", 1 },
                    { new Guid("363e7ff3-7126-4772-8756-afa4a9a4bd01"), "Bàn 7", 1 },
                    { new Guid("4beee0ac-18b6-4eec-b521-e2433044046b"), "Bàn 5", 2 },
                    { new Guid("560c8bd9-8359-4cd4-a785-a775681c422c"), "Bàn 12", 3 },
                    { new Guid("62cd3110-4c23-4805-a873-ca31e19165a8"), "Bàn 10", 3 },
                    { new Guid("9df75cff-bfd0-45df-b28b-78de1f827eef"), "Bàn 2", 2 },
                    { new Guid("a9e3e989-a36e-44c5-8e40-e9d24345ec66"), "Bàn 4", 2 },
                    { new Guid("afaaeee4-5d7c-4a37-8187-647af02d248b"), "Bàn 6", 1 },
                    { new Guid("b0844d6d-0b62-4289-839b-4e0d03ef33b2"), "Bàn 11", 3 },
                    { new Guid("dc1f9c91-c02e-49ca-b981-66f47e56a9c0"), "Bàn 1", 2 },
                    { new Guid("def84d11-da7c-412b-b8f6-4dfe132a12a2"), "Bàn 3", 2 },
                    { new Guid("f5aa4b91-331c-4610-a963-094fe2bcc7f5"), "Bàn 8", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("2fb2cc6f-4a2f-46f1-9701-585d4fe081d3"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("363e7ff3-7126-4772-8756-afa4a9a4bd01"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("4beee0ac-18b6-4eec-b521-e2433044046b"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("560c8bd9-8359-4cd4-a785-a775681c422c"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("62cd3110-4c23-4805-a873-ca31e19165a8"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("9df75cff-bfd0-45df-b28b-78de1f827eef"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("a9e3e989-a36e-44c5-8e40-e9d24345ec66"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("afaaeee4-5d7c-4a37-8187-647af02d248b"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("b0844d6d-0b62-4289-839b-4e0d03ef33b2"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("dc1f9c91-c02e-49ca-b981-66f47e56a9c0"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("def84d11-da7c-412b-b8f6-4dfe132a12a2"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("f5aa4b91-331c-4610-a963-094fe2bcc7f5"));

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "FoodOrder");

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Foods",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 199000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 136000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 50000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 86000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 99000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 196000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 86000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 155000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 180000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 436000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "Price",
                value: 136000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "Price",
                value: 166000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "Price",
                value: 1280000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "Price",
                value: 660000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "Price",
                value: 600000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "Price",
                value: 960000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "Price",
                value: 1160000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "Price",
                value: 560000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 596000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "Price",
                value: 386000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "Price",
                value: 386000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "Price",
                value: 246000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "Price",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "Price",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "Price",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "Price",
                value: 2600000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "Price",
                value: 580000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "Price",
                value: 246000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "Price",
                value: 660000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "Price",
                value: 166000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "Price",
                value: 226000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "Price",
                value: 166000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "Price",
                value: 66000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "Price",
                value: 80000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "Price",
                value: 106000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "Price",
                value: 98000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "Price",
                value: 86000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "Price",
                value: 126000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "Price",
                value: 80000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "Price",
                value: 60000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "Price",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "Price",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 44,
                column: "Price",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 45,
                column: "Price",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 46,
                column: "Price",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 47,
                column: "Price",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 48,
                column: "Price",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 49,
                column: "Price",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 50,
                column: "Price",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 51,
                column: "Price",
                value: 20000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 52,
                column: "Price",
                value: 50000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 53,
                column: "Price",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 54,
                column: "Price",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 55,
                column: "Price",
                value: 1200000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 56,
                column: "Price",
                value: 1400000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 57,
                column: "Price",
                value: 1700000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 58,
                column: "Price",
                value: 46000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 59,
                column: "Price",
                value: 50000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 60,
                column: "Price",
                value: 135000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 61,
                column: "Price",
                value: 35000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 62,
                column: "Price",
                value: 88000f);

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "In progress");

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "Finished");

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
    }
}
