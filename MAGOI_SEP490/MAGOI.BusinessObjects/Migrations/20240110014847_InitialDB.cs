using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MAGOI.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    FoodCategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.FoodCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FoodCategoryId = table.Column<int>(type: "integer", nullable: false),
                    RestaurantId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Hotline = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "FoodCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Danh mục này bao gồm các loại đồ uống như cà phê, trà, nước ép, nước ngọt và các loại thức uống khác.\r\n", "Đồ uống" },
                    { 2, "Đây là danh mục chứa các món ăn chính, thường là các món có thịt, cá hoặc rau củ.", "Món chính" },
                    { 3, "Danh mục này bao gồm các loại tráng miệng như bánh ngọt, kem, hoa quả hay các món tráng miệng truyền thống.", "Món tráng miệng" },
                    { 4, "Đây là danh mục chứa các món ăn nhẹ như salad, canapé, bánh mì, hoặc các món ăn nhẹ dùng như bữa ăn phụ.", "Món nhẹ" },
                    { 5, "Danh mục này bao gồm các loại món ăn được chế biến từ nước, chẳng hạn như các món canh, súp, hoặc mì nước.", "Món nước" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedAt", "Description", "FoodCategoryId", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3667), "Một tách cà phê đen đậm đà, nguyên chất từ hạt cà phê Arabica.", 1, "Cà phê đen", 30000f, 1 },
                    { 2, new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3671), "Trà xanh kết hợp với hương vị bưởi tự nhiên, thơm ngon và thanh mát.", 1, "Trà bưởi", 25000f, 2 },
                    { 3, new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3673), "Gà quay thơm ngon, phục vụ cùng cơm trắng và xốt đậm đà.", 2, "Cơm gà Hải Nam", 60000f, 1 },
                    { 4, new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3674), "Một phần bún nước dùng đậm đà kết hợp với thịt bò, huyết và chả.", 2, "Bún bò Huế", 50000f, 2 },
                    { 5, new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3675), "Một loại bánh ngọt với hương vị cà phê đặc trưng và kem tươi mịn.", 3, "Bánh tiramisu", 40000f, 3 },
                    { 6, new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3677), "Chè truyền thống Việt Nam với đậu xanh, nước cốt dừa và đường ", 3, "Chè đậu xanh", 35000f, 3 },
                    { 7, new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3678), "Bánh mì mỏng, nướng giòn kết hợp với thịt, rau sống và sốt mỡ.", 4, "Bánh mì kẹp thịt", 40000f, 3 },
                    { 8, new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3680), "Một phần salad phong cách Cesar với rau, phô mai và sốt đặc trưng.", 4, "Salad Cesar", 45000f, 3 },
                    { 9, new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3681), "Một tô phở nước dùng từ xương gà, kèm theo thịt gà và gia vị.", 5, "Canh chua cá", 55000f, 3 },
                    { 10, new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3683), "Canh chua với chất axit nhẹ từ dấm, ngọt từ cá và thơm từ rau sống.", 5, "Phở gà", 45000f, 3 }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "CreatedAt", "Email", "Hotline", "Name" },
                values: new object[,]
                {
                    { 1, "80B P. Mã Mây, Phố cổ Hà Nội, Hoàn Kiếm, Hà Nội 100000, Việt Nam", new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3476), "hncuisine@gmail.com", "0866168021", "Hanoi Cuisine 1925" },
                    { 2, "9 Đinh Tiên Hoàng, Hàng Trống, Hoàn Kiếm, Hà Nội", new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3487), "vncuisine@gmail.com", "099977584", "Vietnamese Cuisine Restaurant" },
                    { 3, "Sheraton Hotel, K5 Nghi Tam, Road, 11 Đ. Xuân Diệu, Quảng An, Tây Hồ, Hà Nội, Việt Nam", new DateTime(2024, 1, 10, 8, 48, 47, 896, DateTimeKind.Local).AddTicks(3489), "sheratonhanoi@gmail.com", "0903420955", "Oven d'Or Restaurant" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
