﻿using FR.BusinessObjects.Models;
using FR.Services.IService;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
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
            descriptor.Field(f => f.UnitPrice)
                .Type<FloatType>()
                .Name("unitPrice")
                .Description("The unit price of the food");
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
            descriptor.Field(f => f.IsActive)
                .Type<BooleanType>()
                .Name("foodStatus")
                .Description("The status of the food");
            descriptor.Field("Category")
                .Type<FoodCategoryType>()
                .Name("category")
                .Resolve(context =>
                {
                    var food = context.Parent<Food>();
                    return context.Service<IFoodCategoryService>().GetFoodCategoryById(food.FoodCategoryId);
                })
                .Description("The category of the food");
        }
    }
}
