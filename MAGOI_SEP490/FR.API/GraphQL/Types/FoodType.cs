using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Types
{
    public class FoodType : ObjectType<Food>
    {
        protected override void Configure(IObjectTypeDescriptor<Food> descriptor)
        {
            descriptor.Description("The food");
            descriptor.Field(f => f.Id)
                .Type<IntType>()
                .Name("ID")
                .Description("The ID of the food");
            descriptor.Field(f => f.Name)
                .Type<StringType>()
                .Name("Name")
                .Description("Name of the food");
            descriptor.Field(f => f.Description)
                .Type<StringType>()
                .Name("Description")
                .Description("The description of the food");
            descriptor.Field(f => f.Price)
                .Type<StringType>()
                .Name("Price")
                .Description("The price of the food");
            descriptor.Field(f => f.FoodCategoryId)
                .Type<StringType>()
                .Name("FoodCategoryId")
                .Description("The categoryId of the food");
        }
    }
}
