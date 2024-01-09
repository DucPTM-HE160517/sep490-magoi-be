var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

builder.Services.AddGraphQLServer();
    //.AddQueryType<FoodQueries>()
    //.AddType<FoodType>()
    //.AddType<FoodCategoryType>()
    //.AddType<RestaurantType>();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseGraphQLGraphiQL();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Run();