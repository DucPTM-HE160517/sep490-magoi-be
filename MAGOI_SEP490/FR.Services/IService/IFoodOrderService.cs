using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.Services.GraphQL.InputTypes;

namespace FR.Services.IService
{
    public interface IFoodOrderService
    {
        List<FoodOrder> AddFoodOrders(int orderId, List<FoodOrderInput> foodOrders);
        List<FoodOrder> GetFoodOrdersByOrderId(int orderId);
    }
}
