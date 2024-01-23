using FR.BusinessObjects.Models;

namespace FR.API.GraphQL.Types
{
    public class FoodCategoryType : ObjectType<FoodCategory>
    {
        protected override void Configure(IObjectTypeDescriptor<FoodCategory> descriptor)
        {
            descriptor.Description("The categoriy of the food");
            descriptor.Field(f => f.Id)
                .Type<IntType>()
                .Name("ID")
                .Description("The ID of the category");
            descriptor.Field(f => f.Category)
                .Type<StringType>()
                .Name("Name")
                .Description("Name of the category");
        }
    }
}
