using FR.BusinessObjects.Models;
using FR.Services.IService;

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
            descriptor.Field("Category")
                .Type<FoodCategoryType>()
                .Name("Category")
                .Resolve(context =>
                {
                    var food = context.Parent<Food>();
                    return context.Service<IFoodCategoryService>().GetFoodCategoryById(food.FoodCategoryId);
                })
                .Description("The category of the food");
            //descriptor.Field(f => f.FoodCategoryId)
            //    .Type<IntType>()
            //    .Name("FoodCategoryId")
            //    .Description("The categoryId of the food");
            //descriptor.Field("Category")
            //    .Type<StringType>()
            //    .Name("CategoryName")
            //    .Resolve(context =>
            //    {
            //        var food = context.Parent<Food>();
            //        var category = context.Service<IFoodCategoryService>()
            //        .GetFoodCategoryById(food.FoodCategoryId);
            //        return category?.Category;
            //    })
            //    .Description("The category of the food");
        }
    }
}
