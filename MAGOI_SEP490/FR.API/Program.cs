using MAGOI.API.GraphQL.Queries;
using MAGOI.API.GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddGraphQLServer()
    .AddQueryType<FoodQueries>()
    .AddType<FoodType>()
    .AddType<FoodCategoryType>()
    .AddType<RestaurantType>();

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