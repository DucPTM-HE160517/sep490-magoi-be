﻿// <auto-generated />
using System;
using FR.BusinessObjects.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FR.BusinessObjects.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20240123141733_GenerateData")]
    partial class GenerateData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FR.BusinessObjects.Models.Bill", b =>
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

            modelBuilder.Entity("FR.BusinessObjects.Models.Characteristics", b =>
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Characteristic = "Món chay"
                        },
                        new
                        {
                            Id = 2,
                            Characteristic = "Món nóng"
                        },
                        new
                        {
                            Id = 3,
                            Characteristic = "Món lạnh"
                        },
                        new
                        {
                            Id = 4,
                            Characteristic = "Món nước"
                        },
                        new
                        {
                            Id = 5,
                            Characteristic = "Món nướng"
                        },
                        new
                        {
                            Id = 6,
                            Characteristic = "Thức ăn nhanh"
                        },
                        new
                        {
                            Id = 7,
                            Characteristic = "Món cay"
                        },
                        new
                        {
                            Id = 8,
                            Characteristic = "Dành cho người ăn kiêng"
                        },
                        new
                        {
                            Id = 9,
                            Characteristic = "Dành cho người tập gym"
                        },
                        new
                        {
                            Id = 10,
                            Characteristic = "Dành cho dịp lễ"
                        },
                        new
                        {
                            Id = 11,
                            Characteristic = "Bánh"
                        },
                        new
                        {
                            Id = 12,
                            Characteristic = "Kem"
                        },
                        new
                        {
                            Id = 13,
                            Characteristic = "Nước ép"
                        },
                        new
                        {
                            Id = 14,
                            Characteristic = "Sinh tố"
                        },
                        new
                        {
                            Id = 15,
                            Characteristic = "Nước ngọt"
                        },
                        new
                        {
                            Id = 16,
                            Characteristic = "Trà"
                        },
                        new
                        {
                            Id = 17,
                            Characteristic = "Bia"
                        },
                        new
                        {
                            Id = 18,
                            Characteristic = "Rượu vang"
                        },
                        new
                        {
                            Id = 19,
                            Characteristic = "Nước chấm"
                        },
                        new
                        {
                            Id = 20,
                            Characteristic = "Món chiên rán"
                        },
                        new
                        {
                            Id = 21,
                            Characteristic = "Bò tiêu chuẩn"
                        },
                        new
                        {
                            Id = 22,
                            Characteristic = "Bò cao cấp"
                        },
                        new
                        {
                            Id = 23,
                            Characteristic = "Bò thượng hạng"
                        },
                        new
                        {
                            Id = 24,
                            Characteristic = "Hải sản"
                        },
                        new
                        {
                            Id = 25,
                            Characteristic = "Thịt cừu"
                        },
                        new
                        {
                            Id = 26,
                            Characteristic = "Thịt lợn"
                        },
                        new
                        {
                            Id = 27,
                            Characteristic = "Thịt gà"
                        },
                        new
                        {
                            Id = 28,
                            Characteristic = "Thịt vịt"
                        });
                });

            modelBuilder.Entity("FR.BusinessObjects.Models.Feedback", b =>
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

            modelBuilder.Entity("FR.BusinessObjects.Models.Food", b =>
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
                            CreatedAt = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Xúc xích cỡ lớn 300g với đồ muối chua",
                            FoodCategoryId = 1,
                            ImageUrl = "big-beerfest-bausages.jpg",
                            Name = "BIG BEERFEST SAUSAGES",
                            Price = 199000f,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Xúc xích Đức nướng ăn kèm salad rau tổng hợp",
                            FoodCategoryId = 1,
                            ImageUrl = "grilled-german-gausages.jpg",
                            Name = "GRILLED GERMAN SAUSAGES",
                            Price = 136000f,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Bánh mì bơ tỏi",
                            FoodCategoryId = 1,
                            ImageUrl = "garlic-bread.jpg",
                            Name = "GARLIC BREAD",
                            Price = 30000f,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Khoai tây chiên",
                            FoodCategoryId = 1,
                            ImageUrl = "french-fried.jpg",
                            Name = "FRENCH FRIED",
                            Price = 50f,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Cánh gà nướng BBQ ăn kèm Salad, khoai tây chiên (2 cánh)",
                            FoodCategoryId = 1,
                            ImageUrl = "chicken-wings.jpg",
                            Name = "CHICKEN WINGS",
                            Price = 86000f,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Đĩa tổng hợp các loại khoai chiên",
                            FoodCategoryId = 1,
                            ImageUrl = "beer-batter-fries.jpg",
                            Name = "BEER BATTER FRIES",
                            Price = 99000f,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Gan Ngỗng áp chảo cùng Mứt, sốt xoài và bánh mỳ Pháp nướng",
                            FoodCategoryId = 1,
                            ImageUrl = "pan-seared-foie-gras.jpg",
                            Name = "PAN SEARED FOIE-GRAS",
                            Price = 196000f,
                            Quantity = 100
                        });
                });

            modelBuilder.Entity("FR.BusinessObjects.Models.FoodCategory", b =>
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
                            Category = "Món khai vị"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Món chính"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Đồ ăn kèm"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Salad"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Soup"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Nước sốt"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Đồ uống"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Món tráng miệng"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Pasta"
                        });
                });

            modelBuilder.Entity("FR.BusinessObjects.Models.FoodCharacteristics", b =>
                {
                    b.Property<int>("FoodId")
                        .HasColumnType("integer");

                    b.Property<int>("CharacteristicId")
                        .HasColumnType("integer");

                    b.HasKey("FoodId", "CharacteristicId");

                    b.ToTable("FoodCharacteristics");
                });

            modelBuilder.Entity("FR.BusinessObjects.Models.FoodOrder", b =>
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

            modelBuilder.Entity("FR.BusinessObjects.Models.Order", b =>
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

            modelBuilder.Entity("FR.BusinessObjects.Models.OrderStatus", b =>
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

            modelBuilder.Entity("FR.BusinessObjects.Models.Table", b =>
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

            modelBuilder.Entity("FR.BusinessObjects.Models.TableStatus", b =>
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
#pragma warning restore 612, 618
        }
    }
}