using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace myntra_clone_api.Migrations
{
    /// <inheritdoc />
    public partial class addedcategoris : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            CreateTables(migrationBuilder);
            InsertInitialData(migrationBuilder);
        }

        private static void CreateTables(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                    { 259, "Haircare", "Beauty", "Hair Gel" },
                    { 260, "Haircare", "Beauty", "Hair Color" },
                    { 261, "Haircare", "Beauty", "Hair Serum" },
                    { 262, "Haircare", "Beauty", "Hair Accessory" },
                    { 263, "Frangrances", "Beauty", "Perfume" },
                    { 264, "Frangrances", "Beauty", "Deodorant" },
                    { 265, "Frangrances", "Beauty", "Body Mist" },
                    { 266, "Appliances", "Beauty", "Hair Straightner" },
                    { 267, "Appliances", "Beauty", "Hair Dryer" },
                    { 268, "Appliances", "Beauty", "Epilator" },
                    { 269, "Mens's Grooming", "Beauty", "Trimmers" },
                    { 270, "Mens's Grooming", "Beauty", "Beard Oil" },
                    { 271, "Mens's Grooming", "Beauty", "Hair Wax" },
                    { 272, "Beauty Gift & Makeup Set", "Beauty", "Beauty Gift" },
                    { 273, "Beauty Gift & Makeup Set", "Beauty", "Makeup Kit" },
                    { 274, "Top Brands", "Beauty", "Lakme" },
                    { 275, "Top Brands", "Beauty", "Maybelline" },
                    { 276, "Top Brands", "Beauty", "LOreal" },
                    { 277, "Top Brands", "Beauty", "Philips" },
                    { 278, "Top Brands", "Beauty", "Bath & Body Works" },
                    { 279, "Top Brands", "Beauty", "THE BODY SHOP" },
                    { 280, "Top Brands", "Beauty", "Biotique" },
                    { 281, "Top Brands", "Beauty", "Mamaearth" },
                    { 282, "Top Brands", "Beauty", "MCaffeine" },
                    { 283, "Top Brands", "Beauty", "Nivea" },
                    { 284, "Top Brands", "Beauty", "Lotus Herbals" },
                    { 285, "Top Brands", "Beauty", "LOreal Professionnel" },
                    { 286, "Top Brands", "Beauty", "KAMA AYURVEDA" },
                    { 287, "Top Brands", "Beauty", "M.A.C" },
                    { 288, "Top Brands", "Beauty", "Forest Essentials" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "MainCategories");

            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}