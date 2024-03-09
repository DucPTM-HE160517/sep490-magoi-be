namespace FR.UnitTest.DAOTests
{
    [TestFixture]
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

    }
}
