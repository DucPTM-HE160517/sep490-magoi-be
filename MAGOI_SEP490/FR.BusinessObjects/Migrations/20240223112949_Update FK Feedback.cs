using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFKFeedback : Migration
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
                name: "FeedbackId",
                table: "Orders");

            migrationBuilder.AddColumn<Guid>(
                name: "BillId",
                table: "Feedbacks",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FeedbackId",
                table: "Bills",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                    { new Guid("12e270df-af72-4fd5-ac0f-37e13ac1f0f0"), "Bàn 11", 3 },
                    { new Guid("15cce42a-3eec-4bb3-9b60-9805aa39f15f"), "Bàn 3", 2 },
                    { new Guid("33f0c41c-daf6-400c-96c4-b69b67007c82"), "Bàn 10", 3 },
                    { new Guid("39c94dd7-ae08-4c76-acb7-d173a9555154"), "Bàn 4", 2 },
                    { new Guid("3d88d676-4e50-49a0-a84c-91f78fcce9b1"), "Bàn 1", 2 },
                    { new Guid("9f8507b9-449b-484a-84bd-5c9d7af0fdfc"), "Bàn 7", 1 },
                    { new Guid("be639779-30b6-401b-bb67-f70f7b82af4e"), "Bàn 5", 2 },
                    { new Guid("ca8b6dc9-3ee6-4174-975d-bcfd6b7bf0cd"), "Bàn 2", 2 },
                    { new Guid("d09397ae-ba85-4b0c-9a17-a0a632930517"), "Bàn 12", 3 },
                    { new Guid("d7d6fb30-c4e6-48dd-89d4-4bad38e9ded9"), "Bàn 6", 1 },
                    { new Guid("db38db78-0f8a-45b8-9c27-1cf74439aa71"), "Bàn 8", 1 },
                    { new Guid("dd965446-ef34-4e68-a1ae-aee84c60f6c8"), "Bàn 9", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentStatuses");

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("12e270df-af72-4fd5-ac0f-37e13ac1f0f0"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("15cce42a-3eec-4bb3-9b60-9805aa39f15f"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("33f0c41c-daf6-400c-96c4-b69b67007c82"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("39c94dd7-ae08-4c76-acb7-d173a9555154"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("3d88d676-4e50-49a0-a84c-91f78fcce9b1"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("9f8507b9-449b-484a-84bd-5c9d7af0fdfc"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("be639779-30b6-401b-bb67-f70f7b82af4e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("ca8b6dc9-3ee6-4174-975d-bcfd6b7bf0cd"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("d09397ae-ba85-4b0c-9a17-a0a632930517"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("d7d6fb30-c4e6-48dd-89d4-4bad38e9ded9"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("db38db78-0f8a-45b8-9c27-1cf74439aa71"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("dd965446-ef34-4e68-a1ae-aee84c60f6c8"));

            migrationBuilder.DropColumn(
                name: "BillId",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "FeedbackId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "PaymentStatusId",
                table: "Bills");

            migrationBuilder.AddColumn<Guid>(
                name: "FeedbackId",
                table: "Orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
