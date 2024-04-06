using FR.BusinessObjects.Models;
using FR.Services.IService;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR.Services.GraphQL.Types
{
    public class FoodOrderCategory
    {
        public FoodOrderCategory() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FoodOrder> FoodOrders { get; set; }
    }
    public class FoodOrderCategoryType : ObjectType<FoodOrderCategory>
    {
        protected override void Configure(IObjectTypeDescriptor<FoodOrderCategory> descriptor)
        {
            descriptor.Description("The category of the food");
            descriptor.Field(f => f.Id)
                .Type<IntType>()
                .Name("id")
                .Description("The ID of the category");
            descriptor.Field(f => f.Name)
                .Type<StringType>()
                .Name("name")
                .Description("Name of the category");
            descriptor.Field("FoodOrderList")
                .Type<ListType<FoodOrderType>>()
                .Name("foodOrders")
                .Description("List of food order of the category");
        }
    }
}
