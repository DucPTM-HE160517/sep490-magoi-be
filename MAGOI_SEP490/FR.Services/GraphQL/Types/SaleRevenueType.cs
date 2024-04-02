using FR.BusinessObjects.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.Services.GraphQL.Types
{
    public class SaleRevenue
    {
        public SaleRevenue() { }
        public int Quantity { get; set; }
        public float Income { get; set; }
        public Food Food { get; set; }
    }
    public class SaleRevenueType : ObjectType<SaleRevenue>
    {
        protected override void Configure(IObjectTypeDescriptor<SaleRevenue> descriptor)
        {
            descriptor.Field(f => f.Food)
                .Type<FoodType>()
                .Name("food")
                .Description("The food");
            descriptor.Field(f => f.Quantity)
                .Type<IntType>()
                .Name("quantity")
                .Description("The quantity of food");
            descriptor.Field(f => f.Income)
                .Type<FloatType>()
                .Name("totalIncome")
                .Description("The income of food");
        }
    }
}
