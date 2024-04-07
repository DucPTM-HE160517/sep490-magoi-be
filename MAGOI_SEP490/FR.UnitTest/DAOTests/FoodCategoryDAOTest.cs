using FR.UnitTest;

namespace FR.UnitTests.DAOTests
{
    public class FoodCategoryDAOTest : BaseTest
    {
        public FoodCategoryDAOTest() : base()
        {

        }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }

        [Test]
        public void GetFoodCategories_WhenCalled_ReturnsAllFoodCategories()
        {
            var foodCategories = foodCategoryDAO.GetCategoryOfCookingFoods();

            Assert.That(foodCategories, Has.Count.EqualTo(3));
        }

        [Test]
        public void GetFoodCategoryById_WhenCalled_ReturnsFoodCategory()
        {
            const int FOOD_CATEGORY_ID = 1;
            var foodCategory = foodCategoryDAO.GetFoodCategoryById(FOOD_CATEGORY_ID);

            Assert.That(foodCategory, Is.Not.Null);
        }
    }
}
