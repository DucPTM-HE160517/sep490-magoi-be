using FR.BusinessObjects.Models;
using FR.UnitTest;

namespace FR.UnitTests.DAOTests
{
    public class FoodOrderDAOTests : BaseTest
    {
        public FoodOrderDAOTests() : base() { }

        [OneTimeTearDown]
        public void Clean()
        {
            context.Database.EnsureDeleted();
        }

        [Test]
        public void AddFooOrders_WhenCalled_AddsFoodOrders()
        {
            var foodOrders = new List<FoodOrder>
            {
                new FoodOrder { OrderId = Guid.NewGuid(), FoodId = 1, Quantity = 1, UnitPrice = 10000 },
                new FoodOrder { OrderId = Guid.NewGuid(), FoodId = 2, Quantity = 1, UnitPrice = 10000 }
            };

            foodOrderDAO.AddFoodOrders(foodOrders);

            var foodOrder1 = foodOrderDAO.GetFoodOrderByOrderIdAndFoodId(foodOrders[0].OrderId, foodOrders[0].FoodId);
            var foodOrder2 = foodOrderDAO.GetFoodOrderByOrderIdAndFoodId(foodOrders[1].OrderId, foodOrders[1].FoodId);

            Assert.That(foodOrder1, Is.Not.Null);
            Assert.That(foodOrder2, Is.Not.Null);
        }

        [Test]
        public void UpdateFoodOrder_WhenCalled_UpdatesFoodOrder()
        {
            Guid ORDER_ID = Guid.Parse("11238123-7115-4294-af3a-149a0cd21dba");
            const int FOOD_ID = 1;
            var foodOrderToUpdate = foodOrderDAO.GetFoodOrderByOrderIdAndFoodId(ORDER_ID, FOOD_ID);

            const int NEW_QUANTITY = 3;
            const int NEW_UNIT_PRICE = 20000;
            const string NEW_FOOD_NOTE = "Ít đường";
            const int NEW_FOOD_ORDER_STATUS_ID = (int)FoodOrderStatusId.Cooking;
            DateTime NEW_ORDER_AT = new DateTime(2024, 01, 01, 0, 0, 1);

            foodOrderToUpdate.Quantity = NEW_QUANTITY;
            foodOrderToUpdate.UnitPrice = NEW_UNIT_PRICE;
            foodOrderToUpdate.FoodNote = NEW_FOOD_NOTE;
            foodOrderToUpdate.FoodOrderStatusId = NEW_FOOD_ORDER_STATUS_ID;
            foodOrderToUpdate.OrderAt = NEW_ORDER_AT;

            foodOrderDAO.UpdateFoodOrder(foodOrderToUpdate);

            Assert.That(foodOrderToUpdate.Quantity, Is.EqualTo(NEW_QUANTITY));
            Assert.That(foodOrderToUpdate.UnitPrice, Is.EqualTo(NEW_UNIT_PRICE));
            Assert.That(foodOrderToUpdate.FoodNote, Is.EqualTo(NEW_FOOD_NOTE));
            Assert.That(foodOrderToUpdate.FoodOrderStatusId, Is.EqualTo(NEW_FOOD_ORDER_STATUS_ID));
            Assert.That(foodOrderToUpdate.OrderAt, Is.EqualTo(NEW_ORDER_AT));
        }

        [Test]
        public void GetFoodOrdersByOrderId_WhenCalled_ReturnsFoodOrders()
        {
            Guid ORDER_ID = Guid.Parse("11238123-7115-4294-af3a-149a0cd21dba");
            var result = foodOrderDAO.GetFoodOrdersByOrderId(ORDER_ID);

            Assert.That(result, Has.Count.EqualTo(2));
        }

        [Test]
        public void GetFoodPrice_WhenCalled_ReturnsFoodPrice()
        {
            const int FOOD_ID = 1;
            var result = foodOrderDAO.GetFoodPrice(FOOD_ID);

            Assert.That(result, Is.EqualTo(199000));
        }
    }
}
