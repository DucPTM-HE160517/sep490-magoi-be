﻿using FR.BusinessObjects.Models;
using FR.Services.IService;
using HotChocolate.Types;

namespace FR.Services.GraphQL.Types
{
    public class FoodCategoryType : ObjectType<FoodCategory>
    {
        protected override void Configure(IObjectTypeDescriptor<FoodCategory> descriptor)
        {
            descriptor.Description("The category of the food");
            descriptor.Field(f => f.Id)
                .Type<IntType>()
                .Name("id")
                .Description("The ID of the category");
            descriptor.Field(f => f.Category)
                .Type<StringType>()
                .Name("name")
                .Description("Name of the category");
            descriptor.Field("Foods")
                .Type<ListType<FoodType>>()
                .Name("foods")
                .Resolve(context =>
                {
                    var category = context.Parent<FoodCategory>();
                    return context.Service<IFoodService>().GetFoodsByCategory(category.Id);
                })
                .Description("List of food of the category");
            descriptor.Field("CookingFoods")
                .Type<ListType<FoodType>>()
                .Name("cookingFoods")
                .Resolve(context =>
                {
                    var category = context.Parent<FoodCategory>();
                    return context.Service<IFoodOrderService>().GetCookingFoodsByCategory(category.Id);
                })
                .Description("List of cooking food of the category");
        }
    }
}
