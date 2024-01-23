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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TotalAmount = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Characteristic = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                name: "FoodCharacteristics",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "integer", nullable: false),
                    CharacteristicId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCharacteristics", x => new { x.FoodId, x.CharacteristicId });
                });

            migrationBuilder.CreateTable(
                name: "FoodOrder",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    FoodId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    FoodNote = table.Column<string>(type: "text", nullable: false),
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
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TableId = table.Column<int>(type: "integer", nullable: false),
                    BillId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FeedbackId = table.Column<int>(type: "integer", nullable: false),
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    { 1, "Lẩu Tom Yum" },
                    { 2, "Lẩu Tom Kha" },
                    { 3, "Lẩu Green Curry" },
                    { 4, "Lẩu Red Curry" },
                    { 6, "Lẩu Massaman" },
                    { 7, "Phở Bò" },
                    { 8, "Phở Gà" },
                    { 9, "Phở Chay" },
                    { 10, "Phở Sườn" },
                    { 11, "Salad" },
                    { 12, "Món Khai Vị" },
                    { 13, "Món Lạnh" },
                    { 14, "Steak" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm với hương vị đậm đà của nước lẩu Tom Yum.", 1, "tomyum_goong.jpg", "Tom Yum Goong", 250000f, 1 },
                    { 2, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu gà với hương vị đậm đà của nước lẩu Tom Yum.", 1, "tomyum_gai.jpg", "Tom Yum Gai", 320000f, 1 },
                    { 3, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu hải sản với hương vị đậm đà của nước lẩu Tom Yum.", 1, "tomyum_talay.jpg", "Tom Yum Talay", 180000f, 1 },
                    { 4, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm với hương vị đậm đà của nước lẩu Tom Kha và sữa cô cocon", 2, "tomkha_goong.jpg", "Tom Kha Goong", 160000f, 1 },
                    { 5, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu gà với hương vị đậm đà của nước lẩu Tom Kha và với sữa cô cocon", 2, "tomkha_gai.jpg", "Tom Kha Gai", 130000f, 1 },
                    { 6, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu hải sản với hương vị đậm đà của nước lẩu Tom Kha và sữa cô cocon", 2, "tomkha_talay.jpg", "Tom Kha Talay", 190000f, 1 },
                    { 7, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm xanh với hương vị đậm đà của nước lẩu Green Curry.", 3, "greencurry_goong.jpg", "Green Curry Goong", 170000f, 1 },
                    { 8, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu gà với hương vị đậm đà của nước lẩu Green Curry.", 3, "greencurry_gai.jpg", "Green Curry Gai", 140000f, 1 },
                    { 9, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu hải sản với hương vị đậm đà của nước lẩu Green Curry.", 3, "greencurry_talay.jpg", "Green Curry Talay", 200000f, 1 },
                    { 10, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm cay với hương vị đậm đà của nước lẩu Red Curry.", 4, "spicy_redcurry_goong.jpg", "Spicy Red Curry Goong", 200000f, 1 },
                    { 11, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu nấm với hương vị đậm đà của nước lẩu Red Curry.", 4, "redcurry_mushroom.jpg", "Red Curry Mushroom", 170000f, 1 },
                    { 12, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm cay với hương vị đậm đà của nước lẩu Massaman.", 6, "spicy_massaman_goong.jpg", "Spicy Massaman Curry Goong", 210000f, 1 },
                    { 13, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu gà với hương vị đậm đà của nước lẩu Massaman.", 6, "massaman_chicken.jpg", "Massaman Curry Chicken", 180000f, 1 },
                    { 14, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở bò với thịt bò tái mềm ngon.", 7, "phobo_tai.jpg", "Phở Bò Tái", 50000f, 1 },
                    { 15, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở bò với thịt bò tái và chín mềm ngon.", 7, "phobo_taichin.jpg", "Phở Bò Tái Chín", 50000f, 1 },
                    { 16, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở bò với thịt bò chín mềm ngon.", 7, "phobo_chin.jpg", "Phở Bò Chín", 50000f, 1 },
                    { 17, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở bò với thịt bò nạm mềm ngon.", 7, "phobo_nam.jpg", "Phở Bò Nạm", 50000f, 1 },
                    { 18, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở bò với thịt bò gân mềm ngon.", 7, "phobo_gan.jpg", "Phở Bò Gân", 50000f, 1 },
                    { 19, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở bò với thịt bò sách mềm ngon.", 7, "phobo_sach.jpg", "Phở Bò Sách", 50000f, 1 },
                    { 20, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở gà với thịt gà đùi mềm ngon.", 8, "phoga_dui.jpg", "Phở Gà Đùi", 50000f, 1 },
                    { 21, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở gà với thịt gà lườn mềm ngon.", 8, "phoga_luon.jpg", "Phở Gà Lườn", 50000f, 1 },
                    { 22, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở gà với thịt gà cánh mềm ngon.", 8, "phoga_canh.jpg", "Phở Gà Cánh", 50000f, 1 },
                    { 23, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở gà với thịt gà và tim cật.", 8, "phoga_timcat.jpg", "Phở Gà Tim Cật", 50000f, 1 },
                    { 24, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở chay với nước dùng và đậu hũ.", 9, "phochay_dauhu.jpg", "Phở Chay Đậu Hũ", 50000f, 1 },
                    { 25, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở chay với nước dùng và đậu hũ.", 9, "phochay_nam.jpg", "Phở Chay Nấm", 50000f, 1 },
                    { 26, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở với sườn bò mềm ngon.", 10, "phosuon_bo.jpg", "Phở Sườn Bò", 50000f, 1 },
                    { 27, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở với sườn heo mềm ngon.", 10, "phosuon_heo.jpg", "Phở Sườn Heo", 50000f, 1 },
                    { 28, new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad trộn với rau sống và sốt truyền thống.", 11, "salad_tron.jpg", "Salad Trộn", 50000f, 1 },
                    { 29, new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad với cá ngừ và sốt truyền thống.", 11, "salad_cangu.jpg", "Salad Cá Ngừ", 50000f, 1 },
                    { 30, new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad gà và bơ avocado với sốt vinaigrette.", 11, "chicken_avocado_salad.jpg", "Chicken Avocado Salad", 70000f, 1 },
                    { 31, new DateTime(2015, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad Caesar truyền thống với sốt mayonnaise và phô mai.", 11, "caesar_salad.jpg", "Caesar Salad", 90000f, 1 },
                    { 32, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh mì tỏi nướng giòn thơm phức.", 12, "garlic_bread.jpg", "Garlic Bread", 50000f, 1 },
                    { 33, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cocktail tôm tươi ngon với sốt cay lạnh.", 12, "shrimp_cocktail.jpg", "Shrimp Cocktail", 120000f, 1 },
                    { 34, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruschetta nấm phô mai với dầu ôliu.", 12, "mushroom_bruschetta.jpg", "Mushroom Bruschetta", 90000f, 1 },
                    { 35, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vỏ khoai tây nướng với phô mai và thịt xông khói.", 12, "potato_skins.jpg", "Potato Skins", 110000f, 1 },
                    { 36, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ớt chuông nhồi phô mai, nướng giòn.", 12, "cheese_stuffed_jalapenos.jpg", "Cheese Stuffed Jalapeños", 95000f, 1 },
                    { 37, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tartare cá ngừ với sốt hạt tiêu và cần tây.", 12, "tuna_tartare.jpg", "Tuna Tartare", 120000f, 1 },
                    { 38, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ceviche tôm với cà chua, dưa leo, và hành tây.", 12, "shrimp_ceviche.jpg", "Shrimp Ceviche", 110000f, 1 },
                    { 39, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đĩa cá hồi hút khói phục vụ với bánh mì và kem cheese.", 12, "smoked_salmon_platter.jpg", "Smoked Salmon Platter", 630000f, 1 },
                    { 40, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carpaccio bò với rucola, phô mai parmesan, và sốt mù tạt.", 12, "beef_carpaccio.jpg", "Beef Carpaccio", 440000f, 1 },
                    { 41, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Filet Mignon steak với nước sốt đặc biệt.", 13, "filet_mignon.jpg", "Filet Mignon", 350000f, 1 },
                    { 42, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ribeye steak chảo nước sốt tiêu xanh.", 13, "ribeye_steak.jpg", "Ribeye Steak", 290000f, 1 },
                    { 43, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "T-bone steak với gia vị hảo hạng.", 13, "t_bone_steak.jpg", "T-bone Steak", 750000f, 1 },
                    { 44, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York Strip steak với nước sốt hạt tiêu.", 13, "new_york_strip.jpg", "New York Strip", 380000f, 1 },
                    { 45, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porterhouse steak nướng chín với ớt và tỏi.", 13, "porterhouse_steak.jpg", "Porterhouse Steak", 620000f, 1 },
                    { 46, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sirloin steak với sốt hành tỏi.", 13, "sirloin_steak.jpg", "Sirloin Steak", 550000f, 1 },
                    { 47, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flank steak với gia vị tỏi và hạt tiêu.", 13, "flank_steak.jpg", "Flank Steak", 380000f, 1 },
                    { 48, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prime Rib steak nướng chín với muối và hạt tiêu.", 13, "prime_rib_steak.jpg", "Prime Rib", 450000f, 1 },
                    { 49, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skirt steak với gia vị đặc biệt.", 13, "skirt_steak.jpg", "Skirt Steak", 420000f, 1 },
                    { 50, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chateaubriand steak với sốt nước sốt đậm đà.", 13, "chateaubriand_steak.jpg", "Chateaubriand", 670000f, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "FoodCharacteristics");

            migrationBuilder.DropTable(
                name: "FoodOrder");

            migrationBuilder.DropTable(
                name: "Foods");

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
