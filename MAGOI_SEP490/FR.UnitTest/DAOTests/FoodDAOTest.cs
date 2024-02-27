namespace FR.UnitTest.DAOTests
{
    public class FoodDAOTest : BaseTest
    {
        public FoodDAOTest() : base()
        {

        }

        [Fact]
        public void GetFoods_WhenCall_ReturnAllss()
        {
            var foods = foodDAO.GetFoods().ToList();
            Assert.Equal(5, foods.Count);
        }
    }
}
