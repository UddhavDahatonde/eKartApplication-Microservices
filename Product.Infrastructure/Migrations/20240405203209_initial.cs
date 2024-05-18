using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Product.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    QuantityAvailable = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Footwear" },
                    { 3, "Apparel" },
                    { 4, "Home & Office" },
                    { 5, "Bags & Luggage" },
                    { 6, "Appliances" },
                    { 7, "Sports & Fitness" },
                    { 8, "Health & Beauty" },
                    { 9, "Books" },
                    { 10, "Toys & Games" },
                    { 11, "Jewelry" },
                    { 12, "Tools & Home Improvement" },
                    { 13, "Pet Supplies" },
                    { 14, "Garden & Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Discount", "ImageUrl", "InsertedDate", "ProductName", "Price", "QuantityAvailable", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, "Powerful laptop with latest features", 10, "https://via.placeholder.com/600x500.png?text=Laptop", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7701), "Laptop", 999.99m, 50, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7702) },
                    { 2, 1, "High-performance smartphone with advanced camera", 0, "https://via.placeholder.com/600x500.png?text=Smartphone", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7707), "Smartphone", 799.99m, 100, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7708) },
                    { 3, 2, "Comfortable running shoes with breathable material", 20, "https://via.placeholder.com/600x500.png?text=Shoes", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7712), "Running Shoes", 79.99m, 200, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7713) },
                    { 4, 1, "High-quality wireless headphones with noise cancellation", 15, "https://via.placeholder.com/600x500.png?text=Headphones", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7717), "Wireless Headphones", 129.99m, 75, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7717) },
                    { 5, 3, "Casual t-shirt made from soft cotton fabric", 0, "https://via.placeholder.com/600x500.png?text=T-Shirt", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7721), "T-Shirt", 19.99m, 300, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7722) },
                    { 6, 4, "Modern desk lamp with adjustable brightness", 0, "https://via.placeholder.com/600x500.png?text=Lamp", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7726), "Desk Lamp", 39.99m, 50, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7727) },
                    { 7, 5, "Durable backpack with multiple compartments", 0, "https://via.placeholder.com/600x500.png?text=Backpack", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7730), "Backpack", 49.99m, 100, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7731) },
                    { 8, 6, "Automatic coffee maker with programmable features", 5, "https://via.placeholder.com/600x500.png?text=Coffee+Maker", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7736), "Coffee Maker", 89.99m, 30, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7737) },
                    { 9, 5, "Classic leather wallet with multiple card slots", 0, "https://via.placeholder.com/600x500.png?text=Wallet", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7740), "Leather Wallet", 29.99m, 150, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7741) },
                    { 10, 1, "High-performance gaming mouse with customizable buttons", 10, "https://via.placeholder.com/600x500.png?text=Gaming+Mouse", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7745), "Gaming Mouse", 59.99m, 80, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7745) },
                    { 11, 2, "Lightweight running shorts with moisture-wicking fabric", 0, "https://via.placeholder.com/600x500.png?text=Shorts", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7749), "Running Shorts", 34.99m, 120, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7749) },
                    { 12, 1, "Portable external hard drive with high-speed data transfer", 0, "https://via.placeholder.com/600x500.png?text=Hard+Drive", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7753), "External Hard Drive", 119.99m, 40, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7753) },
                    { 13, 7, "Premium yoga mat with non-slip surface", 0, "https://via.placeholder.com/600x500.png?text=Yoga+Mat", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7757), "Yoga Mat", 29.99m, 90, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7758) },
                    { 14, 8, "High SPF sunscreen for protection against UV rays", 0, "https://via.placeholder.com/600x500.png?text=Sunscreen", new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7764), "Sunscreen", 14.99m, 200, new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7765) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
