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
            ITableService tableService,
            OrderInput orderInput,
            List<FoodOrderInput> foodListInput)
        {
            //add order
            Order order;
            try
            {
                order = orderService.AddOrder(orderInput);
            }
            catch (Exception ex)
            {
                return new AddOrderPayload(new UserError("ERROR: " + ex.Message));
            }

            //add food order
            try
            {
                List<FoodOrder> foodOrders = foodOrderService.AddFoodOrders(order.Id, foodListInput);

                //update table status to serving
                Table table = tableService.GetTable(orderInput.tableId);
                if (table.StatusId == (int)TableStatusId.Available)
                {
                    tableService.UpdateTableStatus(orderInput.tableId, TableStatusId.Serving);
                }

                return new AddOrderPayload(order, foodOrders);
            }
            catch (Exception ex)
            {
                //delete order -> not done
                return new AddOrderPayload(new UserError("ERROR: " + ex.Message));
            }


        }
    }
}
