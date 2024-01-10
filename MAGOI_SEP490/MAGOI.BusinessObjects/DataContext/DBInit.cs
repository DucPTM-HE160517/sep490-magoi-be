using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAGOI.BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using NpgsqlTypes;

namespace MAGOI.BusinessObjects.DataContext
{
    public static class DBInit
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    RestaurantId= 1,
                    Name= "Hanoi Cuisine 1925",
                    Address= "80B P. Mã Mây, Phố cổ Hà Nội, Hoàn Kiếm, Hà Nội 100000, Việt Nam",
                    Hotline= "0866168021",
                    Email= "hncuisine@gmail.com",
                    CreatedAt= DateTime.Now,
                },
                new Restaurant
                {
                    RestaurantId = 2,
                    Name = "Vietnamese Cuisine Restaurant",
                    Address = "9 Đinh Tiên Hoàng, Hàng Trống, Hoàn Kiếm, Hà Nội",
                    Hotline = "099977584",
                    Email = "vncuisine@gmail.com",
                    CreatedAt = DateTime.Now,
                },
                new Restaurant
                {
                    RestaurantId = 3,
                    Name = "Oven d'Or Restaurant",
                    Address = "Sheraton Hotel, K5 Nghi Tam, Road, 11 Đ. Xuân Diệu, Quảng An, Tây Hồ, Hà Nội, Việt Nam",
                    Hotline = "0903420955",
                    Email = "sheratonhanoi@gmail.com",
                    CreatedAt = DateTime.Now,
                }
            );

            modelBuilder.Entity<FoodCategory>().HasData(
                new FoodCategory
                {
                    FoodCategoryId= 1,
                    Name= "Đồ uống",
                    Description= "Danh mục này bao gồm các loại đồ uống như cà phê, trà, nước ép, nước ngọt và các loại thức uống khác.\r\n",
                },
                new FoodCategory
                {
                    FoodCategoryId = 2,
                    Name = "Món chính",
                    Description = "Đây là danh mục chứa các món ăn chính, thường là các món có thịt, cá hoặc rau củ.",
                },
                new FoodCategory
                {
                    FoodCategoryId = 3,
                    Name = "Món tráng miệng",
                    Description = "Danh mục này bao gồm các loại tráng miệng như bánh ngọt, kem, hoa quả hay các món tráng miệng truyền thống.",
                },
                new FoodCategory
                {
                    FoodCategoryId = 4,
                    Name = "Món nhẹ",
                    Description = "Đây là danh mục chứa các món ăn nhẹ như salad, canapé, bánh mì, hoặc các món ăn nhẹ dùng như bữa ăn phụ.",
                },
                new FoodCategory
                {
                    FoodCategoryId = 5,
                    Name = "Món nước",
                    Description = "Danh mục này bao gồm các loại món ăn được chế biến từ nước, chẳng hạn như các món canh, súp, hoặc mì nước.",
                }
            );

            modelBuilder.Entity<Food>().HasData(
                new Food
                {
                    Id = 1,
                    Name= "Cà phê đen",
                    Description = "Một tách cà phê đen đậm đà, nguyên chất từ hạt cà phê Arabica.",
                    Price = 30000,
                    CreatedAt = DateTime.Now,
                    FoodCategoryId= 1,
                    RestaurantId= 1
                },
                new Food
                {
                    Id = 2,
                    Name = "Trà bưởi",
                    Description = "Trà xanh kết hợp với hương vị bưởi tự nhiên, thơm ngon và thanh mát.",
                    Price = 25000,
                    CreatedAt = DateTime.Now,
                    FoodCategoryId = 1,
                    RestaurantId =2
                },
                new Food
                {
                    Id = 3,
                    Name = "Cơm gà Hải Nam",
                    Description = "Gà quay thơm ngon, phục vụ cùng cơm trắng và xốt đậm đà.",
                    Price = 60000,
                    CreatedAt = DateTime.Now,
                    FoodCategoryId = 2,
                    RestaurantId =1
                },
                new Food
                {
                    Id = 4,
                    Name = "Bún bò Huế",
                    Description = "Một phần bún nước dùng đậm đà kết hợp với thịt bò, huyết và chả.",
                    Price = 50000,
                    CreatedAt = DateTime.Now,
                    FoodCategoryId = 2,
                    RestaurantId =2
                },
                new Food
                {
                    Id = 5,
                    Name = "Bánh tiramisu",
                    Description = "Một loại bánh ngọt với hương vị cà phê đặc trưng và kem tươi mịn.",
                    Price = 40000,
                    CreatedAt = DateTime.Now,
                    FoodCategoryId = 3,
                    RestaurantId =3
                },
                new Food
                {
                    Id = 6,
                    Name = "Chè đậu xanh",
                    Description = "Chè truyền thống Việt Nam với đậu xanh, nước cốt dừa và đường ",
                    Price = 35000,
                    CreatedAt = DateTime.Now,
                    FoodCategoryId = 3,
                    RestaurantId =3
                },
                new Food
                {
                    Id = 7,
                    Name = "Bánh mì kẹp thịt",
                    Description = "Bánh mì mỏng, nướng giòn kết hợp với thịt, rau sống và sốt mỡ.",
                    Price = 40000,
                    CreatedAt = DateTime.Now,
                    FoodCategoryId = 4,
                    RestaurantId =3
                },
                new Food
                {
                    Id = 8,
                    Name = "Salad Cesar",
                    Description = "Một phần salad phong cách Cesar với rau, phô mai và sốt đặc trưng.",
                    Price = 45000,
                    CreatedAt = DateTime.Now,
                    FoodCategoryId = 4,
                    RestaurantId =3
                },
                new Food
                {
                    Id = 9,
                    Name = "Canh chua cá",
                    Description = "Một tô phở nước dùng từ xương gà, kèm theo thịt gà và gia vị.",
                    Price = 55000,
                    CreatedAt = DateTime.Now,
                    FoodCategoryId = 5,
                    RestaurantId =3
                },
                new Food
                {
                    Id = 10,
                    Name = "Phở gà",
                    Description = "Canh chua với chất axit nhẹ từ dấm, ngọt từ cá và thơm từ rau sống.",
                    Price = 45000,
                    CreatedAt = DateTime.Now,
                    FoodCategoryId = 5,
                    RestaurantId =3
                }
            );
        }
    }
} 
       
