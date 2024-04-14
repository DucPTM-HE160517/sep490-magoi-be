using FR.BusinessObjects.Models;
using FR.Services.IService;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
{
    public class FoodOrderType : ObjectType<FoodOrder>
    {
        protected override void Configure(IObjectTypeDescriptor<FoodOrder> descriptor)
        {
            descriptor.Description("FoodOrder");
            descriptor.Field(f => f.OrderId)
                .Type<UuidType>()
                .Name("id")
                .Description("The ID of the order");
            descriptor.Field(f => f.FoodId)
                .Type<IntType>()
                .Name("foodId")
                .Description("The ID of the Food");
            descriptor.Field("Name")
                .Type<StringType>()
                .Name("name")
                .Resolve(async context =>
                {
                    var foodOrder = context.Parent<FoodOrder>();
                    return (await context.Service<IFoodService>().GetFoodById(foodOrder.FoodId)).Name;
                })
                .Description("Name of the Food");
            descriptor.Field(f => f.Quantity)
                .Type<IntType>()
                .Name("quantity")
                .Description("Quantity of the food in the order");
            descriptor.Field(f => f.UnitPrice)
                .Type<FloatType>()
                .Name("unitPrice")
                .Description("Unit price of the food in the order");
            descriptor.Field(f => f.FoodNote)
                .Type<StringType>()
                .Name("note")
                .Description("Note the food in this order");
            descriptor.Field(f => f.OrderAt)
                .Type<DateTimeType>()
                .Name("orderAt")
                .Description("Time of the food when being added to order");
            descriptor.Field(f => f.UnitPrice * f.Quantity)
                .Type<FloatType>()
                .Name("totalAmount")
                .Description("Total amount of the foods in the order");
        }
    }
}
