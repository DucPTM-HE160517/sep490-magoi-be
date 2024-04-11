using System.Reflection.Metadata.Ecma335;
using FR.BusinessObjects.Models;
using FR.Services.IService;
using HotChocolate.Execution;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FR.API.GraphQL.Queries
{
    public partial class Queries
    {
        public IQueryable<FoodCategory> GetCategories(IFoodCategoryService service) => service.GetFoodCategories();
    }
}
