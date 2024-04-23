using FR.BusinessObjects.Models;
using FR.Services.IService;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
{
    public class BillType : ObjectType<Bill>
    {
        protected override void Configure(IObjectTypeDescriptor<Bill> descriptor)
        {
            descriptor.Description("The bill of the order");
            descriptor.Field(f => f.Id)
                .Type<UuidType>()
                .Name("id")
                .Description("The ID of the bill");
            descriptor.Field(f => f.CreatedAt)
                .Type<DateTimeType>()
                .Name("createdAt")
                .Description("The date and time the bill was created");
            descriptor.Field(f => f.FinishedAt)
                .Type<DateTimeType>()
                .Name("finishedAt")
                .Description("The date and time the bill was finished");
            descriptor.Field(f => f.TotalAmount)
                .Type<FloatType>()
                .Name("totalAmount")
                .Description("The total amount of the bill");
            descriptor.Field("Table")
                .Type<TableType>()
                .Name("table")
                .Resolve(context =>
                {
                    var bill = context.Parent<Bill>();
                    return context.Service<ITableService>().GetTableByBillId(bill.Id);
                });
            descriptor.Field(f => f.PaymentMethodId)
                .Type<IntType>()
                .Name("paymentMethodId")
                .Description("Id of payment method");
            descriptor.Field("PaymentMethod")
                .Type<PaymentMethodType>()
                .Name("paymentMethod")
                .Resolve(context =>
                {
                    var bill = context.Parent<Bill>();
                    return context.Service<IPaymentMethodService>().GetPaymentMethodById(bill.PaymentMethodId);
                })
                .Description("Order list of the bill");
            descriptor.Field("Orders")
                .Type<ListType<OrderType>>()
                .Name("orders")
                .Resolve(context =>
                {
                    var bill = context.Parent<Bill>();
                    return context.Service<IOrderService>().GetOrdersByBillId(bill.Id);
                })
                .Description("Order list of the bill");
            descriptor.Field("FoodOrders")
                .Type<ListType<FoodOrderType>>()
                .Name("foodOrders")
                .Resolve(context =>
                {
                    var bill = context.Parent<Bill>();
                    var orders = context.Service<IOrderService>().GetOrdersByBillId(bill.Id);

                    var foodOrders = new List<FoodOrder>();
                    foreach (var order in orders)
                    {
                        foodOrders.AddRange(
                            context.Service<IFoodOrderService>().GetFoodOrdersByOrderId(order.Id));
                    }

                    var result = foodOrders
                    .GroupBy(o => o.FoodId)
                    .Select(group => new FoodOrder
                    {
                        FoodId = group.Key,
                        Quantity = group.Sum(f => f.Quantity),
                        UnitPrice = group.First().UnitPrice,
                    }).ToList();

                    return result;
                })
                .Description("Food order list of the bill");
        }
    }
}
