using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Product.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class productlisttocategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "QuantityAvailable",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2360), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2365), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2369), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2373), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2377), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2380), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2384), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2387), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2390), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2395), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2398), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2401), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2408), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2412), new DateTime(2024, 5, 13, 12, 21, 44, 204, DateTimeKind.Local).AddTicks(2413) });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.AlterColumn<int>(
                name: "QuantityAvailable",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2405), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2410), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2414), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2419), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2422), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2426), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2430), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2433), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2437), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2445), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2448), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2452), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "InsertedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2455), new DateTime(2024, 4, 20, 13, 54, 26, 704, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
