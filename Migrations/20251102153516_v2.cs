using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_Project.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Electronic devices and gadgets", "Electronics" },
                    { 2, "Fashion and apparel items", "Clothing" },
                    { 3, "Books and educational materials", "Books" },
                    { 4, "Home appliances and kitchen tools", "Home & Kitchen" },
                    { 5, "Sports equipment and accessories", "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "15.6 inch, Intel i5, 8GB RAM, 256GB SSD", "Laptop HP ProBook", 15000.00m },
                    { 2, 1, "128GB, Space Black", "iPhone 14 Pro", 35000.00m },
                    { 3, 1, "4K Smart LED TV", "Samsung TV 55 inch", 12000.00m },
                    { 4, 1, "Logitech M185, 2.4GHz", "Wireless Mouse", 250.00m },
                    { 5, 2, "Cotton, Size L, Black", "Nike T-Shirt", 350.00m },
                    { 6, 2, "Size 42, Blue and White", "Adidas Running Shoes", 1200.00m },
                    { 7, 2, "Blue Denim, Size 32", "Levi's Jeans", 800.00m },
                    { 8, 3, "By Robert C. Martin", "Clean Code", 450.00m },
                    { 9, 3, "Gang of Four", "Design Patterns", 500.00m },
                    { 10, 3, "Your Journey To Mastery", "The Pragmatic Programmer", 480.00m },
                    { 11, 4, "1000W, Stainless Steel", "Blender 3-in-1", 650.00m },
                    { 12, 4, "5 pieces, Tefal", "Non-Stick Pan Set", 1500.00m },
                    { 13, 4, "Nespresso, Automatic", "Coffee Maker", 2200.00m },
                    { 14, 5, "Size 5, Official Match Ball", "Football - Adidas", 450.00m },
                    { 15, 5, "6mm thickness, Anti-slip", "Yoga Mat", 280.00m },
                    { 16, 5, "2x5kg, Rubber Coated", "Dumbbells Set", 550.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
