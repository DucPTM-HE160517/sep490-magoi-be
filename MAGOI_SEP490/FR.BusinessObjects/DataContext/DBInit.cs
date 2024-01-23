using FR.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace FR.BusinessObjects.DataContext
{
    public static class DBInit
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<FoodCategory>().HasData(
                // Lẩu Thái
                new FoodCategory
                {
                    Id = 1,
                    Category = "Lẩu Tom Yum",
                },
                new FoodCategory
                {
                    Id = 2,
                    Category = "Lẩu Tom Kha",
                },
                new FoodCategory
                {
                    Id = 3,
                    Category = "Lẩu Green Curry",
                },
                new FoodCategory
                {
                    Id = 4,
                    Category = "Lẩu Red Curry",
                },
                new FoodCategory
                {
                    Id = 6,
                    Category = "Lẩu Massaman",
                },

                // Phở
                new FoodCategory
                {
                    Id = 7,
                    Category = "Phở Bò",
                },
                new FoodCategory
                {
                    Id = 8,
                    Category = "Phở Gà",
                },
                new FoodCategory
                {
                    Id = 9,
                    Category = "Phở Chay",
                },
                new FoodCategory
                {
                    Id = 10,
                    Category = "Phở Sườn",
                },

                // Steak
                new FoodCategory
                {
                    Id = 11,
                    Category = "Salad",
                },
                new FoodCategory
                {
                    Id = 12,
                    Category = "Món Khai Vị",
                },
                new FoodCategory
                {
                    Id = 13,
                    Category = "Món Lạnh",
                },
                new FoodCategory
                {
                    Id = 14,
                    Category = "Steak",
                }
            );

            modelBuilder.Entity<Food>().HasData(
                //Lẩu Tom Yum
                new Food
                {
                    Id = 1,
                    Name = "Tom Yum Goong",
                    Description = "Lẩu tôm với hương vị đậm đà của nước lẩu Tom Yum.",
                    ImageUrl = "tomyum_goong.jpg",
                    Price = 250000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 1,
                    Quantity = 1
                },
                new Food
                {
                    Id = 2,
                    Name = "Tom Yum Gai",
                    Description = "Lẩu gà với hương vị đậm đà của nước lẩu Tom Yum.",
                    ImageUrl = "tomyum_gai.jpg",
                    Price = 320000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 1,
                    Quantity = 1
                },
                new Food
                {
                    Id = 3,
                    Name = "Tom Yum Talay",
                    Description = "Lẩu hải sản với hương vị đậm đà của nước lẩu Tom Yum.",
                    ImageUrl = "tomyum_talay.jpg",
                    Price = 180000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 1,
                    Quantity = 1
                },

                //Lẩu Tom Kha
                new Food
                {
                    Id = 4,
                    Name = "Tom Kha Goong",
                    Description = "Lẩu tôm với hương vị đậm đà của nước lẩu Tom Kha và sữa cô cocon",
                    ImageUrl = "tomkha_goong.jpg",
                    Price = 160000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 2,
                    Quantity = 1
                },
                new Food
                {
                    Id = 5,
                    Name = "Tom Kha Gai",
                    Description = "Lẩu gà với hương vị đậm đà của nước lẩu Tom Kha và với sữa cô cocon",
                    ImageUrl = "tomkha_gai.jpg",
                    Price = 130000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 2,
                    Quantity = 1
                },
                new Food
                {
                    Id = 6,
                    Name = "Tom Kha Talay",
                    Description = "Lẩu hải sản với hương vị đậm đà của nước lẩu Tom Kha và sữa cô cocon",
                    ImageUrl = "tomkha_talay.jpg",
                    Price = 190000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 2,
                    Quantity = 1
                },

                //Lẩu Green Curry
                new Food
                {
                    Id = 7,
                    Name = "Green Curry Goong",
                    Description = "Lẩu tôm xanh với hương vị đậm đà của nước lẩu Green Curry.",
                    ImageUrl = "greencurry_goong.jpg",
                    Price = 170000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 3,
                    Quantity = 1
                },
                new Food
                {
                    Id = 8,
                    Name = "Green Curry Gai",
                    Description = "Lẩu gà với hương vị đậm đà của nước lẩu Green Curry.",
                    ImageUrl = "greencurry_gai.jpg",
                    Price = 140000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 3,
                    Quantity = 1
                },
                new Food
                {
                    Id = 9,
                    Name = "Green Curry Talay",
                    Description = "Lẩu hải sản với hương vị đậm đà của nước lẩu Green Curry.",
                    ImageUrl = "greencurry_talay.jpg",
                    Price = 200000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 3,
                    Quantity = 1
                },

                //Lẩu Red Curry
                new Food
                {
                    Id = 10,
                    Name = "Spicy Red Curry Goong",
                    Description = "Lẩu tôm cay với hương vị đậm đà của nước lẩu Red Curry.",
                    ImageUrl = "spicy_redcurry_goong.jpg",
                    Price = 200000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 4,
                    Quantity = 1
                },
                new Food
                {
                    Id = 11,
                    Name = "Red Curry Mushroom",
                    Description = "Lẩu nấm với hương vị đậm đà của nước lẩu Red Curry.",
                    ImageUrl = "redcurry_mushroom.jpg",
                    Price = 170000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 4,
                    Quantity = 1
                },

                //Lẩu Massaman
                new Food
                {
                    Id = 12,
                    Name = "Spicy Massaman Curry Goong",
                    Description = "Lẩu tôm cay với hương vị đậm đà của nước lẩu Massaman.",
                    ImageUrl = "spicy_massaman_goong.jpg",
                    Price = 210000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 6,
                    Quantity = 1
                },
                new Food
                {
                    Id = 13,
                    Name = "Massaman Curry Chicken",
                    Description = "Lẩu gà với hương vị đậm đà của nước lẩu Massaman.",
                    ImageUrl = "massaman_chicken.jpg",
                    Price = 180000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 6,
                    Quantity = 1
                },

                // Phở Bò
                new Food
                {
                    Id = 14,
                    Name = "Phở Bò Tái",
                    Description = "Phở bò với thịt bò tái mềm ngon.",
                    ImageUrl = "phobo_tai.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 7,
                    Quantity = 1
                },
                new Food
                {
                    Id = 15,
                    Name = "Phở Bò Tái Chín",
                    Description = "Phở bò với thịt bò tái và chín mềm ngon.",
                    ImageUrl = "phobo_taichin.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 7,
                    Quantity = 1
                },
                new Food
                {
                    Id = 16,
                    Name = "Phở Bò Chín",
                    Description = "Phở bò với thịt bò chín mềm ngon.",
                    ImageUrl = "phobo_chin.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 7,
                    Quantity = 1
                },
                new Food
                {
                    Id = 17,
                    Name = "Phở Bò Nạm",
                    Description = "Phở bò với thịt bò nạm mềm ngon.",
                    ImageUrl = "phobo_nam.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 7,
                    Quantity = 1
                },
                new Food
                {
                    Id = 18,
                    Name = "Phở Bò Gân",
                    Description = "Phở bò với thịt bò gân mềm ngon.",
                    ImageUrl = "phobo_gan.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 7,
                    Quantity = 1
                },
                new Food
                {
                    Id = 19,
                    Name = "Phở Bò Sách",
                    Description = "Phở bò với thịt bò sách mềm ngon.",
                    ImageUrl = "phobo_sach.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 7,
                    Quantity = 1
                },

                //Phở Gà
                new Food
                {
                    Id = 20,
                    Name = "Phở Gà Đùi",
                    Description = "Phở gà với thịt gà đùi mềm ngon.",
                    ImageUrl = "phoga_dui.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 8,
                    Quantity = 1
                },
                new Food
                {
                    Id = 21,
                    Name = "Phở Gà Lườn",
                    Description = "Phở gà với thịt gà lườn mềm ngon.",
                    ImageUrl = "phoga_luon.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 8,
                    Quantity = 1
                },
                new Food
                {
                    Id = 22,
                    Name = "Phở Gà Cánh",
                    Description = "Phở gà với thịt gà cánh mềm ngon.",
                    ImageUrl = "phoga_canh.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 8,
                    Quantity = 1
                },
                new Food
                {
                    Id = 23,
                    Name = "Phở Gà Tim Cật",
                    Description = "Phở gà với thịt gà và tim cật.",
                    ImageUrl = "phoga_timcat.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 8,
                    Quantity = 1
                },

                //Phở Chay
                new Food
                {
                    Id = 24,
                    Name = "Phở Chay Đậu Hũ",
                    Description = "Phở chay với nước dùng và đậu hũ.",
                    ImageUrl = "phochay_dauhu.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 9,
                    Quantity = 1
                },
                new Food
                {
                    Id = 25,
                    Name = "Phở Chay Nấm",
                    Description = "Phở chay với nước dùng và đậu hũ.",
                    ImageUrl = "phochay_nam.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 9,
                    Quantity = 1
                },

                //Phở Sườn
                new Food
                {
                    Id = 26,
                    Name = "Phở Sườn Bò",
                    Description = "Phở với sườn bò mềm ngon.",
                    ImageUrl = "phosuon_bo.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 10,
                    Quantity = 1
                },
                new Food
                {
                    Id = 27,
                    Name = "Phở Sườn Heo",
                    Description = "Phở với sườn heo mềm ngon.",
                    ImageUrl = "phosuon_heo.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 10,
                    Quantity = 1
                },

                //Salad
                new Food
                {
                    Id = 28,
                    Name = "Salad Trộn",
                    Description = "Salad trộn với rau sống và sốt truyền thống.",
                    ImageUrl = "salad_tron.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2015, 10, 6),
                    FoodCategoryId = 11,
                    Quantity = 1
                },
                new Food
                {
                    Id = 29,
                    Name = "Salad Cá Ngừ",
                    Description = "Salad với cá ngừ và sốt truyền thống.",
                    ImageUrl = "salad_cangu.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2015, 10, 6),
                    FoodCategoryId = 11,
                    Quantity = 1
                },
                new Food
                {
                    Id = 30,
                    Name = "Chicken Avocado Salad",
                    Description = "Salad gà và bơ avocado với sốt vinaigrette.",
                    ImageUrl = "chicken_avocado_salad.jpg",
                    Price = 70000,
                    CreatedAt = new DateTime(2015, 10, 6),
                    FoodCategoryId = 11,
                    Quantity = 1
                },
                new Food
                {
                    Id = 31,
                    Name = "Caesar Salad",
                    Description = "Salad Caesar truyền thống với sốt mayonnaise và phô mai.",
                    ImageUrl = "caesar_salad.jpg",
                    Price = 90000,
                    CreatedAt = new DateTime(2015, 10, 3),
                    FoodCategoryId = 11,
                    Quantity = 1
                },

                //Món Khai Vị
                new Food
                {
                    Id = 32,
                    Name = "Garlic Bread",
                    Description = "Bánh mì tỏi nướng giòn thơm phức.",
                    ImageUrl = "garlic_bread.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    Quantity = 1
                },
                new Food
                {
                    Id = 33,
                    Name = "Shrimp Cocktail",
                    Description = "Cocktail tôm tươi ngon với sốt cay lạnh.",
                    ImageUrl = "shrimp_cocktail.jpg",
                    Price = 120000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    Quantity = 1
                },
                new Food
                {
                    Id = 34,
                    Name = "Mushroom Bruschetta",
                    Description = "Bruschetta nấm phô mai với dầu ôliu.",
                    ImageUrl = "mushroom_bruschetta.jpg",
                    Price = 90000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    Quantity = 1
                },
                new Food
                {
                    Id = 35,
                    Name = "Potato Skins",
                    Description = "Vỏ khoai tây nướng với phô mai và thịt xông khói.",
                    ImageUrl = "potato_skins.jpg",
                    Price = 110000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    Quantity = 1
                },
                new Food
                {
                    Id = 36,
                    Name = "Cheese Stuffed Jalapeños",
                    Description = "Ớt chuông nhồi phô mai, nướng giòn.",
                    ImageUrl = "cheese_stuffed_jalapenos.jpg",
                    Price = 95000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    Quantity = 1
                },

                //Món Lạnh
                new Food
                {
                    Id = 37,
                    Name = "Tuna Tartare",
                    Description = "Tartare cá ngừ với sốt hạt tiêu và cần tây.",
                    ImageUrl = "tuna_tartare.jpg",
                    Price = 120000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    Quantity = 1
                },
                new Food
                {
                    Id = 38,
                    Name = "Shrimp Ceviche",
                    Description = "Ceviche tôm với cà chua, dưa leo, và hành tây.",
                    ImageUrl = "shrimp_ceviche.jpg",
                    Price = 110000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    Quantity = 1
                },
                new Food
                {
                    Id = 39,
                    Name = "Smoked Salmon Platter",
                    Description = "Đĩa cá hồi hút khói phục vụ với bánh mì và kem cheese.",
                    ImageUrl = "smoked_salmon_platter.jpg",
                    Price = 630000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    Quantity = 1
                },
                new Food
                {
                    Id = 40,
                    Name = "Beef Carpaccio",
                    Description = "Carpaccio bò với rucola, phô mai parmesan, và sốt mù tạt.",
                    ImageUrl = "beef_carpaccio.jpg",
                    Price = 440000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    Quantity = 1
                },

                //Steak
                new Food
                {
                    Id = 41,
                    Name = "Filet Mignon",
                    Description = "Filet Mignon steak với nước sốt đặc biệt.",
                    ImageUrl = "filet_mignon.jpg",
                    Price = 350000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    Quantity = 1
                },
                new Food
                {
                    Id = 42,
                    Name = "Ribeye Steak",
                    Description = "Ribeye steak chảo nước sốt tiêu xanh.",
                    ImageUrl = "ribeye_steak.jpg",
                    Price = 290000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    Quantity = 1
                },
                new Food
                {
                    Id = 43,
                    Name = "T-bone Steak",
                    Description = "T-bone steak với gia vị hảo hạng.",
                    ImageUrl = "t_bone_steak.jpg",
                    Price = 750000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    Quantity = 1
                },
                new Food
                {
                    Id = 44,
                    Name = "New York Strip",
                    Description = "New York Strip steak với nước sốt hạt tiêu.",
                    ImageUrl = "new_york_strip.jpg",
                    Price = 380000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    Quantity = 1
                },
                new Food
                {
                    Id = 45,
                    Name = "Porterhouse Steak",
                    Description = "Porterhouse steak nướng chín với ớt và tỏi.",
                    ImageUrl = "porterhouse_steak.jpg",
                    Price = 620000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    Quantity = 1
                },
                new Food
                {
                    Id = 46,
                    Name = "Sirloin Steak",
                    Description = "Sirloin steak với sốt hành tỏi.",
                    ImageUrl = "sirloin_steak.jpg",
                    Price = 550000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    Quantity = 1
                },
                new Food
                {
                    Id = 47,
                    Name = "Flank Steak",
                    Description = "Flank steak với gia vị tỏi và hạt tiêu.",
                    ImageUrl = "flank_steak.jpg",
                    Price = 380000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    Quantity = 1
                },
                new Food
                {
                    Id = 48,
                    Name = "Prime Rib",
                    Description = "Prime Rib steak nướng chín với muối và hạt tiêu.",
                    ImageUrl = "prime_rib_steak.jpg",
                    Price = 450000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    Quantity = 1
                },
                new Food
                {
                    Id = 49,
                    Name = "Skirt Steak",
                    Description = "Skirt steak với gia vị đặc biệt.",
                    ImageUrl = "skirt_steak.jpg",
                    Price = 420000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    Quantity = 1
                },
                new Food
                {
                    Id = 50,
                    Name = "Chateaubriand",
                    Description = "Chateaubriand steak với sốt nước sốt đậm đà.",
                    ImageUrl = "chateaubriand_steak.jpg",
                    Price = 670000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    Quantity = 1
                }
            );
        }
    }
}

