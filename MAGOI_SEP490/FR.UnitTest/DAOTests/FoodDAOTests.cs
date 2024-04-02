using FR.BusinessObjects.Models;

namespace FR.UnitTest.DAOTests
{
    public class FoodDAOTests : BaseTest
    {
        public FoodDAOTests() : base() { }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }

        [Test]
        public void GetFoods_WhenCalled_ReturnsAllFoods()
        {
            var foods = foodDAO.GetFoods();
            Assert.That(foods, Has.Count.EqualTo(12));
        }

        [Test]
        public void GetFoodsByCategory_WhenCalled_ReturnsFoodsByCategory()
        {
            const int FOOD_CATEGORY_ID = 1;
            var foods = foodDAO.GetFoodsByCategory(FOOD_CATEGORY_ID);
            Assert.That(foods, Has.Count.EqualTo(2));
        }

        [Test]
        public void GetFoodByFoodId_WhenCalled_ReturnsFoodByFoodId()
        {
            const int FOOD_ID = 1;
            var food = foodDAO.GetFoodByFoodId(FOOD_ID);

            Assert.That(food, Is.Not.Null);
            Assert.That(food.Name, Is.EqualTo("BIG BEERFEST SAUSAGES"));
            Assert.That(food.Description, Is.EqualTo("Xúc xích cỡ lớn 300g với đồ muối chua"));
            Assert.That(food.ImageUrl, Is.EqualTo("big-beerfest-bausages.jpg"));
            Assert.That(food.UnitPrice, Is.EqualTo(199000));
            Assert.That(food.Quantity, Is.EqualTo(100));
            Assert.That(food.CreatedAt, Is.EqualTo(new DateTime(2020, 10, 10).ToUniversalTime()));
            Assert.That(food.FoodCategoryId, Is.EqualTo(1));
        }

        [Test]
        public void UpdateFoodQuantity_WhenCalled_UpdateFoodQuantity()
        {
            const int FOOD_ID = 1;
            const int NEW_QUANTITY = 101;

            foodDAO.UpdateFoodQuantity(FOOD_ID, NEW_QUANTITY);

            var food = foodDAO.GetFoodByFoodId(FOOD_ID);
            Assert.That(food.Quantity, Is.EqualTo(NEW_QUANTITY));
        }

        [Test]
        public void AddFood_WhenCalled_AddFood()
        {
            var food = new Food
            {
                Id = 13,
                Name = "Test Food",
                Description = "Test Description",
                ImageUrl = "test-food.jpg",
                UnitPrice = 100000,
                Quantity = 100,
                CreatedAt = new DateTime(2024, 04, 01),
                FoodCategoryId = 1
            };

            foodDAO.AddFood(food);
            var result = foodDAO.GetFoodByFoodId(food.Id);

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void UpdateFood_WhenCalled_UpdateFood()
        {
            var food = foodDAO.GetFoodByFoodId(13);

            const string NEW_NAME = "Updated Food";
            const string NEW_DESCRIPTION = "Updated Description";
            const string NEW_IMAGE_URL = "updated-food.jpg";
            const float NEW_UNIT_PRICE = 200000;
            const int NEW_QUANTITY = 50;
            const int NEW_FOOD_CATEGORY_ID = 2;
            DateTime NEW_DATE_TIME = new DateTime(2024, 02, 01);

            food.Name = NEW_NAME;
            food.Description = NEW_DESCRIPTION;
            food.ImageUrl = NEW_IMAGE_URL;
            food.UnitPrice = NEW_UNIT_PRICE;
            food.FoodCategoryId = NEW_FOOD_CATEGORY_ID;
            food.Quantity = NEW_QUANTITY;
            food.CreatedAt = NEW_DATE_TIME;

            foodDAO.UpdateFood(food);
            var result = foodDAO.GetFoodByFoodId(13);
            Assert.That(result.Name, Is.EqualTo(NEW_NAME));
            Assert.That(result.Description, Is.EqualTo(NEW_DESCRIPTION));
            Assert.That(result.ImageUrl, Is.EqualTo(NEW_IMAGE_URL));
            Assert.That(result.UnitPrice, Is.EqualTo(NEW_UNIT_PRICE));
            Assert.That(result.FoodCategoryId, Is.EqualTo(NEW_FOOD_CATEGORY_ID));
            Assert.That(result.Quantity, Is.EqualTo(NEW_QUANTITY));
            Assert.That(result.CreatedAt, Is.EqualTo(NEW_DATE_TIME));
        }
    }
}
