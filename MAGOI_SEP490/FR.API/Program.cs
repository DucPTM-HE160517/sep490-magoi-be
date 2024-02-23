using FR.API.GraphQL.Mutations;
using FR.API.GraphQL.Queries;
using FR.API.GraphQL.Subscriptions;
using FR.API.GraphQL.Types;
using FR.BusinessObjects.DataContext;
using FR.DataAccess;
using FR.Services.IService;
using FR.Services.Service;
using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);
var allowAllOrigins = "_allowAllOrigins";
var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

// Add services to the container.
var configBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();
IConfigurationRoot configuration = configBuilder.Build();

builder.Services.AddDbContext<DBContext>(options =>
{
    var conStrBuilder = new NpgsqlConnectionStringBuilder(
        configuration.GetConnectionString("FRdb"));

    //check if the environment is development, then use the password from the environment variable
    if (environmentName == "Production")
    {
        //Set connection string password from environment variable
        //As Azure Key Vault is not free, so I will hard code the password here
        conStrBuilder.Password = "pEUE3bGrZdHfl5xY";
    }
    Console.WriteLine(conStrBuilder.ConnectionString);

    options.UseNpgsql(conStrBuilder.ConnectionString);
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
                .AddScoped<SessionDAO>()
                .AddScoped<BillDAO>()
                .AddScoped<IFoodService, FoodService>()
                .AddScoped<IFoodCategoryService, FoodCategoryService>()
                .AddScoped<ITableService, TableService>()
                .AddScoped<ITableStatusService, TableStatusService>()
                .AddScoped<IOrderService, OrderService>()
                .AddScoped<IExpoNotificationService, ExpoNotificationService>()
                .AddScoped<IFoodOrderService, FoodOrderService>()
                .AddScoped<IBankService, BankService>()
                .AddScoped<ISessionService, SessionService>();

builder.Services.AddGraphQLServer().AddInMemorySubscriptions()
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
    .RegisterService<IExpoNotificationService>(ServiceKind.Synchronized)
    .RegisterService<ISessionService>(ServiceKind.Synchronized)
    .RegisterService<IBankService>(ServiceKind.Synchronized)
    .AddQueryType<Queries>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscriptions>()
    .AddTypes(new[] { typeof(FoodType), typeof(FoodCategoryType), typeof(TableType), typeof(TableStatusType), 
        typeof(FoodOrderType), typeof(OrderType) });

var app = builder.Build();

// Configure the HTTP request pipeline.
//app.UseHttpsRedirection();

app.UseGraphQLGraphiQL();

app.UseRouting();

app.UseWebSockets();

app.UseCors(allowAllOrigins);
app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Run();