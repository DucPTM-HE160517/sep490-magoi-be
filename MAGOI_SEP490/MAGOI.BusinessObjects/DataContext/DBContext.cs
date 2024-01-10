using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using MAGOI.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MAGOI.BusinessObjects.DataContext
{
    public partial class DBContext : DbContext
    {
        public DBContext(){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("MagoiDB"));
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            //optionsBuilder.Entity<Order>()
            //.Property(o => o.OrderTime1)
            //.HasColumnType("timestamp with time zone");
            optionsBuilder.SeedData();
        }
    }
}
