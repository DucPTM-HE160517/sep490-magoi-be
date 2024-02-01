using FR.API.GraphQL.Payload;
using FR.BusinessObjects.Models;
using FR.Services.GraphQL.InputTypes;
using FR.Services.IService;

namespace FR.API.GraphQL.Mutations
{
    public partial class Mutations
    {
        public async Task<AddOrderPayload> AddOrderAsync(
            IOrderService orderService, IFoodOrderService foodOrderService,
            ITableService tableService, IFoodService foodService,
            OrderInput orderInput,
            List<FoodOrderInput> foodListInput)
        {
            //check order: foods amount exceed food quantity
            if (!foodService.CheckFoodOrdersQuantity(foodListInput))
            {
                return new AddOrderPayload(new UserError("ERROR: Please check the food quantity!", "FOOD_AMOUNT_EXCEED"));
            }

            //add order
            Order order;
            try
            {
                order = orderService.AddOrder(orderInput);
            }
            catch (Exception ex)
            {
                return new AddOrderPayload(new UserError("ERROR: " + ex.Message, "ERROR_CODE"));
            }

            //add food order
            try
            {
                List<FoodOrder> foodOrders = foodOrderService.AddFoodOrders(order.Id, foodListInput);
                //update the quantity of the food
                foodService.UpdateFoodQuantityWhenCreateOrder(foodListInput);
                //update table status to serving
                tableService.UpdateTableStatusWhenCreateOrder(orderInput.tableId);

                return new AddOrderPayload(order, foodOrders);
            }
            catch (Exception ex)
            {
                //delete order -> not done
                return new AddOrderPayload(new UserError("ERROR: " + ex.Message, "ERROR_CODE"));
            }
        }
    }
}
