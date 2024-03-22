using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.GraphQL.Types.InputTypes;
using FR.Services.IService;

namespace FR.Services.Service
{
    public class FoodOrderService : IFoodOrderService
    {
        private readonly FoodOrderDAO _dao;
        public FoodOrderService(FoodOrderDAO dao)
        {
            _dao = dao;
        }

        public List<FoodOrder> AddFoodOrders(Guid orderId, List<FoodOrderInput> foodListInput)
        {
            List<FoodOrder> foodOrders = new List<FoodOrder>();
            for (int i = 0; i < foodListInput.Count; i++)
            {
                FoodOrder food = new FoodOrder
                {
                    OrderId = orderId,
                    FoodId = foodListInput[i].foodId,
                    Quantity = foodListInput[i].quantity,
                    FoodNote = foodListInput[i].foodNote,
                    UnitPrice = _dao.GetFoodPrice(foodListInput[i].foodId),
                    FoodOrderStatusId = (int)FoodOrderStatusId.Cooking
                };
                foodOrders.Add(food);
            }
            _dao.AddFoodOrders(foodOrders);
            return foodOrders;
        }

        public List<FoodOrder> GetFoodOrdersByOrderId(Guid orderId)
        {
            return _dao.GetFoodOrdersByOrderId(orderId);
        }

        public void UpdateFoodOrdersStatus(Guid orderId, int foodOrderStatusId)
        {
            try
            {
                List<FoodOrder> foods = _dao.GetFoodOrdersByOrderId(orderId);
                foreach (FoodOrder food in foods)
                {
                    food.FoodOrderStatusId = foodOrderStatusId;
                    _dao.UpdateFoodOrder(food);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public FoodOrder UpdateFoodOrderStatus(Guid orderId, int foodId, int foodOrderStatusId)
        {
            try
            {
                FoodOrder food = _dao.GetFoodOrderByOrderIdAndFoodId(orderId, foodId);
                food.FoodOrderStatusId = foodOrderStatusId;
                _dao.UpdateFoodOrder(food);
                return food;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
