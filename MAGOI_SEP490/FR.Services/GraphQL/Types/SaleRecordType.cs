using FR.BusinessObjects.Models;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
{
    public class SaleRecord
    {
        public DateTime Date { get; set; }
        public float Revenue { get; set; }
        public List<Order> ServingOrders { get; set; }
        public List<Order> ServedOrders { get; set; }
        public int[] BillsPerHour { get; set; }
        public Food[] FoodRank { get; set; }
    }
    public class SaleRecordType : ObjectType<SaleRecord>
    {
        protected override void Configure(IObjectTypeDescriptor<SaleRecord> descriptor)
        {
            descriptor.Field(sr => sr.Date)
                .Type<DateTimeType>()
                .Name("date")
                .Description("The date of the sale record");
            descriptor.Field(sr => sr.Revenue)
                .Type<DateTimeType>()
                .Name("revenue")
                .Description("Total income in the time range");
            descriptor.Field(sr => sr.ServingOrders)
                .Type<ListType<OrderType>>()
                .Name("servingOrders")
                .Description("List of serving orders in the time range");
            descriptor.Field(sr => sr.ServedOrders)
                .Type<ListType<OrderType>>()
                .Name("servedOrders")
                .Description("List of served orders in the time range");
            descriptor.Field(sr => sr.BillsPerHour)
                .Type<ListType<IntType>>()
                .Name("billsPerHour")
                .Description("Amount of bills per hour in the time range");
            descriptor.Field(sr => sr.FoodRank)
                .Type<ListType<FoodType>>()
                .Name("foodRank")
                .Description("List of top 5 most ordered food");
        }
    }
}
