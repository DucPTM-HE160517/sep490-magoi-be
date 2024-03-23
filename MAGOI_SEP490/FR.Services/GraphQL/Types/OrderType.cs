using FR.BusinessObjects.Models;
using FR.Services.IService;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
{
    public class OrderType : ObjectType<Order>
    {
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
            descriptor.Field("Table")
                .Type<TableType>()
                .Name("table")
                .Resolve(context =>
                {
                    var order = context.Parent<Order>();
                    return context.Service<ITableService>().GetTable(order.TableId);
                })
                .Description("The table of the order");
            descriptor.Field(f => f.BillId)
                .Type<UuidType>()
                .Name("billId")
                .Description("Id of bill");
            descriptor.Field(f => f.CreatedAt)
                .Type<DateTimeType>()
                .Name("createdAt")
                .Description("The time that order was created");
            descriptor.Field(f => f.OrderStatusId)
                .Type<IntType>()
                .Name("orderStatusId")
                .Description("Id of order's status");
            descriptor.Field("Foods")
                .Type<ListType<FoodOrderType>>()
                .Name("foods")
                .Resolve(context =>
                {
                    var order = context.Parent<Order>();
                    return context.Service<IFoodOrderService>().GetFoodOrdersByOrderId(order.Id);
                })
                .Description("List of foods in this order");
        }
    }
}
