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
            descriptor.Field(f => f.ImageUrl)
                .Type<StringType>()
                .Name("ImageUrl")
                .Description("The image of the food");
            descriptor.Field(f => f.Price)
                .Type<FloatType>()
                .Name("Price")
                .Description("The price of the food");
            descriptor.Field(f => f.Quantity)
                .Type<IntType>()
                .Name("Quantity")
                .Description("The quantity of the food");
            descriptor.Field(f => f.CreatedAt)
                .Type<DateType>()
                .Name("CreatedDate")
                .Description("The created date of the food");
            descriptor.Field(f => f.FoodCategoryId)
                .Type<IntType>()
                .Name("FoodCategoryId")
                .Description("The categoryId of the food");
        }
    }
}
