using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.Infrastructure.Enums;

namespace FR.UnitTest
{
    public static class SeedData
    {
        public static void Seed(this DBContext context)
        {
            context.Bills.AddRange(GetBills());
            context.Feedbacks.AddRange(GetFeedbacks());
            context.Foods.AddRange(GetFoods());
            context.FoodCategories.AddRange(GetFoodCategories());
            context.FoodLabels.AddRange(GetFoodLabels());
            context.FoodOrder.AddRange(GetFoodOrders());
            context.FoodOrderStatus.AddRange(GetFoodOrderStatuses());
            context.Labels.AddRange(GetLabels());
            context.Orders.AddRange(GetOrders());
            context.OrderStatus.AddRange(GetOrderStatuses());
            context.PaymentMethods.AddRange(GetPaymentMethods());
            context.Tables.AddRange(GetTables());
            context.TableStatus.AddRange(GetTableStatuses());
            context.SaveChanges();
        }

        private static ICollection<FoodCategory> GetFoodCategories()
        {
            return new List<FoodCategory>
            {
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
            };
        }
        private static ICollection<Labels> GetLabels()
        {
            return new List<Labels>
            {
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
            };
        }
        private static ICollection<Food> GetFoods()
        {
            return new List<Food>
            {
                // Món khai vị
                new Food
                {
                    Id = 1,
                    Name = "BIG BEERFEST SAUSAGES",
                    Description = "Xúc xích cỡ lớn 300g với đồ muối chua",
                    ImageUrl = "big-beerfest-bausages.jpg",
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
                    ImageUrl = "garlic-bread.jpg",
                    UnitPrice = 30000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    FoodCategoryId = 1
                },

                // Món chính
                new Food
                {
                    Id = 3,
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
                    Id = 4,
                    Name = "AUS RIB EYE MB7/8",
                    ImageUrl = "aus-rib-eye-mb7-8.jpg",
                    Description = "Thăn Flank Wagyu MB7/8 250g",
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    Quantity = 100,
                    FoodCategoryId = 2,
                    UnitPrice = 660000
                },
                new Food
                {
                    Id = 5,
                    Name = "US PRIME RIB EYE",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    FoodCategoryId = 2,
                    UnitPrice = 960000,
                    Description = "Thăn lưng bò Mỹ Prime 500g",
                    ImageUrl = "us-prime-rib-eye.jpg"
                },
                
                // Đồ ăn kèm
                new Food
                {
                    Id = 6,
                    Name = "MASHED POTATO",
                    ImageUrl = "mashed-potato.jpg",
                    FoodCategoryId = 3,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    Quantity = 100,
                    UnitPrice = 30000,
                    Description = "Khoai tây nghiền"
                },
                new Food
                {
                    Id = 7,
                    Name = "ROASTED BABY POTATO",
                    ImageUrl = "roasted-baby-potato.jpg",
                    FoodCategoryId = 3,
                    Description = "Khoai tây bi đút lò",
                    UnitPrice = 30000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime()
                },

                // Đồ uống
                new Food
                {
                    Id = 8,
                    Name = "TAPID WATER",
                    ImageUrl = "tapid-water.jpg",
                    Description = "Nước suối",
                    UnitPrice = 20000,
                    FoodCategoryId = 5,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime()
                },
                new Food
                {
                    Id = 9,
                    Name = "SINH TỐ DƯA HẤU",
                    ImageUrl = "sinh-to-dua-hau.jpg",
                    Description = "Sinh tố dưa hấu",
                    UnitPrice = 50000,
                    FoodCategoryId = 5,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime()
                },
                new Food
                {
                    Id = 10,
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
                    Id = 11,
                    Name = "WARM CHOCOLATE LAVA CAKE",
                    Description = "Bánh chocolate nướng chảy, kem vanilla và dừa sấy",
                    UnitPrice = 50000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    FoodCategoryId = 4,
                    ImageUrl = "warm-chocolate-lava-cake.jpg"
                },
                new Food
                {
                    Id = 12,
                    Name = "ICE CREAM HAAGEN DAZS",
                    ImageUrl = "ice-cream-haagen-dazs.jpg",
                    Description = "Kem Haagen Dazs, chocolate, vanilla, red berries, macha, Maccadmia nut",
                    FoodCategoryId = 4,
                    CreatedAt = new DateTime(2020, 10, 10).ToUniversalTime(),
                    Quantity = 100,
                    UnitPrice = 88000,
                }
            };
        }
        private static ICollection<FoodLabels> GetFoodLabels()
        {
            return new List<FoodLabels>
            {
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
                }
            };
        }
        private static ICollection<TableStatus> GetTableStatuses()
        {
            return new List<TableStatus>
            {
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
            };
        }
        private static ICollection<Table> GetTables()
        {
            return new List<Table>
            {
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
                }
            };
        }
        private static ICollection<OrderStatus> GetOrderStatuses()
        {
            return new List<OrderStatus>
            {
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
            };
        }
        private static ICollection<FoodOrderStatus> GetFoodOrderStatuses()
        {
            return new List<FoodOrderStatus>
            {
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
            };
        }
        private static ICollection<PaymentMethod> GetPaymentMethods()
        {
            return new List<PaymentMethod>
            {
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
            };
        }
        private static ICollection<Feedback> GetFeedbacks()
        {
            return new List<Feedback>
            {
                new Feedback
                {
                    Id = Guid.Parse("f8151278-a0d5-4dac-bb63-4ffdfa62affb"),
                    ServingScore = 5,
                    FoodScore = 5,
                    Comment = "Ngon",
                },
                new Feedback
                {
                    Id = Guid.Parse("085e681b-72c8-4f9f-9335-2537553f9b9d"),
                    ServingScore = 4,
                    FoodScore = 4,
                    Comment = "Đáng để thử",
                },
                new Feedback
                {
                    Id = Guid.Parse("c88323aa-90f0-495b-adf4-c0fac4fc9524"),
                    ServingScore = 3,
                    FoodScore = 2,
                    Comment = "Dở",
                }
            };
        }
        private static ICollection<Bill> GetBills()
        {
            return new List<Bill>
            {
                new Bill
                {
                    Id = Guid.Parse("ca3274c4-0018-430d-9d52-b5d66558fd03"),
                    TotalAmount = 3000000,
                    CreatedAt = new DateTime(2024, 02, 10, 07, 19, 23),
                    FinishedAt = new DateTime(2024, 02, 10, 08, 49, 50),
                    PaymentMethodId = (int)PaymentMethodId.Cash
                },
                new Bill
                {
                    Id = Guid.Parse("022a14ef-f5a5-416d-a8b3-68b20133d897"),
                    TotalAmount = 2000000,
                    CreatedAt = new DateTime(2024, 12, 02, 21, 08, 50),
                    FinishedAt = new DateTime(2024, 12, 02, 21, 47, 12),
                    PaymentMethodId = (int)PaymentMethodId.Banking
                },
                new Bill
                {
                    Id = Guid.Parse("77a97fef-50bb-4fff-bd5c-0ac6164e85fb"),
                    TotalAmount = 1200000,
                    CreatedAt = new DateTime(2024, 12, 02, 17, 10, 20),
                    FinishedAt = new DateTime(2024, 12, 02, 17, 44, 09),
                    PaymentMethodId = (int)PaymentMethodId.CreditCard
                }
            };
        }
        private static ICollection<Order> GetOrders()
        {
            return new List<Order>
            {
                // Bàn 1
                new Order
                {
                    Id = Guid.Parse("11238123-7115-4294-af3a-149a0cd21dba"),
                    TableId = Guid.Parse("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb"),
                    BillId = Guid.Parse("ca3274c4-0018-430d-9d52-b5d66558fd03"),
                    CreatedAt = new DateTime(2024, 02, 10, 07, 19, 23),
                    OrderStatusId = (int)OrderStatusId.Serving
                },
                new Order
                {
                    Id = Guid.Parse("adf29b77-d3fe-4825-b5ba-8e92ff9127a7"),
                    TableId = Guid.Parse("9e4761a1-22d2-4a1e-a0da-e9224d75f6bb"),
                    BillId = Guid.Parse("ca3274c4-0018-430d-9d52-b5d66558fd03"),
                    CreatedAt = new DateTime(2024, 02, 10, 07, 30, 11),
                    OrderStatusId = (int)OrderStatusId.Cooking
                },

                // Bàn 2
                new Order
                {
                    Id = Guid.Parse("d8479b5a-b721-4730-8a8d-359b9ff3268e"),
                    TableId = Guid.Parse("24421c43-7ce9-49f9-b279-545130db8777"),
                    BillId = Guid.Parse("022a14ef-f5a5-416d-a8b3-68b20133d897"),
                    CreatedAt = new DateTime(2024, 12, 02, 21, 08, 50),
                    OrderStatusId = (int)OrderStatusId.Finished
                },
                new Order
                {
                    Id = Guid.Parse("f79fef7f-2dbf-416b-8816-103b98a8c130"),
                    TableId = Guid.Parse("24421c43-7ce9-49f9-b279-545130db8777"),
                    BillId = Guid.Parse("022a14ef-f5a5-416d-a8b3-68b20133d897"),
                    CreatedAt = new DateTime(2024, 12, 02, 21, 20, 50),
                    OrderStatusId = (int)OrderStatusId.Pending
                },

                // Bàn 3
                new Order
                {
                    Id = Guid.Parse("67074714-1dd9-4f57-806e-0e561a8940a2"),
                    BillId = Guid.Parse("77a97fef-50bb-4fff-bd5c-0ac6164e85fb"),
                    TableId = Guid.Parse("72d44212-da44-4735-9846-af8e859c2086"),
                    CreatedAt = new DateTime(2024, 12, 02, 17, 10, 20),
                    OrderStatusId = (int)OrderStatusId.Cooking
                }
            };
        }
        private static ICollection<FoodOrder> GetFoodOrders()
        {
            return new List<FoodOrder>
            {
                new FoodOrder
                {
                    OrderId = Guid.Parse("11238123-7115-4294-af3a-149a0cd21dba"),
                    FoodId = 1,
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooked,
                    Quantity = 1,
                    UnitPrice = 199000,
                    FoodNote = "Không muối",
                    OrderAt = new DateTime(2024, 02, 10, 07, 19, 23)
                },
                new FoodOrder
                {
                    OrderId = Guid.Parse("adf29b77-d3fe-4825-b5ba-8e92ff9127a7"),
                    FoodId = 3,
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooked,
                    Quantity = 3,
                    UnitPrice = 1280000,
                    OrderAt = new DateTime(2024, 02, 10, 07, 19, 23)
                },
                new FoodOrder
                {
                    OrderId = Guid.Parse("adf29b77-d3fe-4825-b5ba-8e92ff9127a7"),
                    FoodId = 4,
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooked,
                    Quantity = 1,
                    UnitPrice = 660000,
                    OrderAt = new DateTime(2024, 02, 10, 07, 30, 11)
                },
                new FoodOrder
                {
                    OrderId = Guid.Parse("adf29b77-d3fe-4825-b5ba-8e92ff9127a7"),
                    FoodId = 10,
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooked,
                    Quantity = 1,
                    UnitPrice = 1200000,
                    OrderAt = new DateTime(2024, 02, 10, 07, 30, 11)
                },
                new FoodOrder{
                    OrderId = Guid.Parse("adf29b77-d3fe-4825-b5ba-8e92ff9127a7"),
                    FoodId = 12,
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooked,
                    Quantity = 2,
                    UnitPrice = 88000,
                    OrderAt = new DateTime(2024, 02, 10, 08, 20, 36)
                },

                new FoodOrder
                {
                    OrderId = Guid.Parse("d8479b5a-b721-4730-8a8d-359b9ff3268e"),
                    FoodId = 5,
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooked,
                    Quantity = 4,
                    UnitPrice = 960000,
                    FoodNote = "Medium rare",
                    OrderAt = new DateTime(2024, 12, 02, 21, 08, 50)
                },
                new FoodOrder
                {
                    OrderId = Guid.Parse("f79fef7f-2dbf-416b-8816-103b98a8c130"),
                    FoodId = 6,
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooked,
                    Quantity = 2,
                    UnitPrice = 30000,
                    OrderAt = new DateTime(2024, 12, 02, 21, 08, 50)
                },
                new FoodOrder
                {
                    OrderId = Guid.Parse("f79fef7f-2dbf-416b-8816-103b98a8c130"),
                    FoodId = 8,
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooked,
                    Quantity = 2,
                    UnitPrice = 20000,
                    OrderAt = new DateTime(2024, 12, 02, 17, 10, 20)
                },

                new FoodOrder
                {
                    OrderId = Guid.Parse("67074714-1dd9-4f57-806e-0e561a8940a2"),
                    FoodId = 1,
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooked,
                    Quantity = 2,
                    UnitPrice = 199000,
                    OrderAt = new DateTime(2024, 12, 02, 17, 10, 20)
                },
                new FoodOrder
                {
                    OrderId = Guid.Parse("67074714-1dd9-4f57-806e-0e561a8940a2"),
                    FoodId = 4,
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooked,
                    Quantity = 1,
                    UnitPrice = 660000,
                    FoodNote = "Rare",
                    OrderAt = new DateTime(2024, 12, 02, 17, 10, 20)
                },
                new FoodOrder
                {
                    OrderId = Guid.Parse("67074714-1dd9-4f57-806e-0e561a8940a2"),
                    FoodId = 9,
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooked,
                    Quantity = 1,
                    UnitPrice = 50000,
                    OrderAt = new DateTime(2024, 12, 02, 17, 10, 20)
                }
            };
        }
    }
}
