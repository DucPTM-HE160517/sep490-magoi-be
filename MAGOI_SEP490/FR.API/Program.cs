using FR.API.GraphQL.Mutations;
using FR.API.GraphQL.Queries;
using FR.API.GraphQL.Types;
using FR.BusinessObjects.DataContext;
using FR.DataAccess;
using FR.Services.IService;
using FR.Services.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var allowAllOrigins = "_allowAllOrigins";
// Add services to the container.
var configBuilder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
IConfigurationRoot configuration = configBuilder.Build();

builder.Services.AddDbContext<DBContext>(options =>
{
    options.UseNpgsql(configuration.GetConnectionString("FRdb"));
});


builder.Services.AddCors(options =>
{
    options.AddPolicy(allowAllOrigins,
                 builder =>
                 {
                     builder
                     .AllowAnyOrigin()
                     .AllowAnyMethod()
                     .AllowAnyHeader();
                 });
});


builder.Services.AddScoped<FoodDAO>()
                .AddScoped<FoodCategoryDAO>()
                .AddScoped<TableDAO>()
                .AddScoped<TableStatusDAO>()
                .AddScoped<OrderDAO>()
                .AddScoped<FoodOrderDAO>()
                .AddScoped<IFoodService, FoodService>()
                .AddScoped<IFoodCategoryService, FoodCategoryService>()
                .AddScoped<ITableService, TableService>()
                .AddScoped<ITableStatusService, TableStatusService>()
                .AddScoped<IOrderService, OrderService>()
                .AddScoped<IFoodOrderService, FoodOrderService>();

builder.Services.AddGraphQLServer()
    .RegisterDbContext<DBContext>(DbContextKind.Synchronized)
    .RegisterService<FoodDAO>(ServiceKind.Synchronized)
    .RegisterService<FoodCategoryDAO>(ServiceKind.Synchronized)
    .RegisterService<TableDAO>(ServiceKind.Synchronized)
    .RegisterService<TableStatusDAO>(ServiceKind.Synchronized)
    .RegisterService<OrderDAO>(ServiceKind.Synchronized)
    .RegisterService<FoodOrderDAO>(ServiceKind.Synchronized)
    .RegisterService<IFoodService>(ServiceKind.Synchronized)
    .RegisterService<IFoodCategoryService>(ServiceKind.Synchronized)
    .RegisterService<ITableService>(ServiceKind.Synchronized)
    .RegisterService<ITableStatusService>(ServiceKind.Synchronized)
    .RegisterService<IOrderService>(ServiceKind.Synchronized)
    .RegisterService<IFoodOrderService>(ServiceKind.Synchronized)
    .AddQueryType<Queries>()
    .AddMutationType<Mutations>()
    .AddTypes(new[] { typeof(FoodType), typeof(FoodCategoryType), typeof(TableType), typeof(TableStatusType), typeof(FoodOrderType), typeof(OrderType) });
//.AddType<FoodType>()
//.AddType<FoodCategoryType>()
//.AddType<TableType>()
//.AddType<TableStatusType>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//app.UseHttpsRedirection();

app.UseGraphQLGraphiQL();

app.UseRouting();

app.UseCors(allowAllOrigins);
app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Run();