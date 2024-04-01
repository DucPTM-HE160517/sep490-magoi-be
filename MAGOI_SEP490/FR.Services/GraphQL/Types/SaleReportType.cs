using FR.BusinessObjects.Models;
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
        public int TotalQuantity { get; set; }
        public float TotalIncome { get; set; }
        public Food Food { get; set; }
    }
    public class SaleReportType : ObjectType<SaleReport>
    {
        protected override void Configure(IObjectTypeDescriptor<SaleReport> descriptor)
        {
            descriptor.Field(f => f.TotalQuantity)
                .Type<IntType>()
                .Name("totalQuantity")
                .Description("The total quantity");

            descriptor.Field(f => f.TotalIncome)
                .Type<FloatType>()
                .Name("totalIncome")
                .Description("The total income");

            descriptor.Field(f => f.Food)
                .Type<FoodType>()
                .Name("food")
                .Description("The food");
        }
    }
}
