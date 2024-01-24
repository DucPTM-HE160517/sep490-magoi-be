using FR.BusinessObjects.Models;
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
                    Category = "Salad",
                },
                new FoodCategory
                {
                    Id = 5,
                    Category = "Soup",
                },
                new FoodCategory
                {
                    Id = 6,
                    Category = "Nước sốt",
                },
                new FoodCategory
                {
                    Id = 7,
                    Category = "Đồ uống"
                },
                new FoodCategory
                {
                    Id = 8,
                    Category = "Món tráng miệng"
                }
            );

            modelBuilder.Entity<Characteristics>().HasData(
                new Characteristics
                {
                    Id = 1,
                    Characteristic = "Món chay"
                },
                new Characteristics
                {
                    Id = 2,
                    Characteristic = "Món nóng"
                },
                new Characteristics
                {
                    Id = 3,
                    Characteristic = "Món lạnh"
                },
                new Characteristics
                {
                    Id = 4,
                    Characteristic = "Món nước"
                },
                new Characteristics
                {
                    Id = 5,
                    Characteristic = "Món nướng"
                },
                new Characteristics
                {
                    Id = 6,
                    Characteristic = "Thức ăn nhanh"
                },
                new Characteristics
                {
                    Id = 7,
                    Characteristic = "Món cay"
                },
                new Characteristics
                {
                    Id = 8,
                    Characteristic = "Dành cho người ăn kiêng"
                },
                new Characteristics
                {
                    Id = 9,
                    Characteristic = "Dành cho người tập gym"
                },
                new Characteristics
                {
                    Id = 10,
                    Characteristic = "Dành cho dịp lễ"
                },
                new Characteristics
                {
                    Id = 11,
                    Characteristic = "Bánh"
                },
                new Characteristics
                {
                    Id = 12,
                    Characteristic = "Kem"
                },
                new Characteristics
                {
                    Id = 13,
                    Characteristic = "Nước ép"
                },
                new Characteristics
                {
                    Id = 14,
                    Characteristic = "Sinh tố"
                },
                new Characteristics
                {
                    Id = 15,
                    Characteristic = "Nước ngọt"
                },
                new Characteristics
                {
                    Id = 16,
                    Characteristic = "Trà"
                },
                new Characteristics
                {
                    Id = 17,
                    Characteristic = "Bia"
                },
                new Characteristics
                {
                    Id = 18,
                    Characteristic = "Rượu vang"
                },
                new Characteristics
                {
                    Id = 19,
                    Characteristic = "Nước chấm"
                },
                new Characteristics
                {
                    Id = 20,
                    Characteristic = "Món chiên rán"
                },
                new Characteristics
                {
                    Id = 21,
                    Characteristic = "Bò tiêu chuẩn"
                },
                new Characteristics
                {
                    Id = 22,
                    Characteristic = "Bò cao cấp"
                },
                new Characteristics
                {
                    Id = 23,
                    Characteristic = "Bò thượng hạng"
                },
                new Characteristics
                {
                    Id = 24,
                    Characteristic = "Hải sản"
                },
                new Characteristics
                {
                    Id = 25,
                    Characteristic = "Thịt cừu"
                },
                new Characteristics
                {
                    Id = 26,
                    Characteristic = "Thịt lợn"
                },
                new Characteristics
                {
                    Id = 27,
                    Characteristic = "Thịt gà"
                },
                new Characteristics
                {
                    Id = 28,
                    Characteristic = "Thịt vịt"
                },
                new Characteristics
                {
                    Id = 29,
                    Characteristic = "Trái cây"
                }
            );

            modelBuilder.Entity<Food>().HasData(
                // Món khai vị
                new Food
                {
                    Id = 1,
                    Name = "BIG BEERFEST SAUSAGES",
                    Description = "Xúc xích cỡ lớn 300g với đồ muối chua",
                    ImageUrl = "big-beerfest-bausages.jpg",
                    Price = 199000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 1
                },
                new Food
                {
                    Id = 2,
                    Name = "GRILLED GERMAN SAUSAGES",
                    Description = "Xúc xích Đức nướng ăn kèm salad rau tổng hợp",
                    ImageUrl = "grilled-german-gausages.jpg",
                    Price = 136000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 1
                },
                new Food
                {
                    Id = 3,
                    Name = "GARLIC BREAD",
                    Description = "Bánh mì bơ tỏi",
                    ImageUrl = "garlic-bread.jpg",
                    Price = 30000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 1
                },
                new Food
                {
                    Id = 4,
                    Name = "FRENCH FRIED",
                    Description = "Khoai tây chiên",
                    ImageUrl = "french-fried.jpg",
                    Price = 50000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 1
                },
                new Food
                {
                    Id = 5,
                    Name = "CHICKEN WINGS",
                    Description = "Cánh gà nướng BBQ ăn kèm Salad, khoai tây chiên (2 cánh)",
                    ImageUrl = "chicken-wings.jpg",
                    Price = 86000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 1
                },
                new Food
                {
                    Id = 6,
                    Name = "BEER BATTER FRIES",
                    ImageUrl = "beer-batter-fries.jpg",
                    Description = "Đĩa tổng hợp các loại khoai chiên",
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 1,
                    Price = 99000,
                    Quantity = 100
                },
                new Food
                {
                    Id = 7,
                    Name = "PAN SEARED FOIE-GRAS",
                    Description = "Gan Ngỗng áp chảo cùng Mứt, sốt xoài và bánh mỳ Pháp nướng",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 1,
                    ImageUrl = "pan-seared-foie-gras.jpg",
                    Price = 196000
                },
                new Food
                {
                    Id = 8,
                    Name = "MARINATED SPICY OLIVES",
                    Description = "Quả ô-liu trộn cay 100gr",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 1,
                    ImageUrl = "marinated-spicy-olives.jpg",
                    Price = 86000
                },
                new Food
                {
                    Id = 9,
                    Name = "SMOKED DUCK",
                    Description = "Lườn vịt xông khói với Mayonnaise mutat Dijon",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 1,
                    ImageUrl = "smoked-duck.jpg",
                    Price = 155000
                },
                new Food
                {
                    Id = 10,
                    Name = "BEEF CARPACCIO",
                    Description = "Bò tái kiểu Ý cùng rau rocket, phô mai bào",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 1,
                    ImageUrl = "beef-carpaccio.jpg",
                    Price = 180000
                },
                new Food
                {
                    Id = 11,
                    Name = "IBERICO DE CEBO",
                    Description = "Đùi lợn Tây Ban Nha Cebo cắt lát với dưa lưới và rau arugula",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 1,
                    ImageUrl = "iberico-de-cebo.jpg",
                    Price = 436000
                },
                new Food
                {
                    Id = 12,
                    Name = "FRENCH DUCK RILLETTE",
                    ImageUrl = "french-duck-rillette.jpg",
                    Description = "Patê thịt Vịt phục vụ cùng mứt hoa quả và bánh mỳ Pháp",
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100,
                    FoodCategoryId = 1,
                    Price = 136000
                },
                new Food
                {
                    Id = 13,
                    Name = "HOUSEMADE SMOKED SALMON",
                    ImageUrl = "housemade-smoked-salmon.jpg",
                    Description = "Cá hồi xông khói nhà làm với bánh mỳ Pháp nướng, kem phô mai và rau cải xoăn",
                    Price = 166000,
                    FoodCategoryId = 1,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },

                // Món chính
                new Food
                {
                    Id = 14,
                    Name = "AUS RIB EYE MB4/5",
                    Description = "Thăn lưng Wagyu MB4/5 250g",
                    ImageUrl = "aus-rib-eye-mb4-5.jpg",
                    Price = 1280000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 2
                },
                new Food
                {
                    Id = 15,
                    Name = "AUS RIB EYE MB7/8",
                    ImageUrl = "aus-rib-eye-mb7-8.jpg",
                    Description = "Thăn Flank Wagyu MB7/8 250g",
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100,
                    FoodCategoryId = 2,
                    Price = 660000
                },
                new Food
                {
                    Id = 16,
                    Name = "AUS HANGING TENDER MB3",
                    ImageUrl = "aus-hanging-tender-mb3.jpg",
                    Description = "Thǎn \"Mắc Áo\" Wagyu MB3 250g",
                    Price = 600000,
                    FoodCategoryId = 2,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100
                },
                new Food
                {
                    Id = 17,
                    Name = "US PRIME RIB EYE",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 2,
                    Price = 960000,
                    Description = "Thăn lưng bò Mỹ Prime 500g",
                    ImageUrl = "us-prime-rib-eye.jpg"
                },
                new Food
                {
                    Id = 18,
                    Name = "AUS BLACK ANGUS T-BONE",
                    ImageUrl = "aus-black-angus-t-bone.jpg",
                    Description = "Thăn Bò Angus chữ T Úc 700g",
                    Price = 1160000,
                    FoodCategoryId = 2,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100
                },
                new Food
                {
                    Id = 19,
                    Name = "US TENDERLOIN",
                    ImageUrl = "us-tenderloin.jpg",
                    Description = "Thăn nội bò Mỹ 250g",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 2,
                    Price = 560000
                },
                new Food
                {
                    Id = 20,
                    Name = "US RIB EYE",
                    ImageUrl = "us-rib-eye.jpg",
                    Description = "Thăn lưng bò Mỹ 350g",
                    Price = 596000,
                    FoodCategoryId = 2,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100
                },
                new Food
                {
                    Id = 21,
                    Name = "US STRIPLOIN",
                    ImageUrl = "us-striploin.jpg",
                    Description = "Thăn ngoại bò Mỹ 350g",
                    Price = 386000,
                    FoodCategoryId = 2,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100
                },
                new Food
                {
                    Id = 22,
                    Name = "CANADA TENDERLOIN",
                    ImageUrl = "canada-tenderloin.jpg",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 2,
                    Price = 386000,
                    Description = "Thăn nội bò Canada 200g",
                },
                new Food
                {
                    Id = 23,
                    Name = "AUS RIB EYE",
                    ImageUrl = "aus-rib-eye.jpg",
                    Description = "Thăn lưng bò Úc 250g",
                    Price = 246000,
                    FoodCategoryId = 2,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },

                // Đồ ăn kèm
                new Food
                {
                    Id = 24,
                    Name = "MASHED POTATO",
                    ImageUrl = "mashed-potato.jpg",
                    FoodCategoryId = 3,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100,
                    Price = 30000,
                    Description = "Khoai tây nghiền"
                },
                new Food
                {
                    Id = 25,
                    Name = "SAUTÉ MUSHROOM",
                    ImageUrl = "saute-mushroom.jpg",
                    FoodCategoryId = 3,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100,
                    Price = 30000,
                    Description = "Nấm xào"
                },
                new Food
                {
                    Id = 26,
                    Name = "ROASTED BABY POTATO",
                    ImageUrl = "roasted-baby-potato.jpg",
                    FoodCategoryId = 3,
                    Description = "Khoai tây bi đút lò",
                    Price = 30000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },

                // Món chính (thịt khác)
                new Food
                {
                    Id = 27,
                    Name = "ROASTED LAMB LEG 2KG",
                    ImageUrl = "roasted-lamb-leg-2kg.jpg",
                    Description = "Đùi cừu nướng 2kg với thảo mộc",
                    Price = 2600000,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 2,
                    Quantity = 50
                },
                new Food
                {
                    Id = 28,
                    Name = "HERBS CRUSTED AUS LAMB RACK",
                    ImageUrl = "herbs-crusted-aus-lamb-rack.jpg",
                    Description = "Sườn cừu Úc thượng hạng nướng với thảo mộc",
                    Quantity = 50,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 2,
                    Price = 580000
                },
                new Food
                {
                    Id = 29,
                    Name = "DUCK CONFIT",
                    ImageUrl = "duck-confit.jpg",
                    Price = 246000,
                    Description = "Đùi vịt nấu chậm ăn kèm với khoai Roti, rau củ đút lò và sốt Gravy",
                    FoodCategoryId = 2,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 30,
                    Name = "GRILLED PORK RIB BBQ",
                    ImageUrl = "grilled-pork-rib-bbq.jpg",
                    Description = "Sườn lợn nướng BBQ (1,1 kg) với salad và khoai tây chiên",
                    Price = 660000,
                    FoodCategoryId = 2,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },

                // Món chính (cá)
                new Food
                {
                    Id = 31,
                    Name = "TUNA STEAK",
                    Description = "Cá ngừ nướng với sốt mayonnaise",
                    ImageUrl = "tuna-steak.jpg",
                    Price = 166000,
                    FoodCategoryId = 2,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 50
                },
                new Food
                {
                    Id = 32,
                    Name = "SEARED SALMON FILLET",
                    ImageUrl = "seared-salmon-fillet.jpg",
                    Quantity = 50,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 2,
                    Price = 226000,
                    Description = "Cá hồi áp chảo cùng cà rốt bào, cà rốt nghiền ăn với các lựa chọn sốt Cam Cà rốt, Kem Mù tạt"
                },

                // Salad
                new Food
                {
                    Id = 33,
                    Name = "SMOKED SALMON SALAD",
                    ImageUrl = "smoked-salmon-salad.jpg",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 4,
                    Price = 166000,
                    Description = "Salad cá hồi xông khói, xà lách, cải mầm, rau rocket, bánh mỳ giòn, sốt dầu dấm"
                },
                new Food
                {
                    Id = 34,
                    Name = "MIX GREEN SALAD",
                    ImageUrl = "mix-green-salad.jpg",
                    Description = "Sa Lát rau xanh tổng hợp với lựa chọn các sốt dấm Balsamic, sốt chanh leo, sốt Thousand Island",
                    Price = 66000,
                    FoodCategoryId = 4,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 35,
                    Name = "TROPICAL FRUIT SALAD",
                    ImageUrl = "tropical-fruit-salad.jpg",
                    Description = "Salad trái cây với hạt Chia và các lựa chọn sốt sữa chua chanh leo, sốt Thousand Island",
                    Price = 80000,
                    FoodCategoryId = 4,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100
                },
                new Food
                {
                    Id = 36,
                    Name = "ORANGE SALAD WITH SMOKE DUCK",
                    ImageUrl = "orange-salad-with-smoke-duck.jpg",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 4,
                    Price = 106000,
                    Description = "Lườn vịt xông khói xà lách, rau rocket, hoa quả, cam và sốt dầm Ý"
                },
                new Food
                {
                    Id = 37,
                    Name = "OCEAN SEAWEED SALAD",
                    ImageUrl = "ocean-seaweed-salad.jpg",
                    Description = "Salad Wakame với dưa chuột bào, rong nho biển, trứng cua sốt mè",
                    Price = 98000,
                    FoodCategoryId = 4,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100
                },
                new Food
                {
                    Id = 38,
                    Name = "CAESAR SALAD",
                    ImageUrl = "caesar-salad.jpg",
                    Description = "Salad ăn kèm trứng cút, ba rọi xông khói, phô mai bào, bánh mỳ giòn và sốt Caesar",
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 4,
                    Price = 86000
                },
                new Food
                {
                    Id = 39,
                    Name = "NICOISE SALAD",
                    ImageUrl = "nicoise-salad.jpg",
                    Description = "Salad cá ngừ tươi cùng với khoai tây bi, trứng cút, đậu Pháp, củ cải đỏ, cà chua sấy và sốt dầu dấm",
                    Price = 126000,
                    FoodCategoryId = 4,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100
                },

                // Soup
                new Food
                {
                    Id = 40,
                    Name = "CREAMY MUSHROOM SOUP",
                    ImageUrl = "creamy-mushroom-soup.jpg",
                    Description = "Súp nấm kem",
                    Price = 80000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 5
                },
                new Food
                {
                    Id = 41,
                    Name = "CREAMY PUMPKIN SOUP",
                    ImageUrl = "creamy-pumpkin-soup.jpg",
                    FoodCategoryId = 5,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100,
                    Price = 60000,
                    Description = "Súp kem bí đỏ kèm hạt bí nướng giòn, kem chua"
                },

                // Nước sốt
                new Food
                {
                    Id = 42,
                    Name = "RED WINE SAUCE",
                    FoodCategoryId = 6,
                    Description = "Sốt vang đỏ",
                    ImageUrl = "red-wine-sauce.jpg",
                    Price = 25000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 43,
                    Name = "PEPPER SAUCE",
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100,
                    Description = "Sốt tiêu",
                    Price = 25000,
                    ImageUrl = "pepper-sauce.jpg",
                    FoodCategoryId = 6
                },
                new Food
                {
                    Id = 44,
                    Name = "MUSHROOM SAUCE",
                    ImageUrl = "mushroom-sauce.jpg",
                    Description = "Sốt nấm",
                    Price = 25000,
                    FoodCategoryId = 6,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 45,
                    Name = "GARLIC BUTTER SAUCE",
                    ImageUrl = "garlic-butter-sauce.jpg",
                    Description = "Sốt bơ tỏi",
                    Price = 25000,
                    FoodCategoryId = 6,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 46,
                    Name = "MUSTARD SAUCE",
                    ImageUrl = "mustard-sauce.jpg",
                    Description = "Sốt mù tạt",
                    Price = 25000,
                    FoodCategoryId = 6,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 47,
                    Name = "BBQ SAUCE",
                    FoodCategoryId = 6,
                    ImageUrl = "bbq-sauce.jpg",
                    Price = 25000,
                    Quantity = 100,
                    Description = "Sốt BBQ",
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 48,
                    Name = "CREAMY BLUE CHEESE SAUCE",
                    ImageUrl = "creamy-blue-cheese-sauce.jpg",
                    Description = "Sốt phô mai xanh",
                    Price = 25000,
                    FoodCategoryId = 6,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 49,
                    Name = "TERIYAKI SAUCE",
                    ImageUrl = "teriyaki-sauce.jpg",
                    Description = "Sót Teriyaki",
                    Price = 25000,
                    FoodCategoryId = 6,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },

                // Đồ uống
                new Food
                {
                    Id = 50,
                    Name = "COCA COLA",
                    ImageUrl = "coca-cola.jpg",
                    Description = "Coca Cola",
                    Price = 30000,
                    FoodCategoryId = 7,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 51,
                    Name = "TAPID WATER",
                    ImageUrl = "tapid-water.jpg",
                    Description = "Nước suối",
                    Price = 20000,
                    FoodCategoryId = 7,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 52,
                    Name = "SINH TỐ DƯA HẤU",
                    ImageUrl = "sinh-to-dua-hau.jpg",
                    Description = "Sinh tố dưa hấu",
                    Price = 50000,
                    FoodCategoryId = 7,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 53,
                    Name = "FANTA",
                    ImageUrl = "fanta.jpg",
                    Description = "Fanta",
                    Price = 30000,
                    FoodCategoryId = 7,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 54,
                    Name = "SPRITE",
                    ImageUrl = "sprite.jpg",
                    Description = "Sprite",
                    Price = 30000,
                    FoodCategoryId = 7,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 55,
                    Name = "BAROLA",
                    ImageUrl = "barola.jpg",
                    Description = "Vang đỏ Barolo",
                    Price = 1200000,
                    FoodCategoryId = 7,
                    Quantity = 20,
                    CreatedAt = new DateTime(2020, 10, 10)
                },
                new Food
                {
                    Id = 56,
                    Name = "CHATEAU LEOVILLE POYFERRE",
                    ImageUrl = "chateau-leoville-poyferre.jpg",
                    FoodCategoryId = 7,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Description = "Vang đỏ Chateau Leoville Poyferre",
                    Price = 1400000,
                    Quantity = 20
                },
                new Food
                {
                    Id = 57,
                    Name = "MALBEC",
                    Quantity = 20,
                    Price = 1700000,
                    Description = "Vang đỏ Malbec",
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 7,
                    ImageUrl = "malbec.jpg"
                },

                // Món tráng miệng
                new Food
                {
                    Id = 58,
                    Name = "GINGER CREAM BRULEE",
                    Description = "Kem cháy gừng cùng với bánh quy giòn",
                    ImageUrl = "ginger-cream-brulee.jpg",
                    FoodCategoryId = 8,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100,
                    Price = 46000
                },
                new Food
                {
                    Id = 59,
                    Name = "WARM CHOCOLATE LAVA CAKE",
                    Description = "Bánh chocolate nướng chảy, kem vanilla và dừa sấy",
                    Price = 50000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 8,
                    ImageUrl = "warm-chocolate-lava-cake.jpg"
                },
                new Food
                {
                    Id = 60,
                    Name = "SEASONAL FRESH FRUIT PLATER",
                    ImageUrl = "seasonal-fresh-fruit-plater.jpg",
                    FoodCategoryId = 8,
                    Description = "Đĩa trái cây theo mùa",
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100,
                    Price = 135000,
                },
                new Food
                {
                    Id = 61,
                    Name = "PANDAN PANNA-COTTA",
                    ImageUrl = "pandan-panna-cotta.jpg",
                    Price = 35000,
                    Quantity = 100,
                    CreatedAt = new DateTime(2020, 10, 10),
                    FoodCategoryId = 8,
                    Description = "Bánh kem Ý hương lá nếp cùng chocolate nướng giòn và kem đánh bông",
                },
                new Food
                {
                    Id = 62,
                    Name = "ICE CREAM HAAGEN DAZS",
                    ImageUrl = "ice-cream-haagen-dazs.jpg",
                    Description = "Kem Haagen Dazs, chocolate, vanilla, red berries, macha, Maccadmia nut",
                    FoodCategoryId = 8,
                    CreatedAt = new DateTime(2020, 10, 10),
                    Quantity = 100,
                    Price = 88000,
                }
            );

            modelBuilder.Entity<FoodCharacteristics>().HasData(
                new FoodCharacteristics
                {
                    FoodId = 1,
                    CharacteristicId = 2
                },
                new FoodCharacteristics
                {
                    FoodId = 1,
                    CharacteristicId = 6
                },
                new FoodCharacteristics
                {
                    FoodId = 1,
                    CharacteristicId = 20
                },

                new FoodCharacteristics
                {
                    FoodId = 2,
                    CharacteristicId = 2
                },
                new FoodCharacteristics
                {
                    FoodId = 2,
                    CharacteristicId = 6
                },
                new FoodCharacteristics
                {
                    FoodId = 2,
                    CharacteristicId = 20
                },

                new FoodCharacteristics
                {
                    FoodId = 3,
                    CharacteristicId = 2
                },

                new FoodCharacteristics
                {
                    FoodId = 4,
                    CharacteristicId = 2
                },
                new FoodCharacteristics
                {
                    FoodId = 4,
                    CharacteristicId = 6
                },
                new FoodCharacteristics
                {
                    FoodId = 4,
                    CharacteristicId = 20
                },

                new FoodCharacteristics
                {
                    FoodId = 5,
                    CharacteristicId = 2
                },
                new FoodCharacteristics
                {
                    FoodId = 5,
                    CharacteristicId = 5
                },
                new FoodCharacteristics
                {
                    FoodId = 5,
                    CharacteristicId = 6
                },
                new FoodCharacteristics
                {
                    FoodId = 5,
                    CharacteristicId = 27
                },

                new FoodCharacteristics
                {
                    FoodId = 6,
                    CharacteristicId = 2
                },
                new FoodCharacteristics
                {
                    FoodId = 6,
                    CharacteristicId = 6
                },
                new FoodCharacteristics
                {
                    FoodId = 6,
                    CharacteristicId = 20
                },

                new FoodCharacteristics
                {
                    FoodId = 7,
                    CharacteristicId = 2
                },

                new FoodCharacteristics
                {
                    FoodId = 8,
                    CharacteristicId = 7
                },
                new FoodCharacteristics
                {
                    FoodId = 8,
                    CharacteristicId = 8
                },
                new FoodCharacteristics
                {
                    FoodId = 8,
                    CharacteristicId = 29
                },

                new FoodCharacteristics
                {
                    FoodId = 9,
                    CharacteristicId = 2
                },
                new FoodCharacteristics
                {
                    FoodId = 9,
                    CharacteristicId = 7
                },

                new FoodCharacteristics
                {
                    FoodId = 10,
                    CharacteristicId = 3
                },
                new FoodCharacteristics
                {
                    FoodId = 10,
                    CharacteristicId = 21
                },

                new FoodCharacteristics
                {
                    FoodId = 11,
                    CharacteristicId = 26
                },

                new FoodCharacteristics
                {
                    FoodId = 12,
                    CharacteristicId = 3
                },

                new FoodCharacteristics
                {
                    FoodId = 13,
                    CharacteristicId = 3
                },
                new FoodCharacteristics
                {
                    FoodId = 13,
                    CharacteristicId = 24
                },

                new FoodCharacteristics
                {
                    FoodId = 14,
                    CharacteristicId = 23
                },

                new FoodCharacteristics
                {
                    FoodId = 15,
                    CharacteristicId = 23
                },

                new FoodCharacteristics
                {
                    FoodId = 16,
                    CharacteristicId = 23
                },

                new FoodCharacteristics
                {
                    FoodId = 17,
                    CharacteristicId = 23
                },

                new FoodCharacteristics
                {
                    FoodId = 18,
                    CharacteristicId = 23
                },

                new FoodCharacteristics
                {
                    FoodId = 19,
                    CharacteristicId = 22
                },

                new FoodCharacteristics
                {
                    FoodId = 20,
                    CharacteristicId = 22
                },

                new FoodCharacteristics
                {
                    FoodId = 21,
                    CharacteristicId = 21
                },

                new FoodCharacteristics
                {
                    FoodId = 22,
                    CharacteristicId = 21
                },

                new FoodCharacteristics
                {
                    FoodId = 23,
                    CharacteristicId = 21
                },

                new FoodCharacteristics
                {
                    FoodId = 24,
                    CharacteristicId = 1
                },
                new FoodCharacteristics
                {
                    FoodId = 24,
                    CharacteristicId = 2
                },
                new FoodCharacteristics
                {
                    FoodId = 24,
                    CharacteristicId = 8
                },

                new FoodCharacteristics
                {
                    FoodId = 25,
                    CharacteristicId = 1
                },
                new FoodCharacteristics
                {
                    FoodId = 25,
                    CharacteristicId = 8
                },

                new FoodCharacteristics
                {
                    FoodId = 26,
                    CharacteristicId = 1
                },
                new FoodCharacteristics
                {
                    FoodId = 26,
                    CharacteristicId = 8
                },

                new FoodCharacteristics
                {
                    FoodId = 27,
                    CharacteristicId = 5
                },
                new FoodCharacteristics
                {
                    FoodId = 27,
                    CharacteristicId = 25
                },

                new FoodCharacteristics
                {
                    FoodId = 28,
                    CharacteristicId = 5
                },
                new FoodCharacteristics
                {
                    FoodId = 28,
                    CharacteristicId = 25
                },

                new FoodCharacteristics
                {
                    FoodId = 29,
                    CharacteristicId = 28
                },

                new FoodCharacteristics
                {
                    FoodId = 30,
                    CharacteristicId = 5
                },
                new FoodCharacteristics
                {
                    FoodId = 30,
                    CharacteristicId = 26
                },

                new FoodCharacteristics
                {
                    FoodId = 31,
                    CharacteristicId = 5
                },
                new FoodCharacteristics
                {
                    FoodId = 31,
                    CharacteristicId = 24
                },

                new FoodCharacteristics
                {
                    FoodId = 32,
                    CharacteristicId = 5
                },
                new FoodCharacteristics
                {
                    FoodId = 32,
                    CharacteristicId = 24
                },

                new FoodCharacteristics
                {
                    FoodId = 33,
                    CharacteristicId = 24
                },

                new FoodCharacteristics
                {
                    FoodId = 34,
                    CharacteristicId = 1
                },
                new FoodCharacteristics
                {
                    FoodId = 34,
                    CharacteristicId = 8
                },

                new FoodCharacteristics
                {
                    FoodId = 35,
                    CharacteristicId = 1
                },
                new FoodCharacteristics
                {
                    FoodId = 35,
                    CharacteristicId = 8
                },

                new FoodCharacteristics
                {
                    FoodId = 36,
                    CharacteristicId = 28
                },

                new FoodCharacteristics
                {
                    FoodId = 37,
                    CharacteristicId = 1
                },
                new FoodCharacteristics
                {
                    FoodId = 37,
                    CharacteristicId = 8
                },

                new FoodCharacteristics
                {
                    FoodId = 38,
                    CharacteristicId = 8
                },
                new FoodCharacteristics
                {
                    FoodId = 38,
                    CharacteristicId = 26
                },

                new FoodCharacteristics
                {
                    FoodId = 39,
                    CharacteristicId = 1
                },

                new FoodCharacteristics
                {
                    FoodId = 40,
                    CharacteristicId = 4
                },

                new FoodCharacteristics
                {
                    FoodId = 41,
                    CharacteristicId = 4
                },

                new FoodCharacteristics
                {
                    FoodId = 42,
                    CharacteristicId = 19
                },

                new FoodCharacteristics
                {
                    FoodId = 43,
                    CharacteristicId = 19
                },

                new FoodCharacteristics
                {
                    FoodId = 44,
                    CharacteristicId = 19
                },

                new FoodCharacteristics
                {
                    FoodId = 45,
                    CharacteristicId = 19
                },

                new FoodCharacteristics
                {
                    FoodId = 46,
                    CharacteristicId = 19
                },

                new FoodCharacteristics
                {
                    FoodId = 47,
                    CharacteristicId = 19
                },

                new FoodCharacteristics
                {
                    FoodId = 48,
                    CharacteristicId = 19
                },

                new FoodCharacteristics
                {
                    FoodId = 49,
                    CharacteristicId = 19
                },

                new FoodCharacteristics
                {
                    FoodId = 50,
                    CharacteristicId = 15
                },

                new FoodCharacteristics
                {
                    FoodId = 51,
                    CharacteristicId = 15
                },

                new FoodCharacteristics
                {
                    FoodId = 52,
                    CharacteristicId = 14
                },

                new FoodCharacteristics
                {
                    FoodId = 53,
                    CharacteristicId = 15
                },

                new FoodCharacteristics
                {
                    FoodId = 54,
                    CharacteristicId = 15
                },

                new FoodCharacteristics
                {
                    FoodId = 55,
                    CharacteristicId = 18
                },

                new FoodCharacteristics
                {
                    FoodId = 56,
                    CharacteristicId = 18
                },

                new FoodCharacteristics
                {
                    FoodId = 57,
                    CharacteristicId = 18
                },

                new FoodCharacteristics
                {
                    FoodId = 58,
                    CharacteristicId = 3
                },
                new FoodCharacteristics
                {
                    FoodId = 58,
                    CharacteristicId = 12
                },

                new FoodCharacteristics
                {
                    FoodId = 59,
                    CharacteristicId = 11
                },

                new FoodCharacteristics
                {
                    FoodId = 60,
                    CharacteristicId = 1
                },
                new FoodCharacteristics
                {
                    FoodId = 60,
                    CharacteristicId = 8
                },
                new FoodCharacteristics
                {
                    FoodId = 60,
                    CharacteristicId = 29
                },

                new FoodCharacteristics
                {
                    FoodId = 61,
                    CharacteristicId = 11
                },

                new FoodCharacteristics
                {
                    FoodId = 62,
                    CharacteristicId = 12
                }
            );

            modelBuilder.Entity<TableStatus>().HasData(
                new TableStatus
                {
                    Id = 1,
                    Status = "Trống"
                },
                new TableStatus
                {
                    Id = 2,
                    Status = "Đang phục vụ"
                },
                new TableStatus
                {
                    Id = 3,
                    Status = "Đã đặt trước"
                }
            );

            modelBuilder.Entity<Table>().HasData(
                new Table
                {
                    Id = 1,
                    Name = "Bàn 1",
                    StatusId = 2
                },
                new Table
                {
                    Id = 2,
                    Name = "Bàn 2",
                    StatusId = 2
                },
                new Table
                {
                    Id = 3,
                    Name = "Bàn 3",
                    StatusId = 2
                },
                new Table
                {
                    Id = 4,
                    Name = "Bàn 4",
                    StatusId = 2
                },
                new Table
                {
                    Id = 5,
                    Name = "Bàn 5",
                    StatusId = 2
                },
                new Table
                {
                    Id = 6,
                    Name = "Bàn 6",
                    StatusId = 1
                },
                new Table
                {
                    Id = 7,
                    Name = "Bàn 7",
                    StatusId = 1
                },
                new Table
                {
                    Id = 8,
                    Name = "Bàn 8",
                    StatusId = 1
                },
                new Table
                {
                    Id = 9,
                    Name = "Bàn 9",
                    StatusId = 1
                },
                new Table
                {
                    Id = 10,
                    Name = "Bàn 10",
                    StatusId = 3
                },
                new Table
                {
                    Id = 11,
                    Name = "Bàn 11",
                    StatusId = 3
                },
                new Table
                {
                    Id = 12,
                    Name = "Bàn 12",
                    StatusId = 3
                }
            );

            modelBuilder.Entity<Bill>().HasData(
                new Bill
                {
                    Id = 1,
                    CreatedAt = new DateTime(2023, 10, 10),
                    TotalAmount = 4000000,
                },
                new Bill
                {
                    Id = 2,
                    CreatedAt = new DateTime(2023, 10, 12),
                    TotalAmount = 563000,
                },
                new Bill
                {
                    Id = 3,
                    CreatedAt = new DateTime(2023, 10, 19),
                    TotalAmount = 7020000,
                },
                new Bill
                {
                    Id = 4,
                    CreatedAt = new DateTime(2023, 11, 5),
                    TotalAmount = 9270000,
                },
                new Bill
                {
                    Id = 5,
                    CreatedAt = new DateTime(2023, 11, 15),
                    TotalAmount = 6000000,
                }
            );


        }
    }
}

