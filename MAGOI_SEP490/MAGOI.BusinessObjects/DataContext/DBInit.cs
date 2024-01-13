using BusinessObjects.Models;
using demo.Models;
using MAGOI.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace MAGOI.BusinessObjects.DataContext
{
    public static class DBInit
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RestaurantCategory>().HasData(
                new RestaurantCategory
                {
                    RestaurantCategoryId = 1,
                    Name = "Nhà hàng Lẩu",
                    Description = "Nhà hàng chuyên về các món lẩu."
                },
                new RestaurantCategory
                {
                    RestaurantCategoryId = 2,
                    Name = "Nhà hàng Phở",
                    Description = "Nhà hàng chuyên về các món phở."
                },
                new RestaurantCategory
                {
                    RestaurantCategoryId = 3,
                    Name = "Nhà hàng Steak",
                    Description = "Nhà hàng chuyên về các món steak."
                }
            );

            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    RestaurantId = 1,
                    Name = "Thái Deli",
                    Address = "Số 5 Quan Hoa, Cầu Giấy, Hà Nội",
                    Hotline = "02477748666",
                    Email = "mkt@mamagroup.vn",
                    CreatedAt = new DateTime(2018, 1, 3),
                    RestaurantCategoryId = 1,
                    IsAvailable = true
                },
                new Restaurant
                {
                    RestaurantId = 2,
                    Name = "Phở Thìn Lò Đúc",
                    Address = "13 Lò Đúc, quận Hai Bà Trưng, Hà Nội",
                    Hotline = "0966657997",
                    Email = "phothin1979hanoi@gmail.com",
                    CreatedAt = new DateTime(2009, 5, 11),
                    RestaurantCategoryId = 2,
                    IsAvailable = true
                },
                new Restaurant
                {
                    RestaurantId = 3,
                    Name = "Grille6 Steakhouse",
                    Address = "184 Hào Nam, Cát Linh, Đống Đa, Hà Nội",
                    Hotline = "0965401915",
                    Email = "grill66steakhousevn@gmail.com",
                    CreatedAt = new DateTime(2015, 10, 6),
                    RestaurantCategoryId = 3,
                    IsAvailable = true
                }
            );

            modelBuilder.Entity<FoodCategory>().HasData(
                // Lẩu Thái
                new FoodCategory
                {
                    FoodCategoryId = 1,
                    Name = "Lẩu Tom Yum",
                    Description = "Lẩu Thái với hương vị đậm đà của nước lẩu Tom Yum."
                },
                new FoodCategory
                {
                    FoodCategoryId = 2,
                    Name = "Lẩu Tom Kha",
                    Description = "Lẩu Thái với sự hòa quyện của nước lẩu Tom Kha và sữa cô cocon."
                },
                new FoodCategory
                {
                    FoodCategoryId = 3,
                    Name = "Lẩu Green Curry",
                    Description = "Lẩu Thái với nước lẩu xanh mát từ cà ri xanh."
                },
                new FoodCategory
                {
                    FoodCategoryId = 4,
                    Name = "Lẩu Red Curry",
                    Description = "Lẩu Thái với hương vị độc đáo của nước lẩu Red Curry."
                },
                new FoodCategory
                {
                    FoodCategoryId = 6,
                    Name = "Lẩu Massaman",
                    Description = "Lẩu Thái với gia vị đặc trưng của cà ri Massaman."
                },

                // Phở
                new FoodCategory
                {
                    FoodCategoryId = 7,
                    Name = "Phở Bò",
                    Description = "Một trong những món phở nổi tiếng với nước dùng thơm ngon và thịt bò mềm."
                },
                new FoodCategory
                {
                    FoodCategoryId = 8,
                    Name = "Phở Gà",
                    Description = "Món phở với nước dùng hương vị và thịt gà tươi ngon."
                },
                new FoodCategory
                {
                    FoodCategoryId = 9,
                    Name = "Phở Chay",
                    Description = "Phở dành cho người ăn chay, với nước dùng và nguyên liệu chay thơm ngon."
                },
                new FoodCategory
                {
                    FoodCategoryId = 10,
                    Name = "Phở Sườn",
                    Description = "Phở với sườn nước dùng đậm đà và thịt sườn ngon mắt."
                },

                // Steak
                new FoodCategory
                {
                    FoodCategoryId = 11,
                    Name = "Salad",
                    Description = "Món salad tươi ngon với rau sống và sốt truyền thống."
                },
                new FoodCategory
                {
                    FoodCategoryId = 12,
                    Name = "Món Khai Vị",
                    Description = "Các món khai vị hấp dẫn để bắt đầu bữa ăn."
                },
                new FoodCategory
                {
                    FoodCategoryId = 13,
                    Name = "Món Lạnh",
                    Description = "Món lạnh ngon lành, phù hợp cho bữa ăn nhẹ."
                },
                new FoodCategory
                {
                    FoodCategoryId = 14,
                    Name = "Steak",
                    Description = "Các loại steak chất lượng cao, nướng hoặc nướng chín theo yêu cầu."
                }
            );

            modelBuilder.Entity<Food>().HasData(
                //Lẩu Tom Yum
                new Food
                {
                    FoodId = 1,
                    Name = "Tom Yum Goong",
                    Description = "Lẩu tôm với hương vị đậm đà của nước lẩu Tom Yum.",
                    ImageUrl = "tomyum_goong.jpg",
                    Price = 250000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 1,
                    RestaurantId = 1,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 2,
                    Name = "Tom Yum Gai",
                    Description = "Lẩu gà với hương vị đậm đà của nước lẩu Tom Yum.",
                    ImageUrl = "tomyum_gai.jpg",
                    Price = 320000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 1,
                    RestaurantId = 1,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 3,
                    Name = "Tom Yum Talay",
                    Description = "Lẩu hải sản với hương vị đậm đà của nước lẩu Tom Yum.",
                    ImageUrl = "tomyum_talay.jpg",
                    Price = 180000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 1,
                    RestaurantId = 1,
                    IsAvailable = true
                },

                //Lẩu Tom Kha
                new Food
                {
                    FoodId = 4,
                    Name = "Tom Kha Goong",
                    Description = "Lẩu tôm với hương vị đậm đà của nước lẩu Tom Kha và sữa cô cocon",
                    ImageUrl = "tomkha_goong.jpg",
                    Price = 160000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 2,
                    RestaurantId = 1,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 5,
                    Name = "Tom Kha Gai",
                    Description = "Lẩu gà với hương vị đậm đà của nước lẩu Tom Kha và với sữa cô cocon",
                    ImageUrl = "tomkha_gai.jpg",
                    Price = 130000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 2,
                    RestaurantId = 1,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 6,
                    Name = "Tom Kha Talay",
                    Description = "Lẩu hải sản với hương vị đậm đà của nước lẩu Tom Kha và sữa cô cocon",
                    ImageUrl = "tomkha_talay.jpg",
                    Price = 190000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 2,
                    RestaurantId = 1,
                    IsAvailable = true
                },

                //Lẩu Green Curry
                new Food
                {
                    FoodId = 7,
                    Name = "Green Curry Goong",
                    Description = "Lẩu tôm xanh với hương vị đậm đà của nước lẩu Green Curry.",
                    ImageUrl = "greencurry_goong.jpg",
                    Price = 170000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 3,
                    RestaurantId = 1,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 8,
                    Name = "Green Curry Gai",
                    Description = "Lẩu gà với hương vị đậm đà của nước lẩu Green Curry.",
                    ImageUrl = "greencurry_gai.jpg",
                    Price = 140000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 3,
                    RestaurantId = 1,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 9,
                    Name = "Green Curry Talay",
                    Description = "Lẩu hải sản với hương vị đậm đà của nước lẩu Green Curry.",
                    ImageUrl = "greencurry_talay.jpg",
                    Price = 200000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 3,
                    RestaurantId = 1,
                    IsAvailable = true
                },

                //Lẩu Red Curry
                new Food
                {
                    FoodId = 10,
                    Name = "Spicy Red Curry Goong",
                    Description = "Lẩu tôm cay với hương vị đậm đà của nước lẩu Red Curry.",
                    ImageUrl = "spicy_redcurry_goong.jpg",
                    Price = 200000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 4,
                    RestaurantId = 1,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 11,
                    Name = "Red Curry Mushroom",
                    Description = "Lẩu nấm với hương vị đậm đà của nước lẩu Red Curry.",
                    ImageUrl = "redcurry_mushroom.jpg",
                    Price = 170000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 4,
                    RestaurantId = 1,
                    IsAvailable = true
                },

                //Lẩu Massaman
                new Food
                {
                    FoodId = 12,
                    Name = "Spicy Massaman Curry Goong",
                    Description = "Lẩu tôm cay với hương vị đậm đà của nước lẩu Massaman.",
                    ImageUrl = "spicy_massaman_goong.jpg",
                    Price = 210000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 6,
                    RestaurantId = 1,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 13,
                    Name = "Massaman Curry Chicken",
                    Description = "Lẩu gà với hương vị đậm đà của nước lẩu Massaman.",
                    ImageUrl = "massaman_chicken.jpg",
                    Price = 180000,
                    CreatedAt = new DateTime(2018, 1, 3),
                    FoodCategoryId = 6,
                    RestaurantId = 1,
                    IsAvailable = true
                },

                // Phở Bò
                new Food
                {
                    FoodId = 14,
                    Name = "Phở Bò Tái",
                    Description = "Phở bò với thịt bò tái mềm ngon.",
                    ImageUrl = "phobo_tai.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 7,
                    RestaurantId = 2,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 15,
                    Name = "Phở Bò Tái Chín",
                    Description = "Phở bò với thịt bò tái và chín mềm ngon.",
                    ImageUrl = "phobo_taichin.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 7,
                    RestaurantId = 2,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 16,
                    Name = "Phở Bò Chín",
                    Description = "Phở bò với thịt bò chín mềm ngon.",
                    ImageUrl = "phobo_chin.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 7,
                    RestaurantId = 2,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 17,
                    Name = "Phở Bò Nạm",
                    Description = "Phở bò với thịt bò nạm mềm ngon.",
                    ImageUrl = "phobo_nam.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 7,
                    RestaurantId = 2,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 18,
                    Name = "Phở Bò Gân",
                    Description = "Phở bò với thịt bò gân mềm ngon.",
                    ImageUrl = "phobo_gan.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 7,
                    RestaurantId = 2,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 19,
                    Name = "Phở Bò Sách",
                    Description = "Phở bò với thịt bò sách mềm ngon.",
                    ImageUrl = "phobo_sach.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 7,
                    RestaurantId = 2,
                    IsAvailable = true
                },

                //Phở Gà
                new Food
                {
                    FoodId = 20,
                    Name = "Phở Gà Đùi",
                    Description = "Phở gà với thịt gà đùi mềm ngon.",
                    ImageUrl = "phoga_dui.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 8,
                    RestaurantId = 2,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 21,
                    Name = "Phở Gà Lườn",
                    Description = "Phở gà với thịt gà lườn mềm ngon.",
                    ImageUrl = "phoga_luon.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 8,
                    RestaurantId = 2,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 22,
                    Name = "Phở Gà Cánh",
                    Description = "Phở gà với thịt gà cánh mềm ngon.",
                    ImageUrl = "phoga_canh.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 8,
                    RestaurantId = 2,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 23,
                    Name = "Phở Gà Tim Cật",
                    Description = "Phở gà với thịt gà và tim cật.",
                    ImageUrl = "phoga_timcat.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 8,
                    RestaurantId = 2,
                    IsAvailable = true
                },

                //Phở Chay
                new Food
                {
                    FoodId = 24,
                    Name = "Phở Chay Đậu Hũ",
                    Description = "Phở chay với nước dùng và đậu hũ.",
                    ImageUrl = "phochay_dauhu.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 9,
                    RestaurantId = 2,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 25,
                    Name = "Phở Chay Nấm",
                    Description = "Phở chay với nước dùng và đậu hũ.",
                    ImageUrl = "phochay_nam.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 9,
                    RestaurantId = 2,
                    IsAvailable = true
                },

                //Phở Sườn
                new Food
                {
                    FoodId = 26,
                    Name = "Phở Sườn Bò",
                    Description = "Phở với sườn bò mềm ngon.",
                    ImageUrl = "phosuon_bo.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 10,
                    RestaurantId = 2,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 27,
                    Name = "Phở Sườn Heo",
                    Description = "Phở với sườn heo mềm ngon.",
                    ImageUrl = "phosuon_heo.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2009, 5, 11),
                    FoodCategoryId = 10,
                    RestaurantId = 2,
                    IsAvailable = true
                },

                //Salad
                new Food
                {
                    FoodId = 28,
                    Name = "Salad Trộn",
                    Description = "Salad trộn với rau sống và sốt truyền thống.",
                    ImageUrl = "salad_tron.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2015, 10, 6),
                    FoodCategoryId = 11,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 29,
                    Name = "Salad Cá Ngừ",
                    Description = "Salad với cá ngừ và sốt truyền thống.",
                    ImageUrl = "salad_cangu.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2015, 10, 6),
                    FoodCategoryId = 11,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 30,
                    Name = "Chicken Avocado Salad",
                    Description = "Salad gà và bơ avocado với sốt vinaigrette.",
                    ImageUrl = "chicken_avocado_salad.jpg",
                    Price = 70000,
                    CreatedAt = new DateTime(2015, 10, 6),
                    FoodCategoryId = 11,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 31,
                    Name = "Caesar Salad",
                    Description = "Salad Caesar truyền thống với sốt mayonnaise và phô mai.",
                    ImageUrl = "caesar_salad.jpg",
                    Price = 90000,
                    CreatedAt = new DateTime(2015, 10, 3),
                    FoodCategoryId = 11,
                    RestaurantId = 3,
                    IsAvailable = true
                },

                //Món Khai Vị
                new Food
                {
                    FoodId = 32,
                    Name = "Garlic Bread",
                    Description = "Bánh mì tỏi nướng giòn thơm phức.",
                    ImageUrl = "garlic_bread.jpg",
                    Price = 50000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 33,
                    Name = "Shrimp Cocktail",
                    Description = "Cocktail tôm tươi ngon với sốt cay lạnh.",
                    ImageUrl = "shrimp_cocktail.jpg",
                    Price = 120000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 34,
                    Name = "Mushroom Bruschetta",
                    Description = "Bruschetta nấm phô mai với dầu ôliu.",
                    ImageUrl = "mushroom_bruschetta.jpg",
                    Price = 90000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 35,
                    Name = "Potato Skins",
                    Description = "Vỏ khoai tây nướng với phô mai và thịt xông khói.",
                    ImageUrl = "potato_skins.jpg",
                    Price = 110000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 36,
                    Name = "Cheese Stuffed Jalapeños",
                    Description = "Ớt chuông nhồi phô mai, nướng giòn.",
                    ImageUrl = "cheese_stuffed_jalapenos.jpg",
                    Price = 95000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    RestaurantId = 3,
                    IsAvailable = true
                },

                //Món Lạnh
                new Food
                {
                    FoodId = 37,
                    Name = "Tuna Tartare",
                    Description = "Tartare cá ngừ với sốt hạt tiêu và cần tây.",
                    ImageUrl = "tuna_tartare.jpg",
                    Price = 120000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 38,
                    Name = "Shrimp Ceviche",
                    Description = "Ceviche tôm với cà chua, dưa leo, và hành tây.",
                    ImageUrl = "shrimp_ceviche.jpg",
                    Price = 110000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 39,
                    Name = "Smoked Salmon Platter",
                    Description = "Đĩa cá hồi hút khói phục vụ với bánh mì và kem cheese.",
                    ImageUrl = "smoked_salmon_platter.jpg",
                    Price = 630000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 40,
                    Name = "Beef Carpaccio",
                    Description = "Carpaccio bò với rucola, phô mai parmesan, và sốt mù tạt.",
                    ImageUrl = "beef_carpaccio.jpg",
                    Price = 440000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 12,
                    RestaurantId = 3,
                    IsAvailable = true
                },

                //Steak
                new Food
                {
                    FoodId = 41,
                    Name = "Filet Mignon",
                    Description = "Filet Mignon steak với nước sốt đặc biệt.",
                    ImageUrl = "filet_mignon.jpg",
                    Price = 350000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 42,
                    Name = "Ribeye Steak",
                    Description = "Ribeye steak chảo nước sốt tiêu xanh.",
                    ImageUrl = "ribeye_steak.jpg",
                    Price = 290000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 43,
                    Name = "T-bone Steak",
                    Description = "T-bone steak với gia vị hảo hạng.",
                    ImageUrl = "t_bone_steak.jpg",
                    Price = 750000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 44,
                    Name = "New York Strip",
                    Description = "New York Strip steak với nước sốt hạt tiêu.",
                    ImageUrl = "new_york_strip.jpg",
                    Price = 380000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 45,
                    Name = "Porterhouse Steak",
                    Description = "Porterhouse steak nướng chín với ớt và tỏi.",
                    ImageUrl = "porterhouse_steak.jpg",
                    Price = 620000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 46,
                    Name = "Sirloin Steak",
                    Description = "Sirloin steak với sốt hành tỏi.",
                    ImageUrl = "sirloin_steak.jpg",
                    Price = 550000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 47,
                    Name = "Flank Steak",
                    Description = "Flank steak với gia vị tỏi và hạt tiêu.",
                    ImageUrl = "flank_steak.jpg",
                    Price = 380000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 48,
                    Name = "Prime Rib",
                    Description = "Prime Rib steak nướng chín với muối và hạt tiêu.",
                    ImageUrl = "prime_rib_steak.jpg",
                    Price = 450000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 49,
                    Name = "Skirt Steak",
                    Description = "Skirt steak với gia vị đặc biệt.",
                    ImageUrl = "skirt_steak.jpg",
                    Price = 420000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    RestaurantId = 3,
                    IsAvailable = true
                },
                new Food
                {
                    FoodId = 50,
                    Name = "Chateaubriand",
                    Description = "Chateaubriand steak với sốt nước sốt đậm đà.",
                    ImageUrl = "chateaubriand_steak.jpg",
                    Price = 670000,
                    CreatedAt = new DateTime(2016, 1, 3),
                    FoodCategoryId = 13,
                    RestaurantId = 3,
                    IsAvailable = true
                }
            );

            modelBuilder.Entity<Table>().HasData(
                // Restaurant 1
                new Table
                {
                    TableID = 1,
                    RestaurantId = 1,
                    Name = "Bàn 1",
                    CreatedAt = new DateTime(2018, 1, 3),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 2,
                    RestaurantId = 1,
                    Name = "Bàn 2",
                    CreatedAt = new DateTime(2018, 1, 3),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 3,
                    RestaurantId = 1,
                    Name = "Bàn 3",
                    CreatedAt = new DateTime(2018, 1, 3),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 4,
                    RestaurantId = 1,
                    Name = "Bàn 4",
                    CreatedAt = new DateTime(2018, 1, 3),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 5,
                    RestaurantId = 1,
                    Name = "Bàn 5",
                    CreatedAt = new DateTime(2018, 1, 3),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 6,
                    RestaurantId = 1,
                    Name = "Bàn 6",
                    CreatedAt = new DateTime(2018, 1, 3),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 7,
                    RestaurantId = 1,
                    Name = "Bàn 7",
                    CreatedAt = new DateTime(2018, 1, 3),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 8,
                    RestaurantId = 1,
                    Name = "Bàn 8",
                    CreatedAt = new DateTime(2018, 1, 3),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 9,
                    RestaurantId = 1,
                    Name = "Bàn 9",
                    CreatedAt = new DateTime(2018, 1, 3),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 10,
                    RestaurantId = 1,
                    Name = "Bàn 10",
                    CreatedAt = new DateTime(2018, 1, 3),
                    IsAvailable = true
                },

                // Restaurant 2
                new Table
                {
                    TableID = 11,
                    RestaurantId = 2,
                    Name = "Bàn 1",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 12,
                    RestaurantId = 2,
                    Name = "Bàn 2",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 13,
                    RestaurantId = 2,
                    Name = "Bàn 3",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 14,
                    RestaurantId = 2,
                    Name = "Bàn 4",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 15,
                    RestaurantId = 2,
                    Name = "Bàn 5",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 16,
                    RestaurantId = 2,
                    Name = "Bàn 6",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 17,
                    RestaurantId = 2,
                    Name = "Bàn 7",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 18,
                    RestaurantId = 2,
                    Name = "Bàn 8",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 19,
                    RestaurantId = 2,
                    Name = "Bàn 9",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 20,
                    RestaurantId = 2,
                    Name = "Bàn 10",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 21,
                    RestaurantId = 2,
                    Name = "Bàn 11",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 22,
                    RestaurantId = 2,
                    Name = "Bàn 12",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 23,
                    RestaurantId = 2,
                    Name = "Bàn 13",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 24,
                    RestaurantId = 2,
                    Name = "Bàn 14",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 25,
                    RestaurantId = 2,
                    Name = "Bàn 15",
                    CreatedAt = new DateTime(2009, 5, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 26,
                    RestaurantId = 3,
                    Name = "Bàn 1",
                    CreatedAt = new DateTime(2015, 10, 6),
                    IsAvailable = true
                },

                // Restaurant 3
                new Table
                {
                    TableID = 27,
                    RestaurantId = 3,
                    Name = "Bàn 2",
                    CreatedAt = new DateTime(2015, 10, 7),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 28,
                    RestaurantId = 3,
                    Name = "Bàn 3",
                    CreatedAt = new DateTime(2015, 10, 8),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 29,
                    RestaurantId = 3,
                    Name = "Bàn 4",
                    CreatedAt = new DateTime(2015, 10, 9),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 30,
                    RestaurantId = 3,
                    Name = "Bàn 5",
                    CreatedAt = new DateTime(2015, 10, 10),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 31,
                    RestaurantId = 3,
                    Name = "Bàn 6",
                    CreatedAt = new DateTime(2015, 10, 11),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 32,
                    RestaurantId = 3,
                    Name = "Bàn 7",
                    CreatedAt = new DateTime(2015, 10, 12),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 33,
                    RestaurantId = 3,
                    Name = "Bàn 8",
                    CreatedAt = new DateTime(2015, 10, 13),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 34,
                    RestaurantId = 3,
                    Name = "Bàn 9",
                    CreatedAt = new DateTime(2015, 10, 14),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 35,
                    RestaurantId = 3,
                    Name = "Bàn 10",
                    CreatedAt = new DateTime(2015, 10, 15),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 36,
                    RestaurantId = 3,
                    Name = "Bàn 11",
                    CreatedAt = new DateTime(2015, 10, 16),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 37,
                    RestaurantId = 3,
                    Name = "Bàn 12",
                    CreatedAt = new DateTime(2015, 10, 17),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 38,
                    RestaurantId = 3,
                    Name = "Bàn 13",
                    CreatedAt = new DateTime(2015, 10, 18),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 39,
                    RestaurantId = 3,
                    Name = "Bàn 14",
                    CreatedAt = new DateTime(2015, 10, 19),
                    IsAvailable = true
                },
                new Table
                {
                    TableID = 40,
                    RestaurantId = 3,
                    Name = "Bàn 15",
                    CreatedAt = new DateTime(2015, 10, 20),
                    IsAvailable = true
                }
            );
        }
    }
}

