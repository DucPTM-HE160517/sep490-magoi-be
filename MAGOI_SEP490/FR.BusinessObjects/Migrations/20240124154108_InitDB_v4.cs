using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class InitDB_v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "Id", "Characteristic" },
                values: new object[] { 29, "Trái cây" });

            migrationBuilder.InsertData(
                table: "FoodCharacteristics",
                columns: new[] { "CharacteristicId", "FoodId" },
                values: new object[,]
                {
                    { 27, 5 },
                    { 6, 6 },
                    { 20, 6 },
                    { 2, 7 },
                    { 7, 8 },
                    { 8, 8 },
                    { 29, 8 },
                    { 2, 9 },
                    { 7, 9 },
                    { 3, 10 },
                    { 21, 10 },
                    { 26, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 24, 13 },
                    { 23, 14 },
                    { 23, 15 },
                    { 23, 16 },
                    { 23, 17 },
                    { 23, 18 },
                    { 22, 19 },
                    { 22, 20 },
                    { 21, 21 },
                    { 21, 22 },
                    { 21, 23 },
                    { 1, 24 },
                    { 2, 24 },
                    { 8, 24 },
                    { 1, 25 },
                    { 8, 25 },
                    { 1, 26 },
                    { 8, 26 },
                    { 5, 27 },
                    { 25, 27 },
                    { 5, 28 },
                    { 25, 28 },
                    { 28, 29 },
                    { 5, 30 },
                    { 26, 30 },
                    { 5, 31 },
                    { 24, 31 },
                    { 5, 32 },
                    { 24, 32 },
                    { 24, 33 },
                    { 1, 34 },
                    { 8, 34 },
                    { 1, 35 },
                    { 8, 35 },
                    { 28, 36 },
                    { 1, 37 },
                    { 8, 37 },
                    { 8, 38 },
                    { 26, 38 },
                    { 1, 39 },
                    { 4, 40 },
                    { 4, 41 },
                    { 19, 42 },
                    { 19, 43 },
                    { 19, 44 },
                    { 19, 45 },
                    { 19, 46 },
                    { 19, 47 },
                    { 19, 48 },
                    { 19, 49 },
                    { 15, 50 },
                    { 15, 51 },
                    { 14, 52 },
                    { 15, 53 },
                    { 15, 54 },
                    { 18, 55 },
                    { 18, 56 },
                    { 18, 57 },
                    { 3, 58 },
                    { 12, 58 },
                    { 11, 59 },
                    { 1, 60 },
                    { 8, 60 },
                    { 29, 60 },
                    { 11, 61 },
                    { 12, 62 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 26, 11 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 24, 13 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 23, 14 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 23, 15 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 23, 16 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 23, 17 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 23, 18 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 22, 19 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 22, 20 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 21, 21 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 21, 22 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 21, 23 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 8, 24 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 8, 25 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 8, 26 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 5, 27 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 25, 27 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 5, 28 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 25, 28 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 28, 29 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 5, 30 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 26, 30 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 5, 31 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 24, 31 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 5, 32 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 24, 32 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 24, 33 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 1, 34 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 8, 34 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 1, 35 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 8, 35 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 28, 36 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 8, 37 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 8, 38 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 26, 38 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 1, 39 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 4, 40 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 4, 41 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 19, 42 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 19, 43 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 19, 44 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 19, 45 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 19, 46 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 19, 47 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 19, 48 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 19, 49 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 15, 50 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 15, 51 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 14, 52 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 15, 53 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 15, 54 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 18, 55 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 18, 56 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 18, 57 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 3, 58 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 12, 58 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 11, 59 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 1, 60 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 8, 60 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 29, 60 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 11, 61 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 12, 62 });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Category" },
                values: new object[] { 9, "Pasta" });

            migrationBuilder.InsertData(
                table: "FoodCharacteristics",
                columns: new[] { "CharacteristicId", "FoodId" },
                values: new object[] { 26, 5 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 63, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mỳ hải sản với sốt cà chua hoặc sốt kem cùng tỏi và pho mai bào", 9, "seafood-spaghetti.jpg", "SEAFOOD SPAGHETTI", 126000f, 40 },
                    { 64, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mỳ Ý sợi sốt bò băm cùng phô mai bào và rau thơm", 9, "spaghetti-bolognese.jpg", "SPAGHETTI BOLOGNESE", 80000f, 40 },
                    { 65, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mỳ Ý sợi thịt nguội, sốt kem trứng và phô mai bào", 9, "spaghetti-alla-carbonara.jpg", "SPAGHETTI ALLA CARBONARA", 116000f, 40 },
                    { 66, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mỳ Ý đút lò nhiều lớp cùng sốt bò bằm, phô mai và sốt cà chua", 9, "beef-lasagne.jpg", "BEEF LASAGNE", 116000f, 40 }
                });
        }
    }
}
