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
                .Type<IntType>()
                .Name("ID")
                .Description("The ID of the order");
            descriptor.Field(f => f.TableId)
                .Type<IntType>()
                .Name("TableId")
                .Description("Id of table");
            //descriptor.Field(f => f.BillId)
            //    .Type<IntType>()
            //    .Name("BillId")
            //    .Description("Id of bill");
            descriptor.Field(f => f.CreatedAt)
                .Type<IntType>()
                .Name("CreatedAt")
                .Description("The time that order was created");
            descriptor.Field(f => f.FeedbackId)
                .Type<IntType>()
                .Name("FeedbackId")
                .Description("Id of order's feedback");
            descriptor.Field(f => f.OrderStatusId)
                .Type<IntType>()
                .Name("OrderStatusId")
                .Description("Id of order's status");
            descriptor.Field("FoodList")
                .Type<ListType<NonNullType<FoodOrderType>>>()
                .Name("FoodList")
                .Resolve(context =>
                {
                    var order = context.Parent<Order>();
                    return context.Service<IFoodOrderService>().GetFoodOrdersByOrderId(order.Id);
                })
                .Description("List of foods in this order");
        }
    }
}
