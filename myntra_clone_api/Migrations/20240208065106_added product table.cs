using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myntra_clone_api.Migrations
{
    /// <inheritdoc />
    public partial class addedproducttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSpecification",
                table: "ProductSpecification");

            migrationBuilder.RenameTable(
                name: "ProductSpecification",
                newName: "ProductSpecifications");

            migrationBuilder.AddColumn<int>(
                name: "ProductsProductId",
                table: "ProductSpecifications",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSpecifications",
                table: "ProductSpecifications",
                column: "SpecificationId");

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 1,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 2,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 3,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 4,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 5,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 6,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 7,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 8,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 9,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 10,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 11,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 12,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 13,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 14,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 15,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 16,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 17,
                column: "ProductsProductId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecifications_ProductsProductId",
                table: "ProductSpecifications",
                column: "ProductsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_Products_ProductsProductId",
                table: "ProductSpecifications",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_Products_ProductsProductId",
                table: "ProductSpecifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSpecifications",
                table: "ProductSpecifications");

            migrationBuilder.DropIndex(
                name: "IX_ProductSpecifications_ProductsProductId",
                table: "ProductSpecifications");

            migrationBuilder.DropColumn(
                name: "ProductsProductId",
                table: "ProductSpecifications");

            migrationBuilder.RenameTable(
                name: "ProductSpecifications",
                newName: "ProductSpecification");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSpecification",
                table: "ProductSpecification",
                column: "SpecificationId");
        }
    }
}
