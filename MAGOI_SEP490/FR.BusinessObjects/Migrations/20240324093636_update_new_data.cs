using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FR.BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class update_new_data : Migration
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
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FinishedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                    OrderAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                    { 4, "Món tráng miệng" },
                    { 5, "Đồ uống" }
                });

            migrationBuilder.InsertData(
                table: "FoodLabels",
                columns: new[] { "FoodId", "LabelId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 },
                    { 3, 4 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 8 },
                    { 11, 8 },
                    { 12, 7 },
                    { 13, 9 },
                    { 14, 2 },
                    { 14, 6 },
                    { 15, 6 },
                    { 16, 2 },
                    { 16, 6 }
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
                    { 1, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Xúc xích cỡ lớn 300g với đồ muối chua", 1, "big-beerfest-bausages.jpg", "BIG BEERFEST SAUSAGES", 100, 199000f },
                    { 2, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Bánh mì bơ tỏi", 1, "garlic-bread.jpg", "GARLIC BREAD", 100, 30000f },
                    { 3, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Khoai tây chiên", 1, "french-fried.jpg", "FRENCH FRIED", 100, 50000f },
                    { 4, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Thăn lưng Wagyu MB4/5 250g", 2, "aus-rib-eye-mb4-5.jpg", "AUS RIB EYE MB4/5", 100, 1280000f },
                    { 5, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Thăn Flank Wagyu MB7/8 250g", 2, "aus-rib-eye-mb7-8.jpg", "AUS RIB EYE MB7/8", 100, 660000f },
                    { 6, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Thăn lưng bò Mỹ Prime 500g", 2, "us-prime-rib-eye.jpg", "US PRIME RIB EYE", 100, 960000f },
                    { 7, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Thăn Bò Angus chữ T Úc 700g", 2, "aus-black-angus-t-bone.jpg", "AUS BLACK ANGUS T-BONE", 100, 1160000f },
                    { 8, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Thăn lưng bò Mỹ 350g", 2, "us-rib-eye.jpg", "US RIB EYE", 100, 596000f },
                    { 9, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Khoai tây nghiền", 3, "mashed-potato.jpg", "MASHED POTATO", 100, 30000f },
                    { 10, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Khoai tây bi đút lò", 3, "roasted-baby-potato.jpg", "ROASTED BABY POTATO", 100, 30000f },
                    { 11, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Coca Cola", 5, "coca-cola.jpg", "COCA COLA", 100, 30000f },
                    { 12, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Nước suối", 5, "tapid-water.jpg", "TAPID WATER", 100, 20000f },
                    { 13, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Sinh tố dưa hấu", 5, "sinh-to-dua-hau.jpg", "SINH TỐ DƯA HẤU", 100, 50000f },
                    { 14, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Vang đỏ Barolo", 5, "barola.jpg", "BAROLA", 20, 1200000f },
                    { 15, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Kem cháy gừng cùng với bánh quy giòn", 4, "ginger-cream-brulee.jpg", "GINGER CREAM BRULEE", 100, 46000f },
                    { 16, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Bánh chocolate nướng chảy, kem vanilla và dừa sấy", 4, "warm-chocolate-lava-cake.jpg", "WARM CHOCOLATE LAVA CAKE", 100, 50000f },
                    { 17, new DateTime(2020, 10, 9, 17, 0, 0, 0, DateTimeKind.Utc), "Kem Haagen Dazs, chocolate, vanilla, red berries, macha, Maccadmia nut", 4, "ice-cream-haagen-dazs.jpg", "ICE CREAM HAAGEN DAZS", 100, 88000f }
                });

            migrationBuilder.InsertData(
                table: "Labels",
                columns: new[] { "Id", "Label" },
                values: new object[,]
                {
                    { 1, "Món nóng" },
                    { 2, "Món lạnh" },
                    { 3, "Món nướng" },
                    { 4, "Món chiên" },
                    { 5, "Bánh" },
                    { 6, "Kem" },
                    { 7, "Nước ép" },
                    { 8, "Nước ngọt" },
                    { 9, "Rượu vang" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Cooking" },
                    { 3, "Serving" },
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
                    { new Guid("24421c43-7ce9-49f9-b279-545130db8777"), "Bàn 2", 1 },
                    { new Guid("42faf975-c839-4282-a42c-4df9963c3d4c"), "Bàn 9", 1 },
                    { new Guid("464d6381-2f42-4d17-9402-b4fb1728623e"), "Bàn 6", 1 },
                    { new Guid("72d44212-da44-4735-9846-af8e859c2086"), "Bàn 3", 1 },
                    { new Guid("79709257-f504-4186-aea9-d87a316ff42e"), "Bàn 7", 1 },
                    { new Guid("9e4241f8-ad17-48c4-8f49-9bb8607285c4"), "Bàn 12", 1 },
                    { new Guid("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb"), "Bàn 1", 1 },
                    { new Guid("a6c5a1d6-1942-48fc-9eca-1b5e9499ba6d"), "Bàn 4", 1 },
                    { new Guid("b9da28be-79af-4258-8cd7-c608c5fa2d8c"), "Bàn 5", 1 },
                    { new Guid("cca0bf6c-af6e-4c37-8636-db7a562bb57e"), "Bàn 11", 1 },
                    { new Guid("f63c6d7a-7d37-4a06-a80c-a311424eac59"), "Bàn 10", 1 }
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
