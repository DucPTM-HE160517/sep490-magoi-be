using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Types
{
    public class FoodOrderType : ObjectType<FoodOrder>
    {

        //Featured by ThuongTTHE16355 31/01/2024
        //Define GraphQL Types of Order
        protected override void Configure(IObjectTypeDescriptor<FoodOrder> descriptor)
        {
            descriptor.Description("FoodOrder");
            descriptor.Field(f => f.OrderId)
                .Type<UuidType>()
                .Name("OrderId")
                .Description("The ID of the order");
            descriptor.Field(f => f.FoodId)
                .Type<IntType>()
                .Name("FoodId")
                .Description("The ID of the Food"); 
            descriptor.Field(f => f.Quantity)
                .Type<IntType>()
                .Name("Quantity")
                .Description("Quantity of the order"); 
            descriptor.Field(f => f.FoodNote)
                .Type<StringType>()
                .Name("FoodNote")
                .Description("Note the food in this order"); 
            descriptor.Field(f => f.OrderAt)
                .Type<DateTimeType>()
                .Name("OrderAt")
                .Description("Time of the the food when added to order");
        }
    }
}
