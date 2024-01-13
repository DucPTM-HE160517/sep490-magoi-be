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

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<RolePermission> RolePermission { get; set; }
        public virtual DbSet<PermissionResource> PermissionResource { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<RestaurantCategory> RestaurantCategories { get; set; }
        public virtual DbSet<UserRestaurant> UserRestaurant { get; set; }
        public virtual DbSet<UserFoodWishlist> UserFoodWishlist { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillStatus> BillStatus { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<FoodOrder> FoodOrder { get; set; }
        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            //config models - Role, Permission, Resource - RolePermission, PermissionResource
            //Food, FoodCategory - Restaurant, RestaurantCategory - User, UserFoodWishList, UserRestaurant - Table
            //Order, OrderStatus - FoodOrder - Bill, BillStatus
            // Join-table: RolePermission, PermissionResource, UserFoodWishList, UserRestaurant, FoodOrder
            optionsBuilder.Entity<RolePermission>()
                .HasKey(t => new {t.RoleId, t.PermissionId});
            optionsBuilder.Entity<PermissionResource>()
                .HasKey(t => new {t.PermissionId, t.ResourceId});
            optionsBuilder.Entity<UserFoodWishlist>()
                .HasKey(t => new {t.UserId, t.FoodId});
            optionsBuilder.Entity<UserRestaurant>()
                .HasKey(t => new {t.UserId, t.RestaurantId});
            optionsBuilder.Entity<FoodOrder>()
                .HasKey(t => new {t.OrderId, t.FoodId});

            //seed data
            optionsBuilder.SeedData();
        }
    }
}
