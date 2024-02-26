using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Types
{
    public class BillType : ObjectType<Bill>
    {
        protected override void Configure(IObjectTypeDescriptor<Bill> descriptor)
        {
            descriptor.Description("The bill of the order");
            descriptor.Field(f => f.Id)
                .Type<NonNullType<UuidType>>()
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
                .Type<NonNullType<FloatType>>()
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
        }
    }
}
