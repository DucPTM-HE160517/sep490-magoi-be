﻿using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Types
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
            descriptor.Field(f => f.TotalAmount)
                .Type<NonNullType<FloatType>>()
                .Name("totalAmount")
                .Description("The total amount of the bill");
            descriptor.Field(f => f.FeedbackId)
                .Type<UuidType>()
                .Name("feedbackId")
                .Description("Id of order's feedback");
            descriptor.Field("Orders")
                .Type<ListType<OrderType>>()
                .Name("orders")
                .Resolve(context =>
                {
                    var bill = context.Parent<Bill>();
                    return context.Service<IOrderService>().GetOrdersByBillId(bill.Id);
                })
                .Description("Order list of the bill");
        }
    }
}
