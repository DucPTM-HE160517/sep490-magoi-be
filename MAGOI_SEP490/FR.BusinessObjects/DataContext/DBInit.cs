using FR.BusinessObjects.Models;
using FR.Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;

namespace FR.BusinessObjects.DataContext
{
    public static class DBInit
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<FoodCategory>().HasData(
                new FoodCategory
                {
                    Id = 1,
                    Category = "Món khai vị",
                },
                new FoodCategory
                {
                    Id = 2,
                    Category = "Món chính",
                },
                new FoodCategory
                {
                    Id = 3,
                    Category = "Đồ ăn kèm",
                },
                new FoodCategory
                {
                    Id = 4,
                    Category = "Món tráng miệng"
                },
                new FoodCategory
                {
                    Id = 5,
                    Category = "Đồ uống"
                }
            );

            modelBuilder.Entity<Labels>().HasData(
                new Labels
                {
                    Id = 1,
                    Label = "Món nóng"
                },
                new Labels
                {
                    Id = 2,
                    Label = "Món lạnh"
                },
                new Labels
                {
                    Id = 3,
                    Label = "Món nướng"
                },
                new Labels
                {
                    Id = 4,
                    Label = "Món chiên"
                },
                new Labels
                {
                    Id = 5,
                    Label = "Bánh"
                },
                new Labels
                {
                    Id = 6,
                    Label = "Kem"
                },
                new Labels
                {
                    Id = 7,
                    Label = "Nước ép"
                },
                new Labels
                {
                    Id = 8,
                    Label = "Nước ngọt"
                },
                new Labels
                {
                    Id = 9,
                    Label = "Rượu vang"
                }
            );

            modelBuilder.Entity<Food>().HasData(
                // Món khai vị
                new Food
                {
                    Id = 1,
                    Name = "BIG BEERFEST SAUSAGES",
                    Description = "Xúc xích cỡ lớn 300g với đồ muối chua",
                    ImageUrl = @"https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712752772/food/x3cmbnieirpdhnwjksx1.jpg",
                    UnitPrice = 199000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    FoodCategoryId = 1
                },
                new Food
                {
                    Id = 2,
                    Name = "GARLIC BREAD",
                    Description = "Bánh mì bơ tỏi",
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712752931/food/sjdjybr8ywcxymb9zs7u.jpg",
                    UnitPrice = 30000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    FoodCategoryId = 1
                },
                new Food
                {
                    Id = 3,
                    Name = "FRENCH FRIED",
                    Description = "Khoai tây chiên",
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712752944/food/et1ikezxar76ax8qwbse.jpg",
                    UnitPrice = 50000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    FoodCategoryId = 1
                },

                // Món chính
                new Food
                {
                    Id = 4,
                    Name = "AUS RIB EYE MB4/5",
                    Description = "Thăn lưng Wagyu MB4/5 250g",
                    ImageUrl = "aus-rib-eye-mb4-5.jpg",
                    UnitPrice = 1280000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    FoodCategoryId = 2
                },
                new Food
                {
                    Id = 5,
                    Name = "AUS RIB EYE MB7/8",
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712754609/food/lllceyocl5alvttkrek0.jpg",
                    Description = "Thăn Flank Wagyu MB7/8 250g",
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    Quantity = 100,
                    FoodCategoryId = 2,
                    UnitPrice = 660000
                },
                new Food
                {
                    Id = 6,
                    Name = "US PRIME RIB EYE",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    FoodCategoryId = 2,
                    UnitPrice = 960000,
                    Description = "Thăn lưng bò Mỹ Prime 500g",
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712754663/food/uz171brtyh6nndmyi1fa.jpg"
                },
                new Food
                {
                    Id = 7,
                    Name = "AUS BLACK ANGUS T-BONE",
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712754649/food/dk5p48irgg1qkfu6hem6.jpg",
                    Description = "Thăn Bò Angus chữ T Úc 700g",
                    UnitPrice = 1160000,
                    FoodCategoryId = 2,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    Quantity = 100
                },
                new Food
                {
                    Id = 8,
                    Name = "US RIB EYE",
                    ImageUrl = "us-rib-eye.jpg",
                    Description = "Thăn lưng bò Mỹ 350g",
                    UnitPrice = 596000,
                    FoodCategoryId = 2,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    Quantity = 100
                },

                // Đồ ăn kèm
                new Food
                {
                    Id = 9,
                    Name = "MASHED POTATO",
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712754683/food/wyecqhosqih1dp5kqdoi.jpg",
                    FoodCategoryId = 3,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    Quantity = 100,
                    UnitPrice = 30000,
                    Description = "Khoai tây nghiền"
                },
                new Food
                {
                    Id = 10,
                    Name = "ROASTED BABY POTATO",
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712754693/food/qwdsvgxlmkb3o5ihd6w5.jpg",
                    FoodCategoryId = 3,
                    Description = "Khoai tây bi đút lò",
                    UnitPrice = 30000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime()
                },

                // Đồ uống
                new Food
                {
                    Id = 11,
                    Name = "COCA COLA",
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712754713/food/nikdk72dzagoq5uufpyp.jpg",
                    Description = "Coca Cola",
                    UnitPrice = 30000,
                    FoodCategoryId = 5,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime()
                },
                new Food
                {
                    Id = 12,
                    Name = "TAPID WATER",
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712755040/food/gzuhr5ftcbmsw56ugllf.jpg",
                    Description = "Nước suối",
                    UnitPrice = 20000,
                    FoodCategoryId = 5,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime()
                },
                new Food
                {
                    Id = 13,
                    Name = "SINH TỐ DƯA HẤU",
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712755090/food/zlcwf0ylh37t08xfqnjq.jpg",
                    Description = "Sinh tố dưa hấu",
                    UnitPrice = 50000,
                    FoodCategoryId = 5,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime()
                },
                new Food
                {
                    Id = 14,
                    Name = "BAROLA",
                    ImageUrl = "barola.jpg",
                    Description = "Vang đỏ Barolo",
                    UnitPrice = 1200000,
                    FoodCategoryId = 5,
                    Quantity = 20,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime()
                },

                // Món tráng miệng
                new Food
                {
                    Id = 15,
                    Name = "GINGER CREAM BRULEE",
                    Description = "Kem cháy gừng cùng với bánh quy giòn",
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712755058/food/louyddpnd8jdxfucc0jk.jpg",
                    FoodCategoryId = 4,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    Quantity = 100,
                    UnitPrice = 46000
                },
                new Food
                {
                    Id = 16,
                    Name = "WARM CHOCOLATE LAVA CAKE",
                    Description = "Bánh chocolate nướng chảy, kem vanilla và dừa sấy",
                    UnitPrice = 50000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    FoodCategoryId = 4,
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712752851/food/okhglhvncr0ajufxnhvy.jpg"
                },
                new Food
                {
                    Id = 17,
                    Name = "ICE CREAM HAAGEN DAZS",
                    ImageUrl = "https://res.cloudinary.com/dj1jfpv7y/image/upload/v1712752833/food/sddppgmwzkphvm1in0pi.jpg",
                    Description = "Kem Haagen Dazs, chocolate, vanilla, red berries, macha, Maccadmia nut",
                    FoodCategoryId = 4,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    Quantity = 100,
                    UnitPrice = 88000,
                }
            );

            modelBuilder.Entity<FoodLabels>().HasData(
                new FoodLabels
                {
                    FoodId = 1,
                    LabelId = 2
                },
                new FoodLabels
                {
                    FoodId = 2,
                    LabelId = 1
                },
                new FoodLabels
                {
                    FoodId = 3,
                    LabelId = 4
                },
                new FoodLabels
                {
                    FoodId = 4,
                    LabelId = 3
                },
                new FoodLabels
                {
                    FoodId = 5,
                    LabelId = 3
                },
                new FoodLabels
                {
                    FoodId = 6,
                    LabelId = 3
                },
                new FoodLabels
                {
                    FoodId = 7,
                    LabelId = 3
                },
                new FoodLabels
                {
                    FoodId = 8,
                    LabelId = 1
                },
                new FoodLabels
                {
                    FoodId = 9,
                    LabelId = 1
                },
                new FoodLabels
                {
                    FoodId = 10,
                    LabelId = 8
                },
                new FoodLabels
                {
                    FoodId = 11,
                    LabelId = 8
                },
                new FoodLabels
                {
                    FoodId = 12,
                    LabelId = 7
                },
                new FoodLabels
                {
                    FoodId = 13,
                    LabelId = 9
                },
                new FoodLabels
                {
                    FoodId = 14,
                    LabelId = 2
                },
                new FoodLabels
                {
                    FoodId = 14,
                    LabelId = 6
                },
                new FoodLabels
                {
                    FoodId = 15,
                    LabelId = 6
                },
                new FoodLabels
                {
                    FoodId = 16,
                    LabelId = 2
                },
                new FoodLabels
                {
                    FoodId = 16,
                    LabelId = 6
                }
            );

            modelBuilder.Entity<TableStatus>().HasData(
                new TableStatus
                {
                    Id = 1,
                    Status = "Available"
                },
                new TableStatus
                {
                    Id = 2,
                    Status = "Serving"
                },
                new TableStatus
                {
                    Id = 3,
                    Status = "Booked"
                }
            );

            modelBuilder.Entity<Table>().HasData(
                new Table
                {
                    Id = Guid.Parse("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb"),
                    Name = "Bàn 1",
                    StatusId = (int)TableStatusId.Available
                },
                new Table
                {
                    Id = Guid.Parse("24421c43-7ce9-49f9-b279-545130db8777"),
                    Name = "Bàn 2",
                    StatusId = (int)TableStatusId.Available
                },
                new Table
                {
                    Id = Guid.Parse("72d44212-da44-4735-9846-af8e859c2086"),
                    Name = "Bàn 3",
                    StatusId = (int)TableStatusId.Available
                },
                new Table
                {
                    Id = Guid.Parse("a6c5a1d6-1942-48fc-9eca-1b5e9499ba6d"),
                    Name = "Bàn 4",
                    StatusId = (int)TableStatusId.Available
                },
                new Table
                {
                    Id = Guid.Parse("b9da28be-79af-4258-8cd7-c608c5fa2d8c"),
                    Name = "Bàn 5",
                    StatusId = (int)TableStatusId.Available
                },
                new Table
                {
                    Id = Guid.Parse("464d6381-2f42-4d17-9402-b4fb1728623e"),
                    Name = "Bàn 6",
                    StatusId = (int)TableStatusId.Available
                },
                new Table
                {
                    Id = Guid.Parse("79709257-f504-4186-aea9-d87a316ff42e"),
                    Name = "Bàn 7",
                    StatusId = (int)TableStatusId.Available
                },
                new Table
                {
                    Id = Guid.Parse("00d6469a-ec3c-4e59-ad00-b2ddb9e34021"),
                    Name = "Bàn 8",
                    StatusId = (int)TableStatusId.Available
                },
                new Table
                {
                    Id = Guid.Parse("42faf975-c839-4282-a42c-4df9963c3d4c"),
                    Name = "Bàn 9",
                    StatusId = (int)TableStatusId.Available
                },
                new Table
                {
                    Id = Guid.Parse("f63c6d7a-7d37-4a06-a80c-a311424eac59"),
                    Name = "Bàn 10",
                    StatusId = (int)TableStatusId.Available
                },
                new Table
                {
                    Id = Guid.Parse("cca0bf6c-af6e-4c37-8636-db7a562bb57e"),
                    Name = "Bàn 11",
                    StatusId = (int)TableStatusId.Available
                },
                new Table
                {
                    Id = Guid.Parse("9e4241f8-ad17-48c4-8f49-9bb8607285c4"),
                    Name = "Bàn 12",
                    StatusId = (int)TableStatusId.Available
                }
            );

            modelBuilder.Entity<OrderStatus>().HasData(
                new OrderStatus
                {
                    Id = (int)OrderStatusId.Pending,
                    Status = "Pending"
                },
                new OrderStatus
                {
                    Id = (int)OrderStatusId.Cooking,
                    Status = "Cooking"
                },
                new OrderStatus
                {
                    Id = (int)OrderStatusId.Serving,
                    Status = "Serving"
                },
                new OrderStatus
                {
                    Id = (int)OrderStatusId.Finished,
                    Status = "Finished"
                }
            );

            modelBuilder.Entity<FoodOrderStatus>().HasData(
                new FoodOrderStatus
                {
                    Id = (int)FoodOrderStatusId.Uncooked,
                    Status = "Uncooked"
                },
                new FoodOrderStatus
                {
                    Id = (int)FoodOrderStatusId.Cooking,
                    Status = "Cooking"
                },
                new FoodOrderStatus
                {
                    Id = (int)FoodOrderStatusId.Cooked,
                    Status = "Cooked"
                }
            );

            modelBuilder.Entity<PaymentMethod>().HasData(
                new PaymentMethod
                {
                    Id = (int)PaymentMethodId.Cash,
                    Method = "Cash"
                },
                new PaymentMethod
                {
                    Id = (int)PaymentMethodId.Banking,
                    Method = "Banking"
                },
                new PaymentMethod
                {
                    Id = (int)PaymentMethodId.CreditCard,
                    Method = "CreditCard"
                }
            );
        }
    }
}

