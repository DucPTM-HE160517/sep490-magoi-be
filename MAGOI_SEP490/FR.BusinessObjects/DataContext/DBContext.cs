using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using demo.Models;
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
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("FRdb"));
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCharacteristics> FoodCharacteristics { get; set; }
        public virtual DbSet<Characteristics> Characteristics { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<TableStatus> TableStatus { get; set; }
        public virtual DbSet<FoodOrder> FoodOrder { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            optionsBuilder.Entity<FoodOrder>()
                .HasKey(t => new {t.OrderId, t.FoodId});
            optionsBuilder.Entity<FoodCharacteristics>()
                .HasKey(t => new { t.FoodId, t.CharacteristicId });

            //seed data
            optionsBuilder.SeedData();
        }
    }
}
