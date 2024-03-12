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
            Assert.That(foods, Has.Count.EqualTo(5));
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
            Assert.That(food.CreatedAt, Is.EqualTo(new DateTime(2020, 10, 10)));
            Assert.That(food.FoodCategoryId, Is.EqualTo(1));
        }

        //[Test]
        //public void UpdateFoodQuantity_WhenCalled_UpdateFoodQuantity()
        //{
        //    const int NEW_QUANTITY = 90;

        //    foodDAO.UpdateFoodQuantity(1, NEW_QUANTITY);

        //    var food = foodDAO.GetFoodByFoodId(1);
        //    Assert.That(food.Quantity, Is.EqualTo(NEW_QUANTITY));
        //}
    }
}
