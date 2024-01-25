using FR.API.GraphQL.Queries;
using FR.API.GraphQL.Types;
using FR.BusinessObjects.DataContext;
using FR.DataAccess;
using FR.Services.IService;
using FR.Services.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configBuilder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
IConfigurationRoot configuration = configBuilder.Build();

builder.Services.AddDbContext<DBContext>(options =>
{
    options.UseNpgsql(configuration.GetConnectionString("FRdb"));
});

builder.Services.AddScoped<FoodDAO>();
builder.Services.AddScoped<FoodCategoryDAO>();
builder.Services.AddScoped<IFoodService, FoodService>();
builder.Services.AddScoped<IFoodCategoryService, FoodCategoryService>();

builder.Services.AddGraphQLServer()
    .RegisterDbContext<DBContext>(DbContextKind.Synchronized)
    .RegisterService<FoodDAO>(ServiceKind.Synchronized)
    .RegisterService<FoodCategoryDAO>(ServiceKind.Synchronized)
    .RegisterService<IFoodService>(ServiceKind.Synchronized)
    .RegisterService<IFoodCategoryService>(ServiceKind.Synchronized)
    .AddQueryType<FoodQueries>()
    .AddType<FoodType>()
    .AddType<FoodCategoryType>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseGraphQLGraphiQL();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Run();