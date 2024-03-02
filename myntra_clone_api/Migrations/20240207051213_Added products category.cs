using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myntra_clone_api.Migrations
{
    /// <inheritdoc />
    public partial class Addedproductscategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCOD",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainCategory",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubCategory",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Category", "IsCOD", "MainCategory", "SubCategory" },
                values: new object[] { "Topwear", true, "Men", "T-Shirts" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsCOD",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MainCategory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SubCategory",
                table: "Products");
        }
    }
}
