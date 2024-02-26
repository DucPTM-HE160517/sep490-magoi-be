using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class Remove_PaymentStatus_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentStatuses");

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
                name: "PaymentStatusId",
                table: "Bills");

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[,]
                {
                    { new Guid("1021df0d-627e-494b-8c70-b109b15fb375"), "Bàn 6", 1 },
                    { new Guid("1bc47b16-6f65-4d4d-a4e1-5df20b899ea7"), "Bàn 12", 3 },
                    { new Guid("1c5f6393-419e-4fc1-a20d-2c7d6f0bb067"), "Bàn 5", 2 },
                    { new Guid("36d17cbf-87d0-4c3c-a38e-69773f2b2e6a"), "Bàn 11", 3 },
                    { new Guid("4ccdaa01-decd-41fe-a798-1126d7f01c7f"), "Bàn 3", 2 },
                    { new Guid("4fd6ffaa-d2de-42b5-95fb-a4fc382e5eba"), "Bàn 10", 3 },
                    { new Guid("6b42018b-54ef-4e1f-84df-ab3fb0f78521"), "Bàn 2", 2 },
                    { new Guid("9f28c3c9-4bab-4584-9697-b51ef066106b"), "Bàn 1", 2 },
                    { new Guid("a1d2a590-5236-459c-8904-a824342b4fca"), "Bàn 4", 2 },
                    { new Guid("eb4b56a5-dff1-46ba-8961-cdb1b47e3fc3"), "Bàn 7", 1 },
                    { new Guid("fa38f24f-ad19-4b3e-89bc-3eccce09f52e"), "Bàn 9", 1 },
                    { new Guid("fea7e273-e765-4db5-bed3-c796ce8c3c2e"), "Bàn 8", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("1021df0d-627e-494b-8c70-b109b15fb375"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("1bc47b16-6f65-4d4d-a4e1-5df20b899ea7"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("1c5f6393-419e-4fc1-a20d-2c7d6f0bb067"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("36d17cbf-87d0-4c3c-a38e-69773f2b2e6a"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("4ccdaa01-decd-41fe-a798-1126d7f01c7f"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("4fd6ffaa-d2de-42b5-95fb-a4fc382e5eba"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("6b42018b-54ef-4e1f-84df-ab3fb0f78521"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("9f28c3c9-4bab-4584-9697-b51ef066106b"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("a1d2a590-5236-459c-8904-a824342b4fca"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("eb4b56a5-dff1-46ba-8961-cdb1b47e3fc3"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("fa38f24f-ad19-4b3e-89bc-3eccce09f52e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("fea7e273-e765-4db5-bed3-c796ce8c3c2e"));

            migrationBuilder.AddColumn<int>(
                name: "PaymentStatusId",
                table: "Bills",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PaymentStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatuses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PaymentStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Unpaid" },
                    { 2, "Paid" }
                });

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
    }
}
