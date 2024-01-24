using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class InitDB_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FoodNote",
                table: "FoodOrder",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Id", "CreatedAt", "TotalAmount" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000000f },
                    { 2, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 563000f },
                    { 3, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 7020000f },
                    { 4, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9270000f },
                    { 5, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000000f }
                });

            migrationBuilder.InsertData(
                table: "FoodCharacteristics",
                columns: new[] { "CharacteristicId", "FoodId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 6, 1 },
                    { 20, 1 },
                    { 2, 2 },
                    { 6, 2 },
                    { 20, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 6, 4 },
                    { 20, 4 },
                    { 2, 5 },
                    { 5, 5 },
                    { 6, 5 },
                    { 26, 5 },
                    { 2, 6 }
                });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 50000f);

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 8, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quả ô-liu trộn cay 100gr", 1, "marinated-spicy-olives.jpg", "MARINATED SPICY OLIVES", 86000f, 100 },
                    { 9, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lườn vịt xông khói với Mayonnaise mutat Dijon", 1, "smoked-duck.jpg", "SMOKED DUCK", 155000f, 100 },
                    { 10, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bò tái kiểu Ý cùng rau rocket, phô mai bào", 1, "beef-carpaccio.jpg", "BEEF CARPACCIO", 180000f, 100 },
                    { 11, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đùi lợn Tây Ban Nha Cebo cắt lát với dưa lưới và rau arugula", 1, "iberico-de-cebo.jpg", "IBERICO DE CEBO", 436000f, 100 },
                    { 12, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patê thịt Vịt phục vụ cùng mứt hoa quả và bánh mỳ Pháp", 1, "french-duck-rillette.jpg", "FRENCH DUCK RILLETTE", 136000f, 100 },
                    { 13, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cá hồi xông khói nhà làm với bánh mỳ Pháp nướng, kem phô mai và rau cải xoăn", 1, "housemade-smoked-salmon.jpg", "HOUSEMADE SMOKED SALMON", 166000f, 100 },
                    { 14, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn lưng Wagyu MB4/5 250g", 2, "aus-rib-eye-mb4-5.jpg", "AUS RIB EYE MB4/5", 1280000f, 100 },
                    { 15, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn Flank Wagyu MB7/8 250g", 2, "aus-rib-eye-mb7-8.jpg", "AUS RIB EYE MB7/8", 660000f, 100 },
                    { 16, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thǎn \"Mắc Áo\" Wagyu MB3 250g", 2, "aus-hanging-tender-mb3.jpg", "AUS HANGING TENDER MB3", 600000f, 100 },
                    { 17, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn lưng bò Mỹ Prime 500g", 2, "us-prime-rib-eye.jpg", "US PRIME RIB EYE", 960000f, 100 },
                    { 18, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn Bò Angus chữ T Úc 700g", 2, "aus-black-angus-t-bone.jpg", "AUS BLACK ANGUS T-BONE", 1160000f, 100 },
                    { 19, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn nội bò Mỹ 250g", 2, "us-tenderloin.jpg", "US TENDERLOIN", 560000f, 100 },
                    { 20, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn lưng bò Mỹ 350g", 2, "us-rib-eye.jpg", "US RIB EYE", 596000f, 100 },
                    { 21, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn ngoại bò Mỹ 350g", 2, "us-striploin.jpg", "US STRIPLOIN", 386000f, 100 },
                    { 22, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn nội bò Canada 200g", 2, "canada-tenderloin.jpg", "CANADA TENDERLOIN", 386000f, 100 },
                    { 23, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn lưng bò Úc 250g", 2, "aus-rib-eye.jpg", "AUS RIB EYE", 246000f, 100 },
                    { 24, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khoai tây nghiền", 3, "mashed-potato.jpg", "MASHED POTATO", 30000f, 100 },
                    { 25, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nấm xào", 3, "saute-mushroom.jpg", "SAUTÉ MUSHROOM", 30000f, 100 },
                    { 26, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khoai tây bi đút lò", 3, "roasted-baby-potato.jpg", "ROASTED BABY POTATO", 30000f, 100 },
                    { 27, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đùi cừu nướng 2kg với thảo mộc", 2, "roasted-lamb-leg-2kg.jpg", "ROASTED LAMB LEG 2KG", 2600000f, 50 },
                    { 28, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sườn cừu Úc thượng hạng nướng với thảo mộc", 2, "herbs-crusted-aus-lamb-rack.jpg", "HERBS CRUSTED AUS LAMB RACK", 580000f, 50 },
                    { 29, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đùi vịt nấu chậm ăn kèm với khoai Roti, rau củ đút lò và sốt Gravy", 2, "duck-confit.jpg", "DUCK CONFIT", 246000f, 100 },
                    { 30, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sườn lợn nướng BBQ (1,1 kg) với salad và khoai tây chiên", 2, "grilled-pork-rib-bbq.jpg", "GRILLED PORK RIB BBQ", 660000f, 100 },
                    { 31, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cá ngừ nướng với sốt mayonnaise", 2, "tuna-steak.jpg", "TUNA STEAK", 166000f, 50 },
                    { 32, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cá hồi áp chảo cùng cà rốt bào, cà rốt nghiền ăn với các lựa chọn sốt Cam Cà rốt, Kem Mù tạt", 2, "seared-salmon-fillet.jpg", "SEARED SALMON FILLET", 226000f, 50 },
                    { 33, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad cá hồi xông khói, xà lách, cải mầm, rau rocket, bánh mỳ giòn, sốt dầu dấm", 4, "smoked-salmon-salad.jpg", "SMOKED SALMON SALAD", 166000f, 100 },
                    { 34, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sa Lát rau xanh tổng hợp với lựa chọn các sốt dấm Balsamic, sốt chanh leo, sốt Thousand Island", 4, "mix-green-salad.jpg", "MIX GREEN SALAD", 66000f, 100 },
                    { 35, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad trái cây với hạt Chia và các lựa chọn sốt sữa chua chanh leo, sốt Thousand Island", 4, "tropical-fruit-salad.jpg", "TROPICAL FRUIT SALAD", 80000f, 100 },
                    { 36, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lườn vịt xông khói xà lách, rau rocket, hoa quả, cam và sốt dầm Ý", 4, "orange-salad-with-smoke-duck.jpg", "ORANGE SALAD WITH SMOKE DUCK", 106000f, 100 },
                    { 37, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad Wakame với dưa chuột bào, rong nho biển, trứng cua sốt mè", 4, "ocean-seaweed-salad.jpg", "OCEAN SEAWEED SALAD", 98000f, 100 },
                    { 38, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad ăn kèm trứng cút, ba rọi xông khói, phô mai bào, bánh mỳ giòn và sốt Caesar", 4, "caesar-salad.jpg", "CAESAR SALAD", 86000f, 100 },
                    { 39, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad cá ngừ tươi cùng với khoai tây bi, trứng cút, đậu Pháp, củ cải đỏ, cà chua sấy và sốt dầu dấm", 4, "nicoise-salad.jpg", "NICOISE SALAD", 126000f, 100 },
                    { 40, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Súp nấm kem", 5, "creamy-mushroom-soup.jpg", "CREAMY MUSHROOM SOUP", 80000f, 100 },
                    { 41, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Súp kem bí đỏ kèm hạt bí nướng giòn, kem chua", 5, "creamy-pumpkin-soup.jpg", "CREAMY PUMPKIN SOUP", 60000f, 100 },
                    { 42, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt vang đỏ", 6, "red-wine-sauce.jpg", "RED WINE SAUCE", 25000f, 100 },
                    { 43, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt tiêu", 6, "pepper-sauce.jpg", "PEPPER SAUCE", 25000f, 100 },
                    { 44, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt nấm", 6, "mushroom-sauce.jpg", "MUSHROOM SAUCE", 25000f, 100 },
                    { 45, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt bơ tỏi", 6, "garlic-butter-sauce.jpg", "GARLIC BUTTER SAUCE", 25000f, 100 },
                    { 46, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt mù tạt", 6, "mustard-sauce.jpg", "MUSTARD SAUCE", 25000f, 100 },
                    { 47, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt BBQ", 6, "bbq-sauce.jpg", "BBQ SAUCE", 25000f, 100 },
                    { 48, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt phô mai xanh", 6, "creamy-blue-cheese-sauce.jpg", "CREAMY BLUE CHEESE SAUCE", 25000f, 100 },
                    { 49, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sót Teriyaki", 6, "teriyaki-sauce.jpg", "TERIYAKI SAUCE", 25000f, 100 },
                    { 50, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola", 7, "coca-cola.jpg", "COCA COLA", 30000f, 100 },
                    { 51, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nước suối", 7, "tapid-water.jpg", "TAPID WATER", 20000f, 100 },
                    { 52, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinh tố dưa hấu", 7, "sinh-to-dua-hau.jpg", "SINH TỐ DƯA HẤU", 50000f, 100 },
                    { 53, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta", 7, "fanta.jpg", "FANTA", 30000f, 100 },
                    { 54, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprite", 7, "sprite.jpg", "SPRITE", 30000f, 100 },
                    { 55, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vang đỏ Barolo", 7, "barola.jpg", "BAROLA", 1200000f, 20 },
                    { 56, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vang đỏ Chateau Leoville Poyferre", 7, "chateau-leoville-poyferre.jpg", "CHATEAU LEOVILLE POYFERRE", 1400000f, 20 },
                    { 57, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vang đỏ Malbec", 7, "malbec.jpg", "MALBEC", 1700000f, 20 },
                    { 58, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kem cháy gừng cùng với bánh quy giòn", 8, "ginger-cream-brulee.jpg", "GINGER CREAM BRULEE", 46000f, 100 },
                    { 59, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh chocolate nướng chảy, kem vanilla và dừa sấy", 8, "warm-chocolate-lava-cake.jpg", "WARM CHOCOLATE LAVA CAKE", 50000f, 100 },
                    { 60, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đĩa trái cây theo mùa", 8, "seasonal-fresh-fruit-plater.jpg", "SEASONAL FRESH FRUIT PLATER", 135000f, 100 },
                    { 61, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh kem Ý hương lá nếp cùng chocolate nướng giòn và kem đánh bông", 8, "pandan-panna-cotta.jpg", "PANDAN PANNA-COTTA", 35000f, 100 },
                    { 62, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kem Haagen Dazs, chocolate, vanilla, red berries, macha, Maccadmia nut", 8, "ice-cream-haagen-dazs.jpg", "ICE CREAM HAAGEN DAZS", 88000f, 100 },
                    { 63, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mỳ hải sản với sốt cà chua hoặc sốt kem cùng tỏi và pho mai bào", 9, "seafood-spaghetti.jpg", "SEAFOOD SPAGHETTI", 126000f, 40 },
                    { 64, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mỳ Ý sợi sốt bò băm cùng phô mai bào và rau thơm", 9, "spaghetti-bolognese.jpg", "SPAGHETTI BOLOGNESE", 80000f, 40 },
                    { 65, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mỳ Ý sợi thịt nguội, sốt kem trứng và phô mai bào", 9, "spaghetti-alla-carbonara.jpg", "SPAGHETTI ALLA CARBONARA", 116000f, 40 },
                    { 66, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mỳ Ý đút lò nhiều lớp cùng sốt bò bằm, phô mai và sốt cà chua", 9, "beef-lasagne.jpg", "BEEF LASAGNE", 116000f, 40 }
                });

            migrationBuilder.InsertData(
                table: "TableStatus",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Trống" },
                    { 2, "Đang phục vụ" },
                    { 3, "Đã đặt trước" }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[,]
                {
                    { 1, "Bàn 1", 2 },
                    { 2, "Bàn 2", 2 },
                    { 3, "Bàn 3", 2 },
                    { 4, "Bàn 4", 2 },
                    { 5, "Bàn 5", 2 },
                    { 6, "Bàn 6", 1 },
                    { 7, "Bàn 7", 1 },
                    { 8, "Bàn 8", 1 },
                    { 9, "Bàn 9", 1 },
                    { 10, "Bàn 10", 3 },
                    { 11, "Bàn 11", 3 },
                    { 12, "Bàn 12", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "FoodCharacteristics",
                keyColumns: new[] { "CharacteristicId", "FoodId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 62);

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

            migrationBuilder.DeleteData(
                table: "TableStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TableStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TableStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AlterColumn<string>(
                name: "FoodNote",
                table: "FoodOrder",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 50f);
        }
    }
}
