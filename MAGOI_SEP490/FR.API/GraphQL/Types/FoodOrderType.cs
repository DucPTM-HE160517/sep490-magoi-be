using FR.BusinessObjects.Models;
using FR.Services.IService;

namespace FR.API.GraphQL.Types
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
                .Resolve(context =>
                {
                    var foodOrder = context.Parent<FoodOrder>();
                    return context.Service<IFoodService>().GetFoodById(foodOrder.FoodId).Name;
                })
                .Description("Name of the Food");
            descriptor.Field(f => f.Quantity)
                .Type<IntType>()
                .Name("quantity")
                .Description("Quantity of the food in the order");
            descriptor.Field(f => f.FoodNote)
                .Type<StringType>()
                .Name("note")
                .Description("Note the food in this order");
            descriptor.Field(f => f.OrderAt)
                .Type<DateTimeType>()
                .Name("orderAt")
                .Description("Time of the food when being added to order");
            descriptor.Field("UnitPrice")
                .Type<FloatType>()
                .Name("unitPrice")
                .Resolve(context =>
                {
                    var foodOrder = context.Parent<FoodOrder>();
                    return context.Service<IFoodService>().GetFoodById(foodOrder.FoodId).UnitPrice;
                })
                .Description("Unit price of the food in the order");
        }
    }
}
