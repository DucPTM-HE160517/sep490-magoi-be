using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class Init_DB : Migration
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
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FinishedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FeedbackId = table.Column<Guid>(type: "uuid", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "integer", nullable: false)
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
                    Comment = table.Column<string>(type: "text", nullable: false),
                    BillId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    FoodOrderStatusId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    UnitPrice = table.Column<float>(type: "real", nullable: false),
                    FoodNote = table.Column<string>(type: "text", nullable: true),
                    OrderAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodOrder", x => new { x.OrderId, x.FoodId });
                });

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

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    UnitPrice = table.Column<float>(type: "real", nullable: false),
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
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Method = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

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
                table: "FoodOrderStatus",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Uncooked" },
                    { 2, "Cooking" },
                    { 3, "Cooked" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xúc xích cỡ lớn 300g với đồ muối chua", 1, "big-beerfest-bausages.jpg", "BIG BEERFEST SAUSAGES", 100, 199000f },
                    { 2, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xúc xích Đức nướng ăn kèm salad rau tổng hợp", 1, "grilled-german-gausages.jpg", "GRILLED GERMAN SAUSAGES", 100, 136000f },
                    { 3, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh mì bơ tỏi", 1, "garlic-bread.jpg", "GARLIC BREAD", 100, 30000f },
                    { 4, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khoai tây chiên", 1, "french-fried.jpg", "FRENCH FRIED", 100, 50000f },
                    { 5, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cánh gà nướng BBQ ăn kèm Salad, khoai tây chiên (2 cánh)", 1, "chicken-wings.jpg", "CHICKEN WINGS", 100, 86000f },
                    { 6, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đĩa tổng hợp các loại khoai chiên", 1, "beer-batter-fries.jpg", "BEER BATTER FRIES", 100, 99000f },
                    { 7, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gan Ngỗng áp chảo cùng Mứt, sốt xoài và bánh mỳ Pháp nướng", 1, "pan-seared-foie-gras.jpg", "PAN SEARED FOIE-GRAS", 100, 196000f },
                    { 8, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quả ô-liu trộn cay 100gr", 1, "marinated-spicy-olives.jpg", "MARINATED SPICY OLIVES", 100, 86000f },
                    { 9, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lườn vịt xông khói với Mayonnaise mutat Dijon", 1, "smoked-duck.jpg", "SMOKED DUCK", 100, 155000f },
                    { 10, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bò tái kiểu Ý cùng rau rocket, phô mai bào", 1, "beef-carpaccio.jpg", "BEEF CARPACCIO", 100, 180000f },
                    { 11, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đùi lợn Tây Ban Nha Cebo cắt lát với dưa lưới và rau arugula", 1, "iberico-de-cebo.jpg", "IBERICO DE CEBO", 100, 436000f },
                    { 12, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patê thịt Vịt phục vụ cùng mứt hoa quả và bánh mỳ Pháp", 1, "french-duck-rillette.jpg", "FRENCH DUCK RILLETTE", 100, 136000f },
                    { 13, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cá hồi xông khói nhà làm với bánh mỳ Pháp nướng, kem phô mai và rau cải xoăn", 1, "housemade-smoked-salmon.jpg", "HOUSEMADE SMOKED SALMON", 100, 166000f },
                    { 14, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn lưng Wagyu MB4/5 250g", 2, "aus-rib-eye-mb4-5.jpg", "AUS RIB EYE MB4/5", 100, 1280000f },
                    { 15, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn Flank Wagyu MB7/8 250g", 2, "aus-rib-eye-mb7-8.jpg", "AUS RIB EYE MB7/8", 100, 660000f },
                    { 16, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thǎn \"Mắc Áo\" Wagyu MB3 250g", 2, "aus-hanging-tender-mb3.jpg", "AUS HANGING TENDER MB3", 100, 600000f },
                    { 17, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn lưng bò Mỹ Prime 500g", 2, "us-prime-rib-eye.jpg", "US PRIME RIB EYE", 100, 960000f },
                    { 18, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn Bò Angus chữ T Úc 700g", 2, "aus-black-angus-t-bone.jpg", "AUS BLACK ANGUS T-BONE", 100, 1160000f },
                    { 19, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn nội bò Mỹ 250g", 2, "us-tenderloin.jpg", "US TENDERLOIN", 100, 560000f },
                    { 20, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn lưng bò Mỹ 350g", 2, "us-rib-eye.jpg", "US RIB EYE", 100, 596000f },
                    { 21, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn ngoại bò Mỹ 350g", 2, "us-striploin.jpg", "US STRIPLOIN", 100, 386000f },
                    { 22, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn nội bò Canada 200g", 2, "canada-tenderloin.jpg", "CANADA TENDERLOIN", 100, 386000f },
                    { 23, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thăn lưng bò Úc 250g", 2, "aus-rib-eye.jpg", "AUS RIB EYE", 100, 246000f },
                    { 24, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khoai tây nghiền", 3, "mashed-potato.jpg", "MASHED POTATO", 100, 30000f },
                    { 25, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nấm xào", 3, "saute-mushroom.jpg", "SAUTÉ MUSHROOM", 100, 30000f },
                    { 26, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khoai tây bi đút lò", 3, "roasted-baby-potato.jpg", "ROASTED BABY POTATO", 100, 30000f },
                    { 27, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đùi cừu nướng 2kg với thảo mộc", 2, "roasted-lamb-leg-2kg.jpg", "ROASTED LAMB LEG 2KG", 50, 2600000f },
                    { 28, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sườn cừu Úc thượng hạng nướng với thảo mộc", 2, "herbs-crusted-aus-lamb-rack.jpg", "HERBS CRUSTED AUS LAMB RACK", 50, 580000f },
                    { 29, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đùi vịt nấu chậm ăn kèm với khoai Roti, rau củ đút lò và sốt Gravy", 2, "duck-confit.jpg", "DUCK CONFIT", 100, 246000f },
                    { 30, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sườn lợn nướng BBQ (1,1 kg) với salad và khoai tây chiên", 2, "grilled-pork-rib-bbq.jpg", "GRILLED PORK RIB BBQ", 100, 660000f },
                    { 31, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cá ngừ nướng với sốt mayonnaise", 2, "tuna-steak.jpg", "TUNA STEAK", 50, 166000f },
                    { 32, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cá hồi áp chảo cùng cà rốt bào, cà rốt nghiền ăn với các lựa chọn sốt Cam Cà rốt, Kem Mù tạt", 2, "seared-salmon-fillet.jpg", "SEARED SALMON FILLET", 50, 226000f },
                    { 33, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad cá hồi xông khói, xà lách, cải mầm, rau rocket, bánh mỳ giòn, sốt dầu dấm", 4, "smoked-salmon-salad.jpg", "SMOKED SALMON SALAD", 100, 166000f },
                    { 34, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sa Lát rau xanh tổng hợp với lựa chọn các sốt dấm Balsamic, sốt chanh leo, sốt Thousand Island", 4, "mix-green-salad.jpg", "MIX GREEN SALAD", 100, 66000f },
                    { 35, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad trái cây với hạt Chia và các lựa chọn sốt sữa chua chanh leo, sốt Thousand Island", 4, "tropical-fruit-salad.jpg", "TROPICAL FRUIT SALAD", 100, 80000f },
                    { 36, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lườn vịt xông khói xà lách, rau rocket, hoa quả, cam và sốt dầm Ý", 4, "orange-salad-with-smoke-duck.jpg", "ORANGE SALAD WITH SMOKE DUCK", 100, 106000f },
                    { 37, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad Wakame với dưa chuột bào, rong nho biển, trứng cua sốt mè", 4, "ocean-seaweed-salad.jpg", "OCEAN SEAWEED SALAD", 100, 98000f },
                    { 38, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad ăn kèm trứng cút, ba rọi xông khói, phô mai bào, bánh mỳ giòn và sốt Caesar", 4, "caesar-salad.jpg", "CAESAR SALAD", 100, 86000f },
                    { 39, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad cá ngừ tươi cùng với khoai tây bi, trứng cút, đậu Pháp, củ cải đỏ, cà chua sấy và sốt dầu dấm", 4, "nicoise-salad.jpg", "NICOISE SALAD", 100, 126000f },
                    { 40, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Súp nấm kem", 5, "creamy-mushroom-soup.jpg", "CREAMY MUSHROOM SOUP", 100, 80000f },
                    { 41, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Súp kem bí đỏ kèm hạt bí nướng giòn, kem chua", 5, "creamy-pumpkin-soup.jpg", "CREAMY PUMPKIN SOUP", 100, 60000f },
                    { 42, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt vang đỏ", 6, "red-wine-sauce.jpg", "RED WINE SAUCE", 100, 25000f },
                    { 43, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt tiêu", 6, "pepper-sauce.jpg", "PEPPER SAUCE", 100, 25000f },
                    { 44, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt nấm", 6, "mushroom-sauce.jpg", "MUSHROOM SAUCE", 100, 25000f },
                    { 45, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt bơ tỏi", 6, "garlic-butter-sauce.jpg", "GARLIC BUTTER SAUCE", 100, 25000f },
                    { 46, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt mù tạt", 6, "mustard-sauce.jpg", "MUSTARD SAUCE", 100, 25000f },
                    { 47, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt BBQ", 6, "bbq-sauce.jpg", "BBQ SAUCE", 100, 25000f },
                    { 48, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sốt phô mai xanh", 6, "creamy-blue-cheese-sauce.jpg", "CREAMY BLUE CHEESE SAUCE", 100, 25000f },
                    { 49, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sót Teriyaki", 6, "teriyaki-sauce.jpg", "TERIYAKI SAUCE", 100, 25000f },
                    { 50, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coca Cola", 7, "coca-cola.jpg", "COCA COLA", 100, 30000f },
                    { 51, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nước suối", 7, "tapid-water.jpg", "TAPID WATER", 100, 20000f },
                    { 52, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinh tố dưa hấu", 7, "sinh-to-dua-hau.jpg", "SINH TỐ DƯA HẤU", 100, 50000f },
                    { 53, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta", 7, "fanta.jpg", "FANTA", 100, 30000f },
                    { 54, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sprite", 7, "sprite.jpg", "SPRITE", 100, 30000f },
                    { 55, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vang đỏ Barolo", 7, "barola.jpg", "BAROLA", 20, 1200000f },
                    { 56, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vang đỏ Chateau Leoville Poyferre", 7, "chateau-leoville-poyferre.jpg", "CHATEAU LEOVILLE POYFERRE", 20, 1400000f },
                    { 57, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vang đỏ Malbec", 7, "malbec.jpg", "MALBEC", 20, 1700000f },
                    { 58, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kem cháy gừng cùng với bánh quy giòn", 8, "ginger-cream-brulee.jpg", "GINGER CREAM BRULEE", 100, 46000f },
                    { 59, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh chocolate nướng chảy, kem vanilla và dừa sấy", 8, "warm-chocolate-lava-cake.jpg", "WARM CHOCOLATE LAVA CAKE", 100, 50000f },
                    { 60, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đĩa trái cây theo mùa", 8, "seasonal-fresh-fruit-plater.jpg", "SEASONAL FRESH FRUIT PLATER", 100, 135000f },
                    { 61, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh kem Ý hương lá nếp cùng chocolate nướng giòn và kem đánh bông", 8, "pandan-panna-cotta.jpg", "PANDAN PANNA-COTTA", 100, 35000f },
                    { 62, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kem Haagen Dazs, chocolate, vanilla, red berries, macha, Maccadmia nut", 8, "ice-cream-haagen-dazs.jpg", "ICE CREAM HAAGEN DAZS", 100, 88000f }
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
                    { 1, "Waiting" },
                    { 2, "In progress" },
                    { 3, "Served" },
                    { 4, "Finished" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Method" },
                values: new object[,]
                {
                    { 1, "Cash" },
                    { 2, "Banking" },
                    { 3, "CreditCard" }
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
                    { new Guid("00d6469a-ec3c-4e59-ad00-b2ddb9e34021"), "Bàn 8", 1 },
                    { new Guid("24421c43-7ce9-49f9-b279-545130db8777"), "Bàn 2", 2 },
                    { new Guid("42faf975-c839-4282-a42c-4df9963c3d4c"), "Bàn 9", 1 },
                    { new Guid("464d6381-2f42-4d17-9402-b4fb1728623e"), "Bàn 6", 1 },
                    { new Guid("72d44212-da44-4735-9846-af8e859c2086"), "Bàn 3", 2 },
                    { new Guid("79709257-f504-4186-aea9-d87a316ff42e"), "Bàn 7", 1 },
                    { new Guid("9e4241f8-ad17-48c4-8f49-9bb8607285c4"), "Bàn 12", 3 },
                    { new Guid("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb"), "Bàn 1", 2 },
                    { new Guid("a6c5a1d6-1942-48fc-9eca-1b5e9499ba6d"), "Bàn 4", 2 },
                    { new Guid("b9da28be-79af-4258-8cd7-c608c5fa2d8c"), "Bàn 5", 2 },
                    { new Guid("cca0bf6c-af6e-4c37-8636-db7a562bb57e"), "Bàn 11", 3 },
                    { new Guid("f63c6d7a-7d37-4a06-a80c-a311424eac59"), "Bàn 10", 3 }
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
                name: "FoodOrderStatus");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "TableStatus");
        }
    }
}
