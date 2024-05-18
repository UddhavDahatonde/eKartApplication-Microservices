﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Product.Infrastructure.DataContext;

#nullable disable

namespace Product.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Product.Core.Domain.Entities.Category", b =>
                {
                    b.Property<int?>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Footwear"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Apparel"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Home & Office"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Bags & Luggage"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Appliances"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "Sports & Fitness"
                        },
                        new
                        {
                            CategoryId = 8,
                            Name = "Health & Beauty"
                        },
                        new
                        {
                            CategoryId = 9,
                            Name = "Books"
                        },
                        new
                        {
                            CategoryId = 10,
                            Name = "Toys & Games"
                        },
                        new
                        {
                            CategoryId = 11,
                            Name = "Jewelry"
                        },
                        new
                        {
                            CategoryId = 12,
                            Name = "Tools & Home Improvement"
                        },
                        new
                        {
                            CategoryId = 13,
                            Name = "Pet Supplies"
                        },
                        new
                        {
                            CategoryId = 14,
                            Name = "Garden & Outdoor"
                        });
                });

            modelBuilder.Entity("Product.Core.Domain.Entities.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("QuantityAvailable")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isInStock")
                        .HasColumnType("bit");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Powerful laptop with latest features",
                            Discount = 10,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Laptop",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2360),
                            Name = "Laptop",
                            Price = 999.99m,
                            QuantityAvailable = 50,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2361),
                            isInStock = true
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "High-performance smartphone with advanced camera",
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Smartphone",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2365),
                            Name = "Smartphone",
                            Price = 799.99m,
                            QuantityAvailable = 100,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2365),
                            isInStock = true
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Description = "Comfortable running shoes with breathable material",
                            Discount = 20,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Shoes",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2369),
                            Name = "Running Shoes",
                            Price = 79.99m,
                            QuantityAvailable = 200,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2369),
                            isInStock = true
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            Description = "High-quality wireless headphones with noise cancellation",
                            Discount = 15,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Headphones",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2373),
                            Name = "Wireless Headphones",
                            Price = 129.99m,
                            QuantityAvailable = 75,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2374),
                            isInStock = true
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3,
                            Description = "Casual t-shirt made from soft cotton fabric",
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=T-Shirt",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2377),
                            Name = "T-Shirt",
                            Price = 19.99m,
                            QuantityAvailable = 300,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2377),
                            isInStock = false
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 4,
                            Description = "Modern desk lamp with adjustable brightness",
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Lamp",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2380),
                            Name = "Desk Lamp",
                            Price = 39.99m,
                            QuantityAvailable = 50,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2381),
                            isInStock = true
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 5,
                            Description = "Durable backpack with multiple compartments",
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Backpack",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2384),
                            Name = "Backpack",
                            Price = 49.99m,
                            QuantityAvailable = 100,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2384),
                            isInStock = false
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 6,
                            Description = "Automatic coffee maker with programmable features",
                            Discount = 5,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Coffee+Maker",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2387),
                            Name = "Coffee Maker",
                            Price = 89.99m,
                            QuantityAvailable = 30,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2388),
                            isInStock = true
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 5,
                            Description = "Classic leather wallet with multiple card slots",
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Wallet",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2390),
                            Name = "Leather Wallet",
                            Price = 29.99m,
                            QuantityAvailable = 150,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2391),
                            isInStock = true
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 1,
                            Description = "High-performance gaming mouse with customizable buttons",
                            Discount = 10,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Gaming+Mouse",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2395),
                            Name = "Gaming Mouse",
                            Price = 59.99m,
                            QuantityAvailable = 80,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2395),
                            isInStock = true
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 2,
                            Description = "Lightweight running shorts with moisture-wicking fabric",
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Shorts",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2398),
                            Name = "Running Shorts",
                            Price = 34.99m,
                            QuantityAvailable = 120,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2398),
                            isInStock = true
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 1,
                            Description = "Portable external hard drive with high-speed data transfer",
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Hard+Drive",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2401),
                            Name = "External Hard Drive",
                            Price = 119.99m,
                            QuantityAvailable = 40,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2401),
                            isInStock = false
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 7,
                            Description = "Premium yoga mat with non-slip surface",
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Yoga+Mat",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2408),
                            Name = "Yoga Mat",
                            Price = 29.99m,
                            QuantityAvailable = 90,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2409),
                            isInStock = true
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 8,
                            Description = "High SPF sunscreen for protection against UV rays",
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Sunscreen",
                            InsertedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2412),
                            Name = "Sunscreen",
                            Price = 14.99m,
                            QuantityAvailable = 200,
                            UpdatedDate = new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2413),
                            isInStock = true
                        });
                });

            modelBuilder.Entity("Product.Core.Domain.Entities.Products", b =>
                {
                    b.HasOne("Product.Core.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Product.Core.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
