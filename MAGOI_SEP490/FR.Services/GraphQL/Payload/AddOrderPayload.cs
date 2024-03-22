using FR.BusinessObjects.Models;

namespace FR.Services.GraphQL.Payload
{
    public class AddOrderPayload : Payload
    {
        public Order? Order { get; }
        public List<FoodOrder>? FoodOrders { get; }
        public AddOrderPayload(Order order, List<FoodOrder> foodOrders)
        {
            Order = order;
            FoodOrders = foodOrders;
        }

        public AddOrderPayload(UserError error) : base( error) { }
    }
}
