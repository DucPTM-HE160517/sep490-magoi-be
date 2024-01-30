using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.DataAccess;
using FR.Services.GraphQL.InputTypes;
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

        public List<FoodOrder> AddFoodOrders(int orderId, List<FoodOrderInput> foodListInput)
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
                    OrderAt = foodListInput[i].orderedAt
                };
                foodOrders.Add(food);
            }
            _dao.AddFoodOrders(foodOrders);
            return foodOrders;
        }

        public List<FoodOrder> GetFoodOrdersByOrderId(int orderId)
        {
            return _dao.GetFoodOrdersByOrderId(orderId);
        }
    }
}
