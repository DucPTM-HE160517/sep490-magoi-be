using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Types
{
    public class OrderType : ObjectType<Order>
    {
        //Featured by ThuongTTHE16355 31/01/2024
        //Define GraphQL Types of Order
        protected override void Configure(IObjectTypeDescriptor<Order> descriptor)
        {
            descriptor.Description("Order");
            descriptor.Field(f => f.Id)
                .Type<UuidType>()
                .Name("id")
                .Description("The ID of the order");
            descriptor.Field(f => f.TableId)
                .Type<UuidType>()
                .Name("tableId")
                .Description("Id of table");
            descriptor.Field(f => f.BillId)
                .Type<UuidType>()
                .Name("billId")
                .Description("Id of bill");
            descriptor.Field(f => f.CreatedAt)
                .Type<DateTimeType>()
                .Name("createdAt")
                .Description("The time that order was created");
            descriptor.Field(f => f.FeedbackId)
                .Type<UuidType>()
                .Name("feedbackId")
                .Description("Id of order's feedback");
            descriptor.Field(f => f.OrderStatusId)
                .Type<IntType>()
                .Name("orderStatusId")
                .Description("Id of order's status");
            descriptor.Field("FoodList")
                .Type<ListType<FoodOrderType>>()
                .Name("foodList")
                .Resolve(context =>
                {
                    var order = context.Parent<Order>();
                    return context.Service<IFoodOrderService>().GetFoodOrdersByOrderId(order.Id);
                })
                .Description("List of foods in this order");
        }
    }
}
