using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class GenerateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 14);

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

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "Id", "Characteristic" },
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
                    { 28, "Thịt vịt" }
                });

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: "Món khai vị");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: "Món chính");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Category",
                value: "Đồ ăn kèm");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Category",
                value: "Salad");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Category",
                value: "Nước sốt");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Category",
                value: "Đồ uống");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Category",
                value: "Món tráng miệng");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Category",
                value: "Pasta");

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Category" },
                values: new object[] { 5, "Soup" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xúc xích cỡ lớn 300g với đồ muối chua", "big-beerfest-bausages.jpg", "BIG BEERFEST SAUSAGES", 199000f, 100 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xúc xích Đức nướng ăn kèm salad rau tổng hợp", "grilled-german-gausages.jpg", "GRILLED GERMAN SAUSAGES", 136000f, 100 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bánh mì bơ tỏi", "garlic-bread.jpg", "GARLIC BREAD", 30000f, 100 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khoai tây chiên", 1, "french-fried.jpg", "FRENCH FRIED", 50f, 100 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cánh gà nướng BBQ ăn kèm Salad, khoai tây chiên (2 cánh)", 1, "chicken-wings.jpg", "CHICKEN WINGS", 86000f, 100 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đĩa tổng hợp các loại khoai chiên", 1, "beer-batter-fries.jpg", "BEER BATTER FRIES", 99000f, 100 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gan Ngỗng áp chảo cùng Mứt, sốt xoài và bánh mỳ Pháp nướng", 1, "pan-seared-foie-gras.jpg", "PAN SEARED FOIE-GRAS", 196000f, 100 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: "Lẩu Tom Yum");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: "Lẩu Tom Kha");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Category",
                value: "Lẩu Green Curry");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Category",
                value: "Lẩu Red Curry");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Category",
                value: "Lẩu Massaman");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 7,
                column: "Category",
                value: "Phở Bò");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 8,
                column: "Category",
                value: "Phở Gà");

            migrationBuilder.UpdateData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: 9,
                column: "Category",
                value: "Phở Chay");

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Category" },
                values: new object[,]
                {
                    { 10, "Phở Sườn" },
                    { 11, "Salad" },
                    { 12, "Món Khai Vị" },
                    { 13, "Món Lạnh" },
                    { 14, "Steak" }
                });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm với hương vị đậm đà của nước lẩu Tom Yum.", "tomyum_goong.jpg", "Tom Yum Goong", 250000f, 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu gà với hương vị đậm đà của nước lẩu Tom Yum.", "tomyum_gai.jpg", "Tom Yum Gai", 320000f, 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu hải sản với hương vị đậm đà của nước lẩu Tom Yum.", "tomyum_talay.jpg", "Tom Yum Talay", 180000f, 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm với hương vị đậm đà của nước lẩu Tom Kha và sữa cô cocon", 2, "tomkha_goong.jpg", "Tom Kha Goong", 160000f, 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu gà với hương vị đậm đà của nước lẩu Tom Kha và với sữa cô cocon", 2, "tomkha_gai.jpg", "Tom Kha Gai", 130000f, 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu hải sản với hương vị đậm đà của nước lẩu Tom Kha và sữa cô cocon", 2, "tomkha_talay.jpg", "Tom Kha Talay", 190000f, 1 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[] { new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lẩu tôm xanh với hương vị đậm đà của nước lẩu Green Curry.", 3, "greencurry_goong.jpg", "Green Curry Goong", 170000f, 1 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedAt", "Description", "FoodCategoryId", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
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
    }
}
