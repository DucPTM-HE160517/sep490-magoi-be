using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.Services.GraphQL.Types
{
    public class SaleReport
    {
        public SaleReport() { }
        public float TotalIncome { get; set; }
        public List<SaleRevenue> SaleRevenue { get; set; }
    }
    public class SaleReportType : ObjectType<SaleReport>
    {
        protected override void Configure(IObjectTypeDescriptor<SaleReport> descriptor)
        {
            descriptor.Field(f => f.TotalIncome)
                .Type<FloatType>()
                .Name("totalIncome")
                .Description("The total income");
            descriptor.Field(f => f.SaleRevenue)
                .Type<ListType<SaleRevenueType>>()
                .Name("saleRevenue")
                .Description("The sale revenue");
        }
    }
}
