using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;

namespace FR.UnitTest
{
    public static class SeedData
    {
        public static void SeedTestData(this DBContext dBContext)
        {
            dBContext.Foods.AddRange(GetFoods());
        }

        private static List<Food> GetFoods()
        {
            var foods = new List<Food>
            {
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
                }
            };

            return foods;
        }
    }
}
