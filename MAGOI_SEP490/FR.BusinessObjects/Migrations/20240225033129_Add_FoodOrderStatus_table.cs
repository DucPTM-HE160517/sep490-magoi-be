using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class Add_FoodOrderStatus_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "FoodOrderStatusId",
                table: "FoodOrder",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FoodOrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrderStatus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FoodOrderStatus",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Uncooked" },
                    { 2, "Cooking" },
                    { 3, "Cooked" }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[,]
                {
                    { new Guid("0793f977-131b-4629-86d6-65af116f4363"), "Bàn 1", 2 },
                    { new Guid("13b13f0a-1bd1-465c-82ca-10a72fdf0383"), "Bàn 12", 3 },
                    { new Guid("30aa2568-31b5-4e17-819c-04d852a8b90b"), "Bàn 2", 2 },
                    { new Guid("6d11e568-5b7c-4ce3-905b-b3361b710f8f"), "Bàn 6", 1 },
                    { new Guid("8010a4d7-f975-4bb3-bd4d-a64779da239b"), "Bàn 11", 3 },
                    { new Guid("8cf3bbe7-8eb5-45c5-8f3c-bc4603df2d75"), "Bàn 3", 2 },
                    { new Guid("b77a3f60-9eb6-49b5-a621-73c63d3784a4"), "Bàn 10", 3 },
                    { new Guid("c7147c36-c8eb-4ede-ac5e-ee66a9cce2a4"), "Bàn 7", 1 },
                    { new Guid("d5daecf5-98e0-4f43-9a98-cc3be66fee74"), "Bàn 5", 2 },
                    { new Guid("dcf92a4a-b891-4759-a628-da32469bcb34"), "Bàn 9", 1 },
                    { new Guid("e1fb4915-008e-4c09-93e2-af1020fd48f7"), "Bàn 4", 2 },
                    { new Guid("fba25d34-89bb-4527-b0ea-112f194c2f1f"), "Bàn 8", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodOrderStatus");

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0793f977-131b-4629-86d6-65af116f4363"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("13b13f0a-1bd1-465c-82ca-10a72fdf0383"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("30aa2568-31b5-4e17-819c-04d852a8b90b"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("6d11e568-5b7c-4ce3-905b-b3361b710f8f"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8010a4d7-f975-4bb3-bd4d-a64779da239b"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8cf3bbe7-8eb5-45c5-8f3c-bc4603df2d75"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("b77a3f60-9eb6-49b5-a621-73c63d3784a4"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c7147c36-c8eb-4ede-ac5e-ee66a9cce2a4"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("d5daecf5-98e0-4f43-9a98-cc3be66fee74"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("dcf92a4a-b891-4759-a628-da32469bcb34"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("e1fb4915-008e-4c09-93e2-af1020fd48f7"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("fba25d34-89bb-4527-b0ea-112f194c2f1f"));

            migrationBuilder.DropColumn(
                name: "FoodOrderStatusId",
                table: "FoodOrder");

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
    }
}
