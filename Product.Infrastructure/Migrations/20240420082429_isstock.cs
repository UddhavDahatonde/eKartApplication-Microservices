using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class isstock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isInStock",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2405), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2405), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2410), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2410), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2414), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2414), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2419), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2419), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2422), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2423), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2426), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2427), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2430), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2430), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2433), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2434), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2437), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2437), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2442), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2445), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2445), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2448), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2449), false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2452), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2452), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "InsertedDate", "UpdatedDate", "isInStock" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2455), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2456), true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isInStock",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7701), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7712), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7717), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7721), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7726), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7730), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7736), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7740), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7745), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7749), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7753), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7757), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7764), new DateTime(2024, 4, 6, 2, 2, 8, 918, DateTimeKind.Local).AddTicks(7765) });
        }
    }
}
