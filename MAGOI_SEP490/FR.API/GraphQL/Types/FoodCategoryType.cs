using MAGOI.BusinessObjects.Models;

namespace MAGOI.API.GraphQL.Types
{
    public class FoodCategoryType : ObjectType<FoodCategory>
    {
        protected override void Configure(IObjectTypeDescriptor<FoodCategory> descriptor)
        {
            descriptor.Description("The categoriy of the food");
            descriptor.Field(f => f.FoodCategoryId)
                .Type<IntType>()
                .Name("ID")
                .Description("The ID of the category");
            descriptor.Field(f => f.Name)
                .Type<StringType>()
                .Name("Name")
                .Description("Name of the category");
            descriptor.Field(f => f.Description)
                .Type<StringType>()
                .Name("Description")
                .Description("The description of the category");
        }
    }
}
