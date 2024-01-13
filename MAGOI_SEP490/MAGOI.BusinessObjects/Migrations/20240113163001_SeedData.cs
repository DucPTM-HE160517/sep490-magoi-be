using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MAGOI.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Lẩu Thái với hương vị đậm đà của nước lẩu Tom Yum.", "Lẩu Tom Yum" },
                    { 2, "Lẩu Thái với sự hòa quyện của nước lẩu Tom Kha và sữa cô cocon.", "Lẩu Tom Kha" },
                    { 3, "Lẩu Thái với nước lẩu xanh mát từ cà ri xanh.", "Lẩu Green Curry" },
                    { 4, "Lẩu Thái với hương vị độc đáo của nước lẩu Red Curry.", "Lẩu Red Curry" },
                    { 6, "Lẩu Thái với gia vị đặc trưng của cà ri Massaman.", "Lẩu Massaman" },
                    { 7, "Một trong những món phở nổi tiếng với nước dùng thơm ngon và thịt bò mềm.", "Phở Bò" },
                    { 8, "Món phở với nước dùng hương vị và thịt gà tươi ngon.", "Phở Gà" },
                    { 9, "Phở dành cho người ăn chay, với nước dùng và nguyên liệu chay thơm ngon.", "Phở Chay" },
                    { 10, "Phở với sườn nước dùng đậm đà và thịt sườn ngon mắt.", "Phở Sườn" },
                    { 11, "Món salad tươi ngon với rau sống và sốt truyền thống.", "Salad" },
                    { 12, "Các món khai vị hấp dẫn để bắt đầu bữa ăn.", "Món Khai Vị" },
                    { 13, "Món lạnh ngon lành, phù hợp cho bữa ăn nhẹ.", "Món Lạnh" },
                    { 14, "Các loại steak chất lượng cao, nướng hoặc nướng chín theo yêu cầu.", "Steak" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "IsAvailable", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm với hương vị đậm đà của nước lẩu Tom Yum.", 1, "tomyum_goong.jpg", true, "Tom Yum Goong", 250000f, 1 },
                    { 2, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu gà với hương vị đậm đà của nước lẩu Tom Yum.", 1, "tomyum_gai.jpg", true, "Tom Yum Gai", 320000f, 1 },
                    { 3, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu hải sản với hương vị đậm đà của nước lẩu Tom Yum.", 1, "tomyum_talay.jpg", true, "Tom Yum Talay", 180000f, 1 },
                    { 4, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm với hương vị đậm đà của nước lẩu Tom Kha và sữa cô cocon", 2, "tomkha_goong.jpg", true, "Tom Kha Goong", 160000f, 1 },
                    { 5, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu gà với hương vị đậm đà của nước lẩu Tom Kha và với sữa cô cocon", 2, "tomkha_gai.jpg", true, "Tom Kha Gai", 130000f, 1 },
                    { 6, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu hải sản với hương vị đậm đà của nước lẩu Tom Kha và sữa cô cocon", 2, "tomkha_talay.jpg", true, "Tom Kha Talay", 190000f, 1 },
                    { 7, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm xanh với hương vị đậm đà của nước lẩu Green Curry.", 3, "greencurry_goong.jpg", true, "Green Curry Goong", 170000f, 1 },
                    { 8, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu gà với hương vị đậm đà của nước lẩu Green Curry.", 3, "greencurry_gai.jpg", true, "Green Curry Gai", 140000f, 1 },
                    { 9, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu hải sản với hương vị đậm đà của nước lẩu Green Curry.", 3, "greencurry_talay.jpg", true, "Green Curry Talay", 200000f, 1 },
                    { 10, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm cay với hương vị đậm đà của nước lẩu Red Curry.", 4, "spicy_redcurry_goong.jpg", true, "Spicy Red Curry Goong", 200000f, 1 },
                    { 11, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu nấm với hương vị đậm đà của nước lẩu Red Curry.", 4, "redcurry_mushroom.jpg", true, "Red Curry Mushroom", 170000f, 1 },
                    { 12, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm cay với hương vị đậm đà của nước lẩu Massaman.", 6, "spicy_massaman_goong.jpg", true, "Spicy Massaman Curry Goong", 210000f, 1 },
                    { 13, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu gà với hương vị đậm đà của nước lẩu Massaman.", 6, "massaman_chicken.jpg", true, "Massaman Curry Chicken", 180000f, 1 },
                    { 14, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở bò với thịt bò tái mềm ngon.", 7, "phobo_tai.jpg", true, "Phở Bò Tái", 50000f, 2 },
                    { 15, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở bò với thịt bò tái và chín mềm ngon.", 7, "phobo_taichin.jpg", true, "Phở Bò Tái Chín", 50000f, 2 },
                    { 16, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở bò với thịt bò chín mềm ngon.", 7, "phobo_chin.jpg", true, "Phở Bò Chín", 50000f, 2 },
                    { 17, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở bò với thịt bò nạm mềm ngon.", 7, "phobo_nam.jpg", true, "Phở Bò Nạm", 50000f, 2 },
                    { 18, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở bò với thịt bò gân mềm ngon.", 7, "phobo_gan.jpg", true, "Phở Bò Gân", 50000f, 2 },
                    { 19, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở bò với thịt bò sách mềm ngon.", 7, "phobo_sach.jpg", true, "Phở Bò Sách", 50000f, 2 },
                    { 20, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở gà với thịt gà đùi mềm ngon.", 8, "phoga_dui.jpg", true, "Phở Gà Đùi", 50000f, 2 },
                    { 21, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở gà với thịt gà lườn mềm ngon.", 8, "phoga_luon.jpg", true, "Phở Gà Lườn", 50000f, 2 },
                    { 22, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở gà với thịt gà cánh mềm ngon.", 8, "phoga_canh.jpg", true, "Phở Gà Cánh", 50000f, 2 },
                    { 23, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở gà với thịt gà và tim cật.", 8, "phoga_timcat.jpg", true, "Phở Gà Tim Cật", 50000f, 2 },
                    { 24, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở chay với nước dùng và đậu hũ.", 9, "phochay_dauhu.jpg", true, "Phở Chay Đậu Hũ", 50000f, 2 },
                    { 25, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở chay với nước dùng và đậu hũ.", 9, "phochay_nam.jpg", true, "Phở Chay Nấm", 50000f, 2 },
                    { 26, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở với sườn bò mềm ngon.", 10, "phosuon_bo.jpg", true, "Phở Sườn Bò", 50000f, 2 },
                    { 27, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phở với sườn heo mềm ngon.", 10, "phosuon_heo.jpg", true, "Phở Sườn Heo", 50000f, 2 },
                    { 28, new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad trộn với rau sống và sốt truyền thống.", 11, "salad_tron.jpg", true, "Salad Trộn", 50000f, 3 },
                    { 29, new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad với cá ngừ và sốt truyền thống.", 11, "salad_cangu.jpg", true, "Salad Cá Ngừ", 50000f, 3 },
                    { 30, new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad gà và bơ avocado với sốt vinaigrette.", 11, "chicken_avocado_salad.jpg", true, "Chicken Avocado Salad", 70000f, 3 },
                    { 31, new DateTime(2015, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salad Caesar truyền thống với sốt mayonnaise và phô mai.", 11, "caesar_salad.jpg", true, "Caesar Salad", 90000f, 3 },
                    { 32, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh mì tỏi nướng giòn thơm phức.", 12, "garlic_bread.jpg", true, "Garlic Bread", 50000f, 3 },
                    { 33, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cocktail tôm tươi ngon với sốt cay lạnh.", 12, "shrimp_cocktail.jpg", true, "Shrimp Cocktail", 120000f, 3 },
                    { 34, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruschetta nấm phô mai với dầu ôliu.", 12, "mushroom_bruschetta.jpg", true, "Mushroom Bruschetta", 90000f, 3 },
                    { 35, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vỏ khoai tây nướng với phô mai và thịt xông khói.", 12, "potato_skins.jpg", true, "Potato Skins", 110000f, 3 },
                    { 36, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ớt chuông nhồi phô mai, nướng giòn.", 12, "cheese_stuffed_jalapenos.jpg", true, "Cheese Stuffed Jalapeños", 95000f, 3 },
                    { 37, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tartare cá ngừ với sốt hạt tiêu và cần tây.", 12, "tuna_tartare.jpg", true, "Tuna Tartare", 120000f, 3 },
                    { 38, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ceviche tôm với cà chua, dưa leo, và hành tây.", 12, "shrimp_ceviche.jpg", true, "Shrimp Ceviche", 110000f, 3 },
                    { 39, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đĩa cá hồi hút khói phục vụ với bánh mì và kem cheese.", 12, "smoked_salmon_platter.jpg", true, "Smoked Salmon Platter", 630000f, 3 },
                    { 40, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carpaccio bò với rucola, phô mai parmesan, và sốt mù tạt.", 12, "beef_carpaccio.jpg", true, "Beef Carpaccio", 440000f, 3 },
                    { 41, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Filet Mignon steak với nước sốt đặc biệt.", 13, "filet_mignon.jpg", true, "Filet Mignon", 350000f, 3 },
                    { 42, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ribeye steak chảo nước sốt tiêu xanh.", 13, "ribeye_steak.jpg", true, "Ribeye Steak", 290000f, 3 },
                    { 43, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "T-bone steak với gia vị hảo hạng.", 13, "t_bone_steak.jpg", true, "T-bone Steak", 750000f, 3 },
                    { 44, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York Strip steak với nước sốt hạt tiêu.", 13, "new_york_strip.jpg", true, "New York Strip", 380000f, 3 },
                    { 45, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porterhouse steak nướng chín với ớt và tỏi.", 13, "porterhouse_steak.jpg", true, "Porterhouse Steak", 620000f, 3 },
                    { 46, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sirloin steak với sốt hành tỏi.", 13, "sirloin_steak.jpg", true, "Sirloin Steak", 550000f, 3 },
                    { 47, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flank steak với gia vị tỏi và hạt tiêu.", 13, "flank_steak.jpg", true, "Flank Steak", 380000f, 3 },
                    { 48, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prime Rib steak nướng chín với muối và hạt tiêu.", 13, "prime_rib_steak.jpg", true, "Prime Rib", 450000f, 3 },
                    { 49, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skirt steak với gia vị đặc biệt.", 13, "skirt_steak.jpg", true, "Skirt Steak", 420000f, 3 },
                    { 50, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chateaubriand steak với sốt nước sốt đậm đà.", 13, "chateaubriand_steak.jpg", true, "Chateaubriand", 670000f, 3 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantCategories",
                columns: new[] { "RestaurantCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Nhà hàng chuyên về các món lẩu.", "Nhà hàng Lẩu" },
                    { 2, "Nhà hàng chuyên về các món phở.", "Nhà hàng Phở" },
                    { 3, "Nhà hàng chuyên về các món steak.", "Nhà hàng Steak" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "CreatedAt", "Email", "Hotline", "IsAvailable", "Name", "RestaurantCategoryId" },
                values: new object[,]
                {
                    { 1, "Số 5 Quan Hoa, Cầu Giấy, Hà Nội", new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "mkt@mamagroup.vn", "02477748666", true, "Thái Deli", 1 },
                    { 2, "13 Lò Đúc, quận Hai Bà Trưng, Hà Nội", new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "phothin1979hanoi@gmail.com", "0966657997", true, "Phở Thìn Lò Đúc", 2 },
                    { 3, "184 Hào Nam, Cát Linh, Đống Đa, Hà Nội", new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "grill66steakhousevn@gmail.com", "0965401915", true, "Grille6 Steakhouse", 3 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableID", "CreatedAt", "IsAvailable", "Name", "RestaurantId" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 1", 1 },
                    { 2, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 2", 1 },
                    { 3, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 3", 1 },
                    { 4, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 4", 1 },
                    { 5, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 5", 1 },
                    { 6, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 6", 1 },
                    { 7, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 7", 1 },
                    { 8, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 8", 1 },
                    { 9, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 9", 1 },
                    { 10, new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 10", 1 },
                    { 11, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 1", 2 },
                    { 12, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 2", 2 },
                    { 13, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 3", 2 },
                    { 14, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 4", 2 },
                    { 15, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 5", 2 },
                    { 16, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 6", 2 },
                    { 17, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 7", 2 },
                    { 18, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 8", 2 },
                    { 19, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 9", 2 },
                    { 20, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 10", 2 },
                    { 21, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 11", 2 },
                    { 22, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 12", 2 },
                    { 23, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 13", 2 },
                    { 24, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 14", 2 },
                    { 25, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 15", 2 },
                    { 26, new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 1", 3 },
                    { 27, new DateTime(2015, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 2", 3 },
                    { 28, new DateTime(2015, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 3", 3 },
                    { 29, new DateTime(2015, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 4", 3 },
                    { 30, new DateTime(2015, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 5", 3 },
                    { 31, new DateTime(2015, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 6", 3 },
                    { 32, new DateTime(2015, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 7", 3 },
                    { 33, new DateTime(2015, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 8", 3 },
                    { 34, new DateTime(2015, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 9", 3 },
                    { 35, new DateTime(2015, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 10", 3 },
                    { 36, new DateTime(2015, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 11", 3 },
                    { 37, new DateTime(2015, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 12", 3 },
                    { 38, new DateTime(2015, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 13", 3 },
                    { 39, new DateTime(2015, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 14", 3 },
                    { 40, new DateTime(2015, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bàn 15", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "FoodCategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "RestaurantCategories",
                keyColumn: "RestaurantCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RestaurantCategories",
                keyColumn: "RestaurantCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RestaurantCategories",
                keyColumn: "RestaurantCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 40);
        }
    }
}
