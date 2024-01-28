using FR.API.GraphQL.Payload;
using FR.API.GraphQL.Types.InputTypes;
using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutations
    {
        public async Task<AddOrderPayload> AddOrderAsync(
            IOrderService orderService, IFoodOrderService foodOrderService,
            OrderInput orderInput,
            List<FoodOrderInput> foodListInput)
        {
            //add order
            var order = new Order
            {
                TableId = orderInput.tableId,
                CreatedAt = orderInput.createdAt
            };

            try
            {
                orderService.AddOrder(order);
            }
            catch (Exception ex)
            {
                return new AddOrderPayload(new UserError("ERROR:" + ex.Message));
            }

            //add food order
            List<FoodOrder> foodOrders = new List<FoodOrder>();
            for(int i = 0; i < foodListInput.Count; i++)
            {
                FoodOrder food = new FoodOrder
                {
                    OrderId = order.Id,
                    FoodId = foodListInput[i].foodId,
                    Quantity = foodListInput[i].quantity,
                    FoodNote = foodListInput[i].foodNote,
                    OrderAt = orderInput.createdAt
                };
                foodOrders.Add(food);
            }

            try
            {
                foodOrderService.AddFoodOrders(foodOrders);
                return new AddOrderPayload(order, foodOrders);
            }
            catch(Exception ex)
            {
                return new AddOrderPayload(new UserError("ERROR:" + ex.Message));
            }
        }
    }
}
