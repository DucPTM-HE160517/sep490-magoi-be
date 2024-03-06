using FR.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace FR.BusinessObjects.DataContext
{
    public partial class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
        : base(options)
        {
        }

        public DBContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            //IConfigurationRoot configuration = builder.Build();

            //optionsBuilder.UseNpgsql(configuration.GetConnectionString("FRdb"));
            optionsBuilder.EnableSensitiveDataLogging();
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodLabels> FoodLabels { get; set; }
        public virtual DbSet<Labels> Labels { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<TableStatus> TableStatus { get; set; }
        public virtual DbSet<FoodOrder> FoodOrder { get; set; }
        public virtual DbSet<FoodOrderStatus> FoodOrderStatus { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            optionsBuilder.Entity<FoodOrder>()
                .HasKey(t => new { t.OrderId, t.FoodId });
            optionsBuilder.Entity<FoodLabels>()
                .HasKey(t => new { t.FoodId, t.LabelId });

            //seed data
            optionsBuilder.SeedData();
        }
    }
}