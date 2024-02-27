using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class Add_UnitPrice_Field : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<float>(
                name: "UnitPrice",
                table: "Foods",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<float>(
                name: "UnitPrice",
                table: "FoodOrder",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddColumn<DateTime>(
                name: "FinishedAt",
                table: "Bills",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "UnitPrice",
                value: 199000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "UnitPrice",
                value: 136000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "UnitPrice",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "UnitPrice",
                value: 50000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "UnitPrice",
                value: 86000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "UnitPrice",
                value: 99000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "UnitPrice",
                value: 196000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "UnitPrice",
                value: 86000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "UnitPrice",
                value: 155000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "UnitPrice",
                value: 180000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "UnitPrice",
                value: 436000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "UnitPrice",
                value: 136000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "UnitPrice",
                value: 166000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "UnitPrice",
                value: 1280000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "UnitPrice",
                value: 660000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16,
                column: "UnitPrice",
                value: 600000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17,
                column: "UnitPrice",
                value: 960000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18,
                column: "UnitPrice",
                value: 1160000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19,
                column: "UnitPrice",
                value: 560000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20,
                column: "UnitPrice",
                value: 596000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21,
                column: "UnitPrice",
                value: 386000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22,
                column: "UnitPrice",
                value: 386000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23,
                column: "UnitPrice",
                value: 246000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24,
                column: "UnitPrice",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25,
                column: "UnitPrice",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26,
                column: "UnitPrice",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27,
                column: "UnitPrice",
                value: 2600000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28,
                column: "UnitPrice",
                value: 580000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29,
                column: "UnitPrice",
                value: 246000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30,
                column: "UnitPrice",
                value: 660000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31,
                column: "UnitPrice",
                value: 166000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32,
                column: "UnitPrice",
                value: 226000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33,
                column: "UnitPrice",
                value: 166000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34,
                column: "UnitPrice",
                value: 66000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35,
                column: "UnitPrice",
                value: 80000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36,
                column: "UnitPrice",
                value: 106000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37,
                column: "UnitPrice",
                value: 98000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38,
                column: "UnitPrice",
                value: 86000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39,
                column: "UnitPrice",
                value: 126000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40,
                column: "UnitPrice",
                value: 80000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41,
                column: "UnitPrice",
                value: 60000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42,
                column: "UnitPrice",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43,
                column: "UnitPrice",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 44,
                column: "UnitPrice",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 45,
                column: "UnitPrice",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 46,
                column: "UnitPrice",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 47,
                column: "UnitPrice",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 48,
                column: "UnitPrice",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 49,
                column: "UnitPrice",
                value: 25000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 50,
                column: "UnitPrice",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 51,
                column: "UnitPrice",
                value: 20000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 52,
                column: "UnitPrice",
                value: 50000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 53,
                column: "UnitPrice",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 54,
                column: "UnitPrice",
                value: 30000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 55,
                column: "UnitPrice",
                value: 1200000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 56,
                column: "UnitPrice",
                value: 1400000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 57,
                column: "UnitPrice",
                value: 1700000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 58,
                column: "UnitPrice",
                value: 46000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 59,
                column: "UnitPrice",
                value: 50000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 60,
                column: "UnitPrice",
                value: 135000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 61,
                column: "UnitPrice",
                value: 35000f);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 62,
                column: "UnitPrice",
                value: 88000f);

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[,]
                {
                    { new Guid("139cdcde-74fe-404d-bbbd-8b3ae469c253"), "Bàn 9", 1 },
                    { new Guid("203f2da9-6e50-459e-b4b9-7b691cd1dfbb"), "Bàn 10", 3 },
                    { new Guid("2812da51-8439-46ee-b2a8-28bf1e52d490"), "Bàn 2", 2 },
                    { new Guid("52560ff3-0b3f-4949-9650-031a7f4f6385"), "Bàn 4", 2 },
                    { new Guid("55804cff-98a7-464b-abf3-524cb189cb3c"), "Bàn 12", 3 },
                    { new Guid("6edbc5b6-0f43-45f2-acc1-a25d87d591f3"), "Bàn 6", 1 },
                    { new Guid("8ba82885-56c2-46a9-a3fc-7e3acd084b4f"), "Bàn 11", 3 },
                    { new Guid("bf0afa94-6029-4cf9-bab4-f8a80e00fc8a"), "Bàn 3", 2 },
                    { new Guid("e1512685-252a-434c-a278-3a273ef3e6ff"), "Bàn 1", 2 },
                    { new Guid("f903b44f-a032-4286-b116-836ff797d284"), "Bàn 5", 2 },
                    { new Guid("f922cb57-df11-4a71-a08c-a7d2e9db2190"), "Bàn 7", 1 },
                    { new Guid("fbf5921d-17d5-49e5-8c43-feef75c5a981"), "Bàn 8", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("139cdcde-74fe-404d-bbbd-8b3ae469c253"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("203f2da9-6e50-459e-b4b9-7b691cd1dfbb"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("2812da51-8439-46ee-b2a8-28bf1e52d490"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("52560ff3-0b3f-4949-9650-031a7f4f6385"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("55804cff-98a7-464b-abf3-524cb189cb3c"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("6edbc5b6-0f43-45f2-acc1-a25d87d591f3"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8ba82885-56c2-46a9-a3fc-7e3acd084b4f"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("bf0afa94-6029-4cf9-bab4-f8a80e00fc8a"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("e1512685-252a-434c-a278-3a273ef3e6ff"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("f903b44f-a032-4286-b116-836ff797d284"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("f922cb57-df11-4a71-a08c-a7d2e9db2190"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("fbf5921d-17d5-49e5-8c43-feef75c5a981"));

            migrationBuilder.DropColumn(
                name: "FinishedAt",
                table: "Bills");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Foods",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "FoodOrder",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

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
    }
}
