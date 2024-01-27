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
                .Name("id")
                .Description("The ID of the food");
            descriptor.Field(f => f.Name)
                .Type<StringType>()
                .Name("name")
                .Description("Name of the food");
            descriptor.Field(f => f.Description)
                .Type<StringType>()
                .Name("description")
                .Description("The description of the food");
            descriptor.Field(f => f.ImageUrl)
                .Type<StringType>()
                .Name("imageUrl")
                .Description("The image of the food");
            descriptor.Field(f => f.Price)
                .Type<FloatType>()
                .Name("price")
                .Description("The price of the food");
            descriptor.Field(f => f.Quantity)
                .Type<IntType>()
                .Name("quantity")
                .Description("The quantity of the food");
            descriptor.Field(f => f.CreatedAt)
                .Type<DateType>()
                .Name("createdDate")
                .Description("The created date of the food");
            descriptor.Field(f => f.FoodCategoryId)
                .Type<IntType>()
                .Name("foodCategoryId")
                .Description("The category's id of the food");
            descriptor.Field("Category")
                .Type<FoodCategoryType>()
                .Name("category")
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
