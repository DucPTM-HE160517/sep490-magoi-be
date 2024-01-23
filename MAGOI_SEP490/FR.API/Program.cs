using FR.API.GraphQL.Queries;
using FR.API.GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddGraphQLServer()
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