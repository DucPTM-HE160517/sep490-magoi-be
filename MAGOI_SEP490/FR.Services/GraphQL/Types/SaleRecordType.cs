using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
{
    public class SaleRecord
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Order> ServingOrders { get; set; }
        public List<Order> ServedOrders { get; set; }
        public int[] BillsPerHour { get; set; }
        public Food[] FoodRank { get; set; }
    }
    public class SaleRecordType : ObjectType<SaleRecord>
    {
        protected override void Configure(IObjectTypeDescriptor<SaleRecord> descriptor)
        {
            descriptor.Field(sr => sr.StartDate)
                .Type<DateTimeType>()
                .Name("startDate")
                .Description("Start date of the sale record");
            descriptor.Field(sr => sr.EndDate)
                .Type<DateTimeType>()
                .Name("endDate")
                .Description("End date of the sale record");
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
