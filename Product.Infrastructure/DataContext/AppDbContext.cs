using Microsoft.EntityFrameworkCore;
using Product.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Infrastructure.DataContext
{
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of see ref<paramref name="AppDbContext"/>
        /// </summary>
        /// <param name="DbContextOptions<AppDbContext>"></param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Products Table
        /// </summary>
        public DbSet<Products> Products { get; set; }
        /// <summary>
        /// Categories Table
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Products>(entity =>
            {
                // Set the primary key
                entity.HasKey(p => p.ProductId);
                entity.Property(p => p.Name).HasMaxLength(100)
                .HasColumnName("ProductName");
                entity.Property(p => p.Name).IsRequired();
                entity.Property(p => p.Price).IsRequired();
                entity.Property(p => p.Price).HasPrecision(precision: 10, scale: 2);
                entity.Property(p => p.QuantityAvailable).IsRequired();
                entity.Property(p => p.QuantityAvailable)
                      .IsRequired()
                      .HasDefaultValue(0)
                      .HasColumnName("QuantityAvailable")
                      .HasColumnType("int");
                entity.Property(p => p.Description)
                .HasMaxLength(2000);
                entity.Property(p => p.ImageUrl).HasMaxLength(500);
                entity.HasOne(p => p.Category)
                                  .WithMany()
                                  .HasForeignKey(p => p.CategoryId)
                                  .IsRequired();
            });
            modelBuilder.Entity<Category>(x =>
            {
                x.HasKey(x => x.CategoryId);
                x.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
            });
            modelBuilder.Entity<Products>().HasData(
                        new Products
                        {
                            ProductId = 1,
                            Name = "Laptop",
                            Description = "Powerful laptop with latest features",
                            Price = 999.99m,
                            QuantityAvailable = 50,
                            CategoryId = 1, // Assuming category ID for Electronics
                            Discount = 10,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Laptop",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                        new Products
                        {
                            ProductId = 2,
                            Name = "Smartphone",
                            Description = "High-performance smartphone with advanced camera",
                            Price = 799.99m,
                            QuantityAvailable = 100,
                            CategoryId = 1, // Assuming category ID for Electronics
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Smartphone",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                        new Products
                        {
                            ProductId = 3,
                            Name = "Running Shoes",
                            Description = "Comfortable running shoes with breathable material",
                            Price = 79.99m,
                            QuantityAvailable = 200,
                            CategoryId = 2, // Assuming category ID for Footwear
                            Discount = 20,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Shoes",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                        new Products
                        {
                            ProductId = 4,
                            Name = "Wireless Headphones",
                            Description = "High-quality wireless headphones with noise cancellation",
                            Price = 129.99m,
                            QuantityAvailable = 75,
                            CategoryId = 1, // Assuming category ID for Electronics
                            Discount = 15,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Headphones",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                        new Products
                        {
                            ProductId = 5,
                            Name = "T-Shirt",
                            Description = "Casual t-shirt made from soft cotton fabric",
                            Price = 19.99m,
                            QuantityAvailable = 300,
                            CategoryId = 3, // Assuming category ID for Apparel
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=T-Shirt",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                        new Products
                        {
                            ProductId = 6,
                            Name = "Desk Lamp",
                            Description = "Modern desk lamp with adjustable brightness",
                            Price = 39.99m,
                            QuantityAvailable = 50,
                            CategoryId = 4, // Assuming category ID for Home & Office
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Lamp",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                        new Products
                        {
                            ProductId = 7,
                            Name = "Backpack",
                            Description = "Durable backpack with multiple compartments",
                            Price = 49.99m,
                            QuantityAvailable = 100,
                            CategoryId = 5, // Assuming category ID for Bags & Luggage
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Backpack",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                        new Products
                        {
                            ProductId = 8,
                            Name = "Coffee Maker",
                            Description = "Automatic coffee maker with programmable features",
                            Price = 89.99m,
                            QuantityAvailable = 30,
                            CategoryId = 6, // Assuming category ID for Appliances
                            Discount = 5,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Coffee+Maker",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                        new Products
                        {
                            ProductId = 9,
                            Name = "Leather Wallet",
                            Description = "Classic leather wallet with multiple card slots",
                            Price = 29.99m,
                            QuantityAvailable = 150,
                            CategoryId = 5, // Assuming category ID for Bags & Luggage
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Wallet",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                        new Products
                        {
                            ProductId = 10,
                            Name = "Gaming Mouse",
                            Description = "High-performance gaming mouse with customizable buttons",
                            Price = 59.99m,
                            QuantityAvailable = 80,
                            CategoryId = 1, // Assuming category ID for Electronics
                            Discount = 10,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Gaming+Mouse",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                        new Products
                        {
                            ProductId = 11,
                            Name = "Running Shorts",
                            Description = "Lightweight running shorts with moisture-wicking fabric",
                            Price = 34.99m,
                            QuantityAvailable = 120,
                            CategoryId = 2, // Assuming category ID for Footwear
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Shorts",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                        new Products
                        {
                            ProductId = 12,
                            Name = "External Hard Drive",
                            Description = "Portable external hard drive with high-speed data transfer",
                            Price = 119.99m,
                            QuantityAvailable = 40,
                            CategoryId = 1, // Assuming category ID for Electronics
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Hard+Drive",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                        new Products
                        {
                            ProductId = 13,
                            Name = "Yoga Mat",
                            Description = "Premium yoga mat with non-slip surface",
                            Price = 29.99m,
                            QuantityAvailable = 90,
                            CategoryId = 7, // Assuming category ID for Sports & Fitness
                            Discount = 0,
                            ImageUrl = "https://via.placeholder.com/600x500.png?text=Yoga+Mat",
                            InsertedDate = DateTime.Now,
                            UpdatedDate = DateTime.Now
                        },
                         new Products
                         {
                             ProductId = 14,
                             Name = "Sunscreen",
                             Description = "High SPF sunscreen for protection against UV rays",
                             Price = 14.99m,
                             QuantityAvailable = 200,
                             CategoryId = 8, // Assuming category ID for Health & Beauty
                             Discount = 0,
                             ImageUrl = "https://via.placeholder.com/600x500.png?text=Sunscreen",
                             InsertedDate = DateTime.Now,
                             UpdatedDate = DateTime.Now
                         });

            modelBuilder.Entity<Category>().HasData(
                               new Category
                               {
                                   CategoryId = 1,
                                   Name = "Electronics"
                               },
                               new Category
                               {
                                   CategoryId = 2,
                                   Name = "Footwear"
                               },
                               new Category
                               {
                                   CategoryId = 3,
                                   Name = "Apparel"
                               },
                               new Category
                               {
                                   CategoryId = 4,
                                   Name = "Home & Office"
                               },
                               new Category
                               {
                                   CategoryId = 5,
                                   Name = "Bags & Luggage"
                               },
                               new Category
                               {
                                   CategoryId = 6,
                                   Name = "Appliances"
                               },
                               new Category
                               {
                                   CategoryId = 7,
                                   Name = "Sports & Fitness"
                               },
                               new Category
                               {
                                   CategoryId = 8,
                                   Name = "Health & Beauty"
                               },
                               new Category
                               {
                                   CategoryId = 9,
                                   Name = "Books"
                               },
                               new Category
                               {
                                   CategoryId = 10,
                                   Name = "Toys & Games"
                               },
                               new Category
                               {
                                   CategoryId = 11,
                                   Name = "Jewelry"
                               },
                               new Category
                               {
                                   CategoryId = 12,
                                   Name = "Tools & Home Improvement"
                               },
                               new Category
                               {
                                   CategoryId = 13,
                                   Name = "Pet Supplies"
                               },
                               new Category
                               {
                                   CategoryId = 14,
                                   Name = "Garden & Outdoor"
                               }) ;

        }
    }
}
