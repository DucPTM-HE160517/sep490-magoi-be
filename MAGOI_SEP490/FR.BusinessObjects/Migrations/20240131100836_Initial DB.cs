using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TotalAmount = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ServingScore = table.Column<int>(type: "integer", nullable: false),
                    FoodScore = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Category = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodLabels",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "integer", nullable: false),
                    LabelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodLabels", x => new { x.FoodId, x.LabelId });
                });

            migrationBuilder.CreateTable(
                name: "FoodOrder",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    FoodId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    FoodNote = table.Column<string>(type: "text", nullable: true),
                    OrderAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrder", x => new { x.OrderId, x.FoodId });
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FoodCategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    BillId = table.Column<Guid>(type: "uuid", nullable: false),
                    FeedbackId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderStatusId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    StatusId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableStatus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Category" },
                values: new object[,]
                {
                    { 1, "Món khai vị" },
                    { 2, "Món chính" },
                    { 3, "Đồ ăn kèm" },
                    { 4, "Salad" },
                    { 5, "Soup" },
                    { 6, "Nước sốt" },
                    { 7, "Đồ uống" },
                    { 8, "Món tráng miệng" }
                });

            migrationBuilder.InsertData(
                table: "FoodLabels",
                columns: new[] { "FoodId", "LabelId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 6 },
                    { 1, 20 },
                    { 2, 2 },
                    { 2, 6 },
                    { 2, 20 },
                    { 3, 2 },
                    { 4, 2 },
                    { 4, 6 },
                    { 4, 20 },
                    { 5, 2 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 27 },
                    { 6, 2 },
                    { 6, 6 },
                    { 6, 20 },
                    { 7, 2 },
                    { 8, 7 },
                    { 8, 8 },
                    { 8, 29 },
                    { 9, 2 },
                    { 9, 7 },
                    { 10, 3 },
                    { 10, 21 },
                    { 11, 26 },
                    { 12, 3 },
                    { 13, 3 },
                    { 13, 24 },
                    { 14, 23 },
                    { 15, 23 },
                    { 16, 23 },
                    { 17, 23 },
                    { 18, 23 },
                    { 19, 22 },
                    { 20, 22 },
                    { 21, 21 },
                    { 22, 21 },
                    { 23, 21 },
                    { 24, 1 },
                    { 24, 2 },
                    { 24, 8 },
                    { 25, 1 },
                    { 25, 8 },
                    { 26, 1 },
                    { 26, 8 },
                    { 27, 5 },
                    { 27, 25 },
                    { 28, 5 },
                    { 28, 25 },
                    { 29, 28 },
                    { 30, 5 },
                    { 30, 26 },
                    { 31, 5 },
                    { 31, 24 },
                    { 32, 5 },
                    { 32, 24 },
                    { 33, 24 },
                    { 34, 1 },
                    { 34, 8 },
                    { 35, 1 },
                    { 35, 8 },
                    { 36, 28 },
                    { 37, 1 },
                    { 37, 8 },
                    { 38, 8 },
                    { 38, 26 },
                    { 39, 1 },
                    { 40, 4 },
                    { 41, 4 },
                    { 42, 19 },
                    { 43, 19 },
                    { 44, 19 },
                    { 45, 19 },
                    { 46, 19 },
                    { 47, 19 },
                    { 48, 19 },
                    { 49, 19 },
                    { 50, 15 },
                    { 51, 15 },
                    { 52, 14 },
                    { 53, 15 },
                    { 54, 15 },
                    { 55, 18 },
                    { 56, 18 },
                    { 57, 18 },
                    { 58, 3 },
                    { 58, 12 },
                    { 59, 11 },
                    { 60, 1 },
                    { 60, 8 },
                    { 60, 29 },
                    { 61, 11 },
                    { 62, 12 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xúc xích cỡ lớn 300g với đồ muối chua", 1, "big-beerfest-bausages.jpg", "BIG BEERFEST SAUSAGES", 199000f, 100 },
                    { 2, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xúc xích Đức nướng ăn kèm salad rau tổng hợp", 1, "grilled-german-gausages.jpg", "GRILLED GERMAN SAUSAGES", 136000f, 100 },
                    { 3, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh mì bơ tỏi", 1, "garlic-bread.jpg", "GARLIC BREAD", 30000f, 100 },
                    { 4, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khoai tây chiên", 1, "french-fried.jpg", "FRENCH FRIED", 50000f, 100 },
                    { 5, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cánh gà nướng BBQ ăn kèm Salad, khoai tây chiên (2 cánh)", 1, "chicken-wings.jpg", "CHICKEN WINGS", 86000f, 100 },
                    { 6, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đĩa tổng hợp các loại khoai chiên", 1, "beer-batter-fries.jpg", "BEER BATTER FRIES", 99000f, 100 },
                    { 7, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gan Ngỗng áp chảo cùng Mứt, sốt xoài và bánh mỳ Pháp nướng", 1, "pan-seared-foie-gras.jpg", "PAN SEARED FOIE-GRAS", 196000f, 100 },
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
                    { 62, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kem Haagen Dazs, chocolate, vanilla, red berries, macha, Maccadmia nut", 8, "ice-cream-haagen-dazs.jpg", "ICE CREAM HAAGEN DAZS", 88000f, 100 }
                });

            migrationBuilder.InsertData(
                table: "Labels",
                columns: new[] { "Id", "Label" },
                values: new object[,]
                {
                    { 1, "Món chay" },
                    { 2, "Món nóng" },
                    { 3, "Món lạnh" },
                    { 4, "Món nước" },
                    { 5, "Món nướng" },
                    { 6, "Thức ăn nhanh" },
                    { 7, "Món cay" },
                    { 8, "Dành cho người ăn kiêng" },
                    { 9, "Dành cho người tập gym" },
                    { 10, "Dành cho dịp lễ" },
                    { 11, "Bánh" },
                    { 12, "Kem" },
                    { 13, "Nước ép" },
                    { 14, "Sinh tố" },
                    { 15, "Nước ngọt" },
                    { 16, "Trà" },
                    { 17, "Bia" },
                    { 18, "Rượu vang" },
                    { 19, "Nước chấm" },
                    { 20, "Món chiên rán" },
                    { 21, "Bò tiêu chuẩn" },
                    { 22, "Bò cao cấp" },
                    { 23, "Bò thượng hạng" },
                    { 24, "Hải sản" },
                    { 25, "Thịt cừu" },
                    { 26, "Thịt lợn" },
                    { 27, "Thịt gà" },
                    { 28, "Thịt vịt" },
                    { 29, "Trái cây" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "In progress" },
                    { 2, "Finished" }
                });

            migrationBuilder.InsertData(
                table: "TableStatus",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "Serving" },
                    { 3, "Booked" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "FoodLabels");

            migrationBuilder.DropTable(
                name: "FoodOrder");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "TableStatus");
        }
    }
}
