using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace myntra_clone_api.Migrations
{
    /// <inheritdoc />
    public partial class addedproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    OriginalPrice = table.Column<double>(type: "float", nullable: true),
                    DiscountedPrice = table.Column<double>(type: "float", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sellers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeFit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialCare = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductSpecification",
                columns: table => new
                {
                    SpecificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecificationKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecificationValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecification", x => x.SpecificationId);
                });

            migrationBuilder.InsertData(
                table: "ProductSpecification",
                columns: new[] { "SpecificationId", "ProductId", "SpecificationKey", "SpecificationValue" },
                values: new object[,]
                {
                    { 1, 1, "Fabrick", "Cotton" },
                    { 2, 1, "Fit", "Regular Fit" },
                    { 3, 1, "Length", "Regular" },
                    { 4, 1, "Main Trend", "New Basic" },
                    { 5, 1, "MultiPack Set", "2" },
                    { 6, 1, "Collar", "Polo Collar" },
                    { 7, 1, "No of Items", "2" },
                    { 8, 1, "Ocasion", "Casual" },
                    { 9, 1, "Package Contains", "2 tshirts" },
                    { 10, 1, "Patern", "Solid" },
                    { 11, 1, "Pattern Coverage", "Placement" },
                    { 12, 1, "Sleeve Length", "Short Sleeve" },
                    { 13, 1, "Sleeve Styling", "Regular Sleeve" },
                    { 14, 1, "Surface Stylying", "Applique" },
                    { 15, 1, "Sustainable", "Regular" },
                    { 16, 1, "Wash Care", "Machine Wash" },
                    { 17, 1, "Weave Type", "Knitted" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Color", "Description", "DiscountedPrice", "MaterialCare", "OriginalPrice", "ProductDetails", "ProductImage", "ProductName", "Rating", "Sellers", "Size", "SizeFit" },
                values: new object[] { 1, "Red", "Pack of 2 Polo Collar T-shirt", 722.0, "Cotton,Machine Wash", 760.0, "Red Tshirt for men,Pack of 2,Other solid,Regular length,Polo collar,Short, regular sleeves,Knitted cotton fabric", "Men", "Lux Cozi", 4.5, "LUX INDUSTRIES LIMITED", "S", "Regular Fit,The model (height 6') is wearing a size M" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductSpecification");
        }
    }
}
