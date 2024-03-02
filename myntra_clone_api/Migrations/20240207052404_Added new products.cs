using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myntra_clone_api.Migrations
{
    /// <inheritdoc />
    public partial class Addednewproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Color", "Description", "ProductImage", "ProductName" },
                values: new object[] { "Blue", "Men's Cotton Rich Solid Polo T-Shirt Regular Fit (Available in Plus Size)", "https://m.media-amazon.com/images/I/713n+TxyfCL._AC_UL480_QL65_.jpg", "Amazon Brand - Symbol" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Color", "Description", "DiscountedPrice", "IsCOD", "MainCategory", "MaterialCare", "OriginalPrice", "ProductDetails", "ProductImage", "ProductName", "Rating", "Sellers", "Size", "SizeFit", "SubCategory" },
                values: new object[] { 2, "Topwear", "Blue", "Lymio Men T-Shirt || T-Shirt for Men || Plain T Shirt || T-Shirt (Rib)", 349.0, false, "Men", "Cotton,Machine Wash", 4999.0, "Green Tshirt for men,Other solid,Regular length,Polo collar,Short, regular sleeves,Knitted cotton fabric", "https://m.media-amazon.com/images/I/71AEwEupFuL._SL1500_.jpg", "Lymio", 3.7999999999999998, "Lymio INDUSTRIES LIMITED", "M", "Regular Fit,The model (height 6') is wearing a size M", "T-Shirts" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Color", "Description", "ProductImage", "ProductName" },
                values: new object[] { "Red", "Pack of 2 Polo Collar T-shirt", "Men", "Lux Cozi" });
        }
    }
}
