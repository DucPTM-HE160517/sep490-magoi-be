﻿// <auto-generated />
using System;
using MAGOI.BusinessObjects.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MAGOI.BusinessObjects.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BusinessObjects.Models.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<float>("TotalAmount")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("BusinessObjects.Models.FoodOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("FoodId")
                        .HasColumnType("integer");

                    b.Property<string>("FoodNote")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("OrderId", "FoodId");

                    b.ToTable("FoodOrder");
                });

            modelBuilder.Entity("MAGOI.BusinessObjects.Models.Characteristics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Characteristic")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Characteristics");
                });

            modelBuilder.Entity("MAGOI.BusinessObjects.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FoodScore")
                        .HasColumnType("integer");

                    b.Property<int>("ServingScore")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("MAGOI.BusinessObjects.Models.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FoodCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu tôm với hương vị đậm đà của nước lẩu Tom Yum.",
                            FoodCategoryId = 1,
                            ImageUrl = "tomyum_goong.jpg",
                            Name = "Tom Yum Goong",
                            Price = 250000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu gà với hương vị đậm đà của nước lẩu Tom Yum.",
                            FoodCategoryId = 1,
                            ImageUrl = "tomyum_gai.jpg",
                            Name = "Tom Yum Gai",
                            Price = 320000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu hải sản với hương vị đậm đà của nước lẩu Tom Yum.",
                            FoodCategoryId = 1,
                            ImageUrl = "tomyum_talay.jpg",
                            Name = "Tom Yum Talay",
                            Price = 180000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu tôm với hương vị đậm đà của nước lẩu Tom Kha và sữa cô cocon",
                            FoodCategoryId = 2,
                            ImageUrl = "tomkha_goong.jpg",
                            Name = "Tom Kha Goong",
                            Price = 160000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu gà với hương vị đậm đà của nước lẩu Tom Kha và với sữa cô cocon",
                            FoodCategoryId = 2,
                            ImageUrl = "tomkha_gai.jpg",
                            Name = "Tom Kha Gai",
                            Price = 130000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu hải sản với hương vị đậm đà của nước lẩu Tom Kha và sữa cô cocon",
                            FoodCategoryId = 2,
                            ImageUrl = "tomkha_talay.jpg",
                            Name = "Tom Kha Talay",
                            Price = 190000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu tôm xanh với hương vị đậm đà của nước lẩu Green Curry.",
                            FoodCategoryId = 3,
                            ImageUrl = "greencurry_goong.jpg",
                            Name = "Green Curry Goong",
                            Price = 170000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu gà với hương vị đậm đà của nước lẩu Green Curry.",
                            FoodCategoryId = 3,
                            ImageUrl = "greencurry_gai.jpg",
                            Name = "Green Curry Gai",
                            Price = 140000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu hải sản với hương vị đậm đà của nước lẩu Green Curry.",
                            FoodCategoryId = 3,
                            ImageUrl = "greencurry_talay.jpg",
                            Name = "Green Curry Talay",
                            Price = 200000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu tôm cay với hương vị đậm đà của nước lẩu Red Curry.",
                            FoodCategoryId = 4,
                            ImageUrl = "spicy_redcurry_goong.jpg",
                            Name = "Spicy Red Curry Goong",
                            Price = 200000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu nấm với hương vị đậm đà của nước lẩu Red Curry.",
                            FoodCategoryId = 4,
                            ImageUrl = "redcurry_mushroom.jpg",
                            Name = "Red Curry Mushroom",
                            Price = 170000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu tôm cay với hương vị đậm đà của nước lẩu Massaman.",
                            FoodCategoryId = 6,
                            ImageUrl = "spicy_massaman_goong.jpg",
                            Name = "Spicy Massaman Curry Goong",
                            Price = 210000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lẩu gà với hương vị đậm đà của nước lẩu Massaman.",
                            FoodCategoryId = 6,
                            ImageUrl = "massaman_chicken.jpg",
                            Name = "Massaman Curry Chicken",
                            Price = 180000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở bò với thịt bò tái mềm ngon.",
                            FoodCategoryId = 7,
                            ImageUrl = "phobo_tai.jpg",
                            Name = "Phở Bò Tái",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở bò với thịt bò tái và chín mềm ngon.",
                            FoodCategoryId = 7,
                            ImageUrl = "phobo_taichin.jpg",
                            Name = "Phở Bò Tái Chín",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở bò với thịt bò chín mềm ngon.",
                            FoodCategoryId = 7,
                            ImageUrl = "phobo_chin.jpg",
                            Name = "Phở Bò Chín",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở bò với thịt bò nạm mềm ngon.",
                            FoodCategoryId = 7,
                            ImageUrl = "phobo_nam.jpg",
                            Name = "Phở Bò Nạm",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở bò với thịt bò gân mềm ngon.",
                            FoodCategoryId = 7,
                            ImageUrl = "phobo_gan.jpg",
                            Name = "Phở Bò Gân",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở bò với thịt bò sách mềm ngon.",
                            FoodCategoryId = 7,
                            ImageUrl = "phobo_sach.jpg",
                            Name = "Phở Bò Sách",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 20,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở gà với thịt gà đùi mềm ngon.",
                            FoodCategoryId = 8,
                            ImageUrl = "phoga_dui.jpg",
                            Name = "Phở Gà Đùi",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 21,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở gà với thịt gà lườn mềm ngon.",
                            FoodCategoryId = 8,
                            ImageUrl = "phoga_luon.jpg",
                            Name = "Phở Gà Lườn",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 22,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở gà với thịt gà cánh mềm ngon.",
                            FoodCategoryId = 8,
                            ImageUrl = "phoga_canh.jpg",
                            Name = "Phở Gà Cánh",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 23,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở gà với thịt gà và tim cật.",
                            FoodCategoryId = 8,
                            ImageUrl = "phoga_timcat.jpg",
                            Name = "Phở Gà Tim Cật",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 24,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở chay với nước dùng và đậu hũ.",
                            FoodCategoryId = 9,
                            ImageUrl = "phochay_dauhu.jpg",
                            Name = "Phở Chay Đậu Hũ",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 25,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở chay với nước dùng và đậu hũ.",
                            FoodCategoryId = 9,
                            ImageUrl = "phochay_nam.jpg",
                            Name = "Phở Chay Nấm",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 26,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở với sườn bò mềm ngon.",
                            FoodCategoryId = 10,
                            ImageUrl = "phosuon_bo.jpg",
                            Name = "Phở Sườn Bò",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 27,
                            CreatedAt = new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Phở với sườn heo mềm ngon.",
                            FoodCategoryId = 10,
                            ImageUrl = "phosuon_heo.jpg",
                            Name = "Phở Sườn Heo",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 28,
                            CreatedAt = new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Salad trộn với rau sống và sốt truyền thống.",
                            FoodCategoryId = 11,
                            ImageUrl = "salad_tron.jpg",
                            Name = "Salad Trộn",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 29,
                            CreatedAt = new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Salad với cá ngừ và sốt truyền thống.",
                            FoodCategoryId = 11,
                            ImageUrl = "salad_cangu.jpg",
                            Name = "Salad Cá Ngừ",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 30,
                            CreatedAt = new DateTime(2015, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Salad gà và bơ avocado với sốt vinaigrette.",
                            FoodCategoryId = 11,
                            ImageUrl = "chicken_avocado_salad.jpg",
                            Name = "Chicken Avocado Salad",
                            Price = 70000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 31,
                            CreatedAt = new DateTime(2015, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Salad Caesar truyền thống với sốt mayonnaise và phô mai.",
                            FoodCategoryId = 11,
                            ImageUrl = "caesar_salad.jpg",
                            Name = "Caesar Salad",
                            Price = 90000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 32,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bánh mì tỏi nướng giòn thơm phức.",
                            FoodCategoryId = 12,
                            ImageUrl = "garlic_bread.jpg",
                            Name = "Garlic Bread",
                            Price = 50000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 33,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Cocktail tôm tươi ngon với sốt cay lạnh.",
                            FoodCategoryId = 12,
                            ImageUrl = "shrimp_cocktail.jpg",
                            Name = "Shrimp Cocktail",
                            Price = 120000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 34,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bruschetta nấm phô mai với dầu ôliu.",
                            FoodCategoryId = 12,
                            ImageUrl = "mushroom_bruschetta.jpg",
                            Name = "Mushroom Bruschetta",
                            Price = 90000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 35,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Vỏ khoai tây nướng với phô mai và thịt xông khói.",
                            FoodCategoryId = 12,
                            ImageUrl = "potato_skins.jpg",
                            Name = "Potato Skins",
                            Price = 110000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 36,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ớt chuông nhồi phô mai, nướng giòn.",
                            FoodCategoryId = 12,
                            ImageUrl = "cheese_stuffed_jalapenos.jpg",
                            Name = "Cheese Stuffed Jalapeños",
                            Price = 95000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 37,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Tartare cá ngừ với sốt hạt tiêu và cần tây.",
                            FoodCategoryId = 12,
                            ImageUrl = "tuna_tartare.jpg",
                            Name = "Tuna Tartare",
                            Price = 120000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 38,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ceviche tôm với cà chua, dưa leo, và hành tây.",
                            FoodCategoryId = 12,
                            ImageUrl = "shrimp_ceviche.jpg",
                            Name = "Shrimp Ceviche",
                            Price = 110000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 39,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đĩa cá hồi hút khói phục vụ với bánh mì và kem cheese.",
                            FoodCategoryId = 12,
                            ImageUrl = "smoked_salmon_platter.jpg",
                            Name = "Smoked Salmon Platter",
                            Price = 630000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 40,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Carpaccio bò với rucola, phô mai parmesan, và sốt mù tạt.",
                            FoodCategoryId = 12,
                            ImageUrl = "beef_carpaccio.jpg",
                            Name = "Beef Carpaccio",
                            Price = 440000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 41,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Filet Mignon steak với nước sốt đặc biệt.",
                            FoodCategoryId = 13,
                            ImageUrl = "filet_mignon.jpg",
                            Name = "Filet Mignon",
                            Price = 350000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 42,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ribeye steak chảo nước sốt tiêu xanh.",
                            FoodCategoryId = 13,
                            ImageUrl = "ribeye_steak.jpg",
                            Name = "Ribeye Steak",
                            Price = 290000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 43,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "T-bone steak với gia vị hảo hạng.",
                            FoodCategoryId = 13,
                            ImageUrl = "t_bone_steak.jpg",
                            Name = "T-bone Steak",
                            Price = 750000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 44,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "New York Strip steak với nước sốt hạt tiêu.",
                            FoodCategoryId = 13,
                            ImageUrl = "new_york_strip.jpg",
                            Name = "New York Strip",
                            Price = 380000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 45,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Porterhouse steak nướng chín với ớt và tỏi.",
                            FoodCategoryId = 13,
                            ImageUrl = "porterhouse_steak.jpg",
                            Name = "Porterhouse Steak",
                            Price = 620000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 46,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sirloin steak với sốt hành tỏi.",
                            FoodCategoryId = 13,
                            ImageUrl = "sirloin_steak.jpg",
                            Name = "Sirloin Steak",
                            Price = 550000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 47,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Flank steak với gia vị tỏi và hạt tiêu.",
                            FoodCategoryId = 13,
                            ImageUrl = "flank_steak.jpg",
                            Name = "Flank Steak",
                            Price = 380000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 48,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Prime Rib steak nướng chín với muối và hạt tiêu.",
                            FoodCategoryId = 13,
                            ImageUrl = "prime_rib_steak.jpg",
                            Name = "Prime Rib",
                            Price = 450000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 49,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Skirt steak với gia vị đặc biệt.",
                            FoodCategoryId = 13,
                            ImageUrl = "skirt_steak.jpg",
                            Name = "Skirt Steak",
                            Price = 420000f,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 50,
                            CreatedAt = new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Chateaubriand steak với sốt nước sốt đậm đà.",
                            FoodCategoryId = 13,
                            ImageUrl = "chateaubriand_steak.jpg",
                            Name = "Chateaubriand",
                            Price = 670000f,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("MAGOI.BusinessObjects.Models.FoodCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("FoodCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Lẩu Tom Yum"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Lẩu Tom Kha"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Lẩu Green Curry"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Lẩu Red Curry"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Lẩu Massaman"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Phở Bò"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Phở Gà"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Phở Chay"
                        },
                        new
                        {
                            Id = 10,
                            Category = "Phở Sườn"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Salad"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Món Khai Vị"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Món Lạnh"
                        },
                        new
                        {
                            Id = 14,
                            Category = "Steak"
                        });
                });

            modelBuilder.Entity("MAGOI.BusinessObjects.Models.FoodCharacteristics", b =>
                {
                    b.Property<int>("FoodId")
                        .HasColumnType("integer");

                    b.Property<int>("CharacteristicId")
                        .HasColumnType("integer");

                    b.HasKey("FoodId", "CharacteristicId");

                    b.ToTable("FoodCharacteristics");
                });

            modelBuilder.Entity("MAGOI.BusinessObjects.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("MAGOI.BusinessObjects.Models.TableStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TableStatus");
                });

            modelBuilder.Entity("demo.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BillId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("FeedbackId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("integer");

                    b.Property<int>("TableId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("demo.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Tables");
                });
#pragma warning restore 612, 618
        }
    }
}
