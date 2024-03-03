using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace myntra_clone_api.Migrations
{
    /// <inheritdoc />
    public partial class addednewcategoriestable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "MainCategory" },
                values: new object[,]
                {
                    { 1, "Topwear", "Men" },
                    { 2, "Bottomwear", "Men" },
                    { 3, "Footwear", "Men" },
                    { 4, "Sports & Active Wears", "Men" },
                    { 5, "Fashion Accessories", "Men" },
                    { 6, "Indian & Festive Wears", "Men" },
                    { 7, "Inner Wear & Sleep Wear", "Men" },
                    { 8, "Plus Size", "Men" },
                    { 9, "Personsal Care & Grooming", "Men" },
                    { 10, "Sunglasses & Frames", "Men" },
                    { 11, "Watches", "Men" },
                    { 12, "Gadgets", "Men" },
                    { 13, "Bags & Backpacks", "Men" },
                    { 14, "Luggages & Trolleys", "Men" },
                    { 15, "Indian & Fusion Wear", "Women" },
                    { 16, "Western Wear", "Women" },
                    { 17, "Maternity", "Women" },
                    { 18, "Belt Scarves & More", "Women" },
                    { 19, "Watches & Wearables", "Women" },
                    { 20, "Plus Size", "Women" },
                    { 21, "Sunglasses & Frames", "Women" },
                    { 22, "Footwears", "Women" },
                    { 23, "Sports & Active Wear", "Women" },
                    { 24, "Lingeries & Sleepwear", "Women" },
                    { 25, "Beauty & Personal Care", "Women" },
                    { 26, "Gadgets", "Women" },
                    { 27, "Jwellery", "Women" },
                    { 28, "Backpacks", "Women" },
                    { 29, "Handbags Bags & Wallets", "Women" },
                    { 30, "Luggages & Trolleys", "Women" },
                    { 31, "BoysClothing", "Kids" },
                    { 32, "GirlsClothing", "Kids" },
                    { 33, "Footwear", "Kids" },
                    { 34, "Toys & Games", "Kids" },
                    { 35, "Infants", "Kids" },
                    { 36, "Home & Bath", "Kids" },
                    { 37, "Personal Care", "Kids" },
                    { 38, "Kids Accessories", "Kids" },
                    { 39, "Brands", "Kids" },
                    { 40, "Bed Linen & Furnishing", "Home&Living" },
                    { 41, "Bath", "Home&Living" },
                    { 42, "Flooring", "Home&Living" },
                    { 43, "Lamps & Lighting", "Home&Living" },
                    { 44, "Home Decor", "Home&Living" },
                    { 45, "Cushions & Cushion Covers", "Home&Living" },
                    { 46, "Curtains", "Home&Living" },
                    { 47, "Home Gift Sets", "Home&Living" },
                    { 48, "Kitchens & Table", "Home&Living" },
                    { 49, "Storage", "Home&Living" },
                    { 50, "Brands", "Home&Living" },
                    { 51, "Makeup", "Beauty" },
                    { 52, "Skincare Bath & Body", "Beauty" },
                    { 53, "Baby Care", "Beauty" },
                    { 54, "Masks", "Beauty" },
                    { 55, "Haircare", "Beauty" },
                    { 56, "Fragrances", "Beauty" },
                    { 57, "Appliances", "Beauty" },
                    { 58, "Men's Grooming", "Beauty" },
                    { 59, "Beauty Gift & Makeup Set", "Beauty" },
                    { 60, "Premium Beauty", "Beauty" },
                    { 61, "Wellness & Hygiene", "Beauty" },
                    { 62, "Top Brands", "Beauty" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "MainCategoryId", "MainCategoryName" },
                values: new object[,]
                {
                    { 1, "Men" },
                    { 2, "Women" },
                    { 3, "Kids" },
                    { 4, "Home & Living" },
                    { 5, "Beauty" }
                });

            migrationBuilder.InsertData(
                table: "ProductSpecifications",
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
                columns: new[] { "ProductId", "Category", "Color", "Description", "DiscountedPrice", "IsCOD", "MainCategory", "MaterialCare", "OriginalPrice", "ProductDetails", "ProductImage", "ProductName", "Rating", "Sellers", "Size", "SizeFit", "SubCategory" },
                values: new object[,]
                {
                    { 1, "Topwear", "Blue", "Men's Cotton Rich Solid Polo T-Shirt Regular Fit (Available in Plus Size)", 722.0, true, "Men", "Cotton,Machine Wash", 760.0, "Red Tshirt for men,Pack of 2,Other solid,Regular length,Polo collar,Short, regular sleeves,Knitted cotton fabric", "https://m.media-amazon.com/images/I/713n+TxyfCL._AC_UL480_QL65_.jpg", "Amazon Brand - Symbol", 4.5, "LUX INDUSTRIES LIMITED", "S", "Regular Fit,The model (height 6') is wearing a size M", "T-Shirts" },
                    { 2, "Topwear", "Blue", "Lymio Men T-Shirt || T-Shirt for Men || Plain T Shirt || T-Shirt (Rib)", 349.0, false, "Men", "Cotton,Machine Wash", 4999.0, "Green Tshirt for men,Other solid,Regular length,Polo collar,Short, regular sleeves,Knitted cotton fabric", "https://m.media-amazon.com/images/I/71AEwEupFuL._SL1500_.jpg", "Lymio", 3.7999999999999998, "Lymio INDUSTRIES LIMITED", "M", "Regular Fit,The model (height 6') is wearing a size M", "T-Shirts" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoryId", "Category", "MainCategory", "SubCategoryName" },
                values: new object[,]
                {
                    { 1, "Topwear", "Men", "T-Shirts" },
                    { 2, "Topwear", "Men", "Casual Shirts" },
                    { 3, "Topwear", "Men", "Formal Shirts" },
                    { 4, "Topwear", "Men", "Sweatshirts" },
                    { 5, "Topwear", "Men", "Sweaters" },
                    { 6, "Topwear", "Men", "Jackets" },
                    { 7, "Topwear", "Men", "Blazers & Coats" },
                    { 8, "Topwear", "Men", "Suits" },
                    { 9, "Topwear", "Men", "Rain Jackets" },
                    { 10, "Indian & Festive Wear", "Men", "Kurtas & Kurta Sets" },
                    { 11, "Indian & Festive Wear", "Men", "Sherwanis" },
                    { 12, "Indian & Festive Wear", "Men", "Nehru Jackets" },
                    { 13, "Indian & Festive Wear", "Men", "Dhoti" },
                    { 14, "Bottomwear", "Men", "Jeans" },
                    { 15, "Bottomwear", "Men", "Casual Trousers" },
                    { 16, "Bottomwear", "Men", "Formal Trousers" },
                    { 17, "Bottomwear", "Men", "Shorts" },
                    { 18, "Bottomwear", "Men", "Track Pants & Joggers" },
                    { 19, "Innerwear & Sleepwear", "Men", "Briefs & Trunks" },
                    { 20, "Innerwear & Sleepwear", "Men", "Boxers" },
                    { 21, "Innerwear & Sleepwear", "Men", "Vests" },
                    { 22, "Innerwear & Sleepwear", "Men", "Sleepwear & Loungwear" },
                    { 23, "Innerwear & Sleepwear", "Men", "Thermals" },
                    { 24, "Footwear", "Men", "Casual Shoues" },
                    { 25, "Footwear", "Men", "Sports Shoes" },
                    { 26, "Footwear", "Men", "Formal Shoes" },
                    { 27, "Footwear", "Men", "Sneakers" },
                    { 28, "Footwear", "Men", "Sandals & Floaters" },
                    { 29, "Footwear", "Men", "Flip Flops" },
                    { 30, "Footwear", "Men", "Socks" },
                    { 31, "Sports & Active Wear", "Men", "Sports Shoes" },
                    { 32, "Sports & Active Wear", "Men", "Sport Sandals" },
                    { 33, "Sports & Active Wear", "Men", "Active T-Shirts" },
                    { 34, "Sports & Active Wear", "Men", "Track Pants & Shorts" },
                    { 35, "Sports & Active Wear", "Men", "Tracksuits" },
                    { 36, "Sports & Active Wear", "Men", "Jackets & Sweatshirts" },
                    { 37, "Sports & Active Wear", "Men", "Sports Accessories" },
                    { 38, "Sports & Active Wear", "Men", "Swimwear" },
                    { 39, "Gadgets", "Men", "Smart Wearables" },
                    { 40, "Gadgets", "Men", "Fitness Gadgets" },
                    { 41, "Gadgets", "Men", "Headphones" },
                    { 42, "Gadgets", "Men", "Speakers" },
                    { 43, "Fashion Accessories", "Men", "Socks" },
                    { 44, "Fashion Accessories", "Men", "Wallets" },
                    { 45, "Fashion Accessories", "Men", "Belts" },
                    { 46, "Fashion Accessories", "Men", "Perfumes & Body Mists" },
                    { 47, "Fashion Accessories", "Men", "Trimmers" },
                    { 48, "Fashion Accessories", "Men", "Deodorants" },
                    { 49, "Fashion Accessories", "Men", "Ties,Cufflinks & Pocket Squares" },
                    { 50, "Fashion Accessories", "Men", "Accessory Gift Sets" },
                    { 51, "Fashion Accessories", "Men", "Caps & Hats" },
                    { 52, "Fashion Accessories", "Men", "Phone Cases" },
                    { 53, "Fashion Accessories", "Men", "Rings & Wristwear" },
                    { 54, "Fashion Accessories", "Men", "Helmets" },
                    { 55, "Indian & Fusion Wear", "Women", "Kurtas & Suits" },
                    { 56, "Indian & Fusion Wear", "Women", "Kurtis, Tunic & Tops" },
                    { 57, "Indian & Fusion Wear", "Women", "Sarees" },
                    { 58, "Indian & Fusion Wear", "Women", "Ethnic Wear" },
                    { 59, "Indian & Fusion Wear", "Women", "Leggings, Salwar & Churidars" },
                    { 60, "Indian & Fusion Wear", "Women", "Skirts & Palazzos" },
                    { 61, "Indian & Fusion Wear", "Women", "Dress Materials" },
                    { 62, "Indian & Fusion Wear", "Women", "Lehengas Cholis" },
                    { 63, "Indian & Fusion Wear", "Women", "Dupattas & Shawls" },
                    { 64, "Indian & Fusion Wear", "Women", "Jackets" },
                    { 65, "Western Wear", "Women", "Dresses" },
                    { 66, "Western Wear", "Women", "Tops" },
                    { 67, "Western Wear", "Women", "Tshirts" },
                    { 68, "Western Wear", "Women", "Jeans" },
                    { 69, "Western Wear", "Women", "Trousers & Capris" },
                    { 70, "Western Wear", "Women", "Shorts & Skirts" },
                    { 71, "Western Wear", "Women", "Co-ords" },
                    { 72, "Western Wear", "Women", "Playsuits" },
                    { 73, "Western Wear", "Women", "Shrug" },
                    { 74, "Western Wear", "Women", "Sweaters & Sweatshirts" },
                    { 75, "Western Wear", "Women", "Jackets & Coats" },
                    { 76, "Western Wear", "Women", "Blazers & Waiscoats" },
                    { 77, "Footwear", "Women", "Flats" },
                    { 78, "Footwear", "Women", "Casual Shoes" },
                    { 79, "Footwear", "Women", "Heels" },
                    { 80, "Footwear", "Women", "Boots" },
                    { 81, "Footwear", "Women", "Sports Shoes & Floaters" },
                    { 82, "Sports & Active Wear", "Women", "Clothing" },
                    { 83, "Sports & Active Wear", "Women", "Footwear" },
                    { 84, "Sports & Active Wear", "Women", "Sports Accessories" },
                    { 85, "Sports & Active Wear", "Women", "Sport Equipment" },
                    { 86, "Lingerie & Sleepwear", "Women", "Bra" },
                    { 87, "Lingerie & Sleepwear", "Women", "Briefs" },
                    { 88, "Lingerie & Sleepwear", "Women", "Shapewear" },
                    { 89, "Lingerie & Sleepwear", "Women", "Sleepwears & Loungewear" },
                    { 90, "Lingerie & Sleepwear", "Women", "Swimwear" },
                    { 91, "Lingerie & Sleepwear", "Women", "Camisoles & Thermal" },
                    { 92, "Beauty & Personal Care", "Women", "Makeup" },
                    { 93, "Beauty & Personal Care", "Women", "Skincare" },
                    { 94, "Beauty & Personal Care", "Women", "Premium Beauty" },
                    { 95, "Beauty & Personal Care", "Women", "Lipstic" },
                    { 96, "Beauty & Personal Care", "Women", "Fragrances" },
                    { 97, "Gadgets", "Women", "Smart Wearables" },
                    { 98, "Gadgets", "Women", "Fitness Gadgets" },
                    { 99, "Gadgets", "Women", "Headphones" },
                    { 100, "Gadgets", "Women", "Speakers" },
                    { 101, "Jwellery", "Women", "Fashion Jwellery" },
                    { 102, "Jwellery", "Women", "Fine Jewellery" },
                    { 103, "Jwellery", "Women", "Earrings" },
                    { 104, "Boys Clothing", "Kids", "T-Shirts" },
                    { 105, "Boys Clothing", "Kids", "Shirts" },
                    { 106, "Boys Clothing", "Kids", "Shorts" },
                    { 107, "Boys Clothing", "Kids", "Jeans" },
                    { 108, "Boys Clothing", "Kids", "Trousers" },
                    { 109, "Boys Clothing", "Kids", "Clothing Sets" },
                    { 110, "Boys Clothing", "Kids", "Ethinic Wear" },
                    { 111, "Boys Clothing", "Kids", "Track Pants & Pyjamas" },
                    { 112, "Boys Clothing", "Kids", "Jacket, Sweater & Sweatshirts" },
                    { 113, "Boys Clothing", "Kids", "Party Wear" },
                    { 114, "Boys Clothing", "Kids", "Innerwear & Thermals" },
                    { 115, "Boys Clothing", "Kids", "Nightwear & Loungewear" },
                    { 116, "Boys Clothing", "Kids", "Value Packs" },
                    { 117, "Girls Clothing", "Kids", "Dresses" },
                    { 118, "Girls Clothing", "Kids", "Tops" },
                    { 119, "Girls Clothing", "Kids", "Tshirts" },
                    { 120, "Girls Clothing", "Kids", "Clothing Sets" },
                    { 121, "Girls Clothing", "Kids", "Lehengas choli" },
                    { 122, "Girls Clothing", "Kids", "Kurta Sets" },
                    { 123, "Girls Clothing", "Kids", "Party Wear" },
                    { 124, "Girls Clothing", "Kids", "Dungarees & Jumpsuits" },
                    { 125, "Girls Clothing", "Kids", "Skirts & Leggings" },
                    { 126, "Girls Clothing", "Kids", "Jeans, Trousers & Capris" },
                    { 127, "Girls Clothing", "Kids", "jacket, Sweater & Sweatshirts" },
                    { 128, "Girls Clothing", "Kids", "Innerwear & Thermals" },
                    { 129, "Girls Clothing", "Kids", "Nightwear & Loungewear" },
                    { 130, "Girls Clothing", "Kids", "Value Packs" },
                    { 131, "Footwear", "Kids", "Casual Shoes" },
                    { 132, "Footwear", "Kids", "Flipflops" },
                    { 133, "Footwear", "Kids", "Sports Shoes" },
                    { 134, "Footwear", "Kids", "Flats" },
                    { 135, "Footwear", "Kids", "Sandals" },
                    { 136, "Footwear", "Kids", "Heels" },
                    { 137, "Footwear", "Kids", "School Shoes" },
                    { 138, "Footwear", "Kids", "Socks" },
                    { 139, "Toys & Games", "Kids", "Learning & Development" },
                    { 140, "Toys & Games", "Kids", "Activity Toys" },
                    { 141, "Toys & Games", "Kids", "Soft Toys" },
                    { 142, "Toys & Games", "Kids", "Action Figure / Play set" },
                    { 143, "Infants", "Kids", "Bodysuits" },
                    { 144, "Infants", "Kids", "Rompers & Sleepsuits" },
                    { 145, "Infants", "Kids", "Clothing Sets" },
                    { 146, "Infants", "Kids", "Tshirts & Tops" },
                    { 147, "Infants", "Kids", "Dresses" },
                    { 148, "Infants", "Kids", "Bottom Wear" },
                    { 149, "Infants", "Kids", "Winter Wear" },
                    { 150, "Infants", "Kids", "Innerwear & Sleepwear" },
                    { 151, "Infants", "Kids", "Infant Care" },
                    { 152, "Kids Accessories", "Kids", "Bags & Backpacks" },
                    { 153, "Kids Accessories", "Kids", "Watches" },
                    { 154, "Kids Accessories", "Kids", "Jewellery & Hair accessory" },
                    { 155, "Kids Accessories", "Kids", "Sunglasses" },
                    { 156, "Kids Accessories", "Kids", "Masks & Protective Gears" },
                    { 157, "Kids Accessories", "Kids", "Caps & Hats" },
                    { 158, "Brands", "Kids", "H&M" },
                    { 159, "Brands", "Kids", "Max Kids" },
                    { 160, "Brands", "Kids", "Pantaloons" },
                    { 161, "Brands", "Kids", "United Colors of Benetton Kids" },
                    { 162, "Brands", "Kids", "YK" },
                    { 163, "Brands", "Kids", "U.S. Polo Assn, Kids" },
                    { 164, "Brands", "Kids", "Mothercare" },
                    { 165, "Brands", "Kids", "HRX" },
                    { 166, "Bed Linen & Furnishing", "Home & Living", "Bed Runners" },
                    { 167, "Bed Linen & Furnishing", "Home & Living", "Mattress Protectors" },
                    { 168, "Bed Linen & Furnishing", "Home & Living", "Bedsheets" },
                    { 169, "Bed Linen & Furnishing", "Home & Living", "Bedding Sets" },
                    { 170, "Bed Linen & Furnishing", "Home & Living", "Blankets, Quilts & Dohars" },
                    { 171, "Bed Linen & Furnishing", "Home & Living", "Pillows & Pillow Covers" },
                    { 172, "Bed Linen & Furnishing", "Home & Living", "Bed Covers" },
                    { 173, "Bed Linen & Furnishing", "Home & Living", "Diwan Sets" },
                    { 174, "Bed Linen & Furnishing", "Home & Living", "Chair Pads & Covers" },
                    { 175, "Bed Linen & Furnishing", "Home & Living", "Sofa Covers" },
                    { 176, "Flooring", "Home & Living", "Floor Runners" },
                    { 177, "Flooring", "Home & Living", "Carpets" },
                    { 178, "Flooring", "Home & Living", "Floor Mats Dhurries" },
                    { 179, "Flooring", "Home & Living", "Door Mats" },
                    { 180, "Bath", "Home & Living", "Bath Towels" },
                    { 181, "Bath", "Home & Living", "Hand & Face Towels" },
                    { 182, "Bath", "Home & Living", "Beach Towels" },
                    { 183, "Bath", "Home & Living", "Towels Set" },
                    { 184, "Bath", "Home & Living", "Bath Rugs" },
                    { 185, "Bath", "Home & Living", "Bath Robes" },
                    { 186, "Bath", "Home & Living", "Shower Curtains" },
                    { 187, "Lamps & Lighting", "Home & Living", "Floor Lamps" },
                    { 188, "Lamps & Lighting", "Home & Living", "Ceiling Lamps" },
                    { 189, "Lamps & Lighting", "Home & Living", "Table Lamps" },
                    { 190, "Lamps & Lighting", "Home & Living", "Wall Lamps" },
                    { 191, "Lamps & Lighting", "Home & Living", "Outdoor Lamps" },
                    { 192, "Lamps & Lighting", "Home & Living", "String Lights" },
                    { 193, "Home & Decor", "Home & Living", "Plants & Planters" },
                    { 194, "Home & Decor", "Home & Living", "Aromas & Candles" },
                    { 195, "Home & Decor", "Home & Living", "Clocks" },
                    { 196, "Home & Decor", "Home & Living", "Mirrors" },
                    { 197, "Home & Decor", "Home & Living", "Wall Decor" },
                    { 198, "Home & Decor", "Home & Living", "Festive Decor" },
                    { 199, "Home & Decor", "Home & Living", "Pooja Essentials" },
                    { 200, "Home & Decor", "Home & Living", "Wall Shelves" },
                    { 201, "Home & Decor", "Home & Living", "Fountains" },
                    { 202, "Home & Decor", "Home & Living", "Showpieces & Vases" },
                    { 203, "Home & Decor", "Home & Living", "Ottoman" },
                    { 204, "Kitchen & Table", "Home & Living", "Table Runners" },
                    { 205, "Kitchen & Table", "Home & Living", "Dinnerware & Serveware" },
                    { 206, "Kitchen & Table", "Home & Living", "Cups & Mugs" },
                    { 207, "Kitchen & Table", "Home & Living", "Backware & Cookware" },
                    { 208, "Kitchen & Table", "Home & Living", "Kitchen Storage & tools" },
                    { 209, "Kitchen & Table", "Home & Living", "Bar & Drinkware" },
                    { 210, "Kitchen & Table", "Home & Living", "Table Covers & Furnishings" },
                    { 211, "Storage", "Home & Living", "Bins" },
                    { 212, "Storage", "Home & Living", "Hangers" },
                    { 213, "Storage", "Home & Living", "Organisers" },
                    { 214, "Storage", "Home & Living", "Hooks & Holders" },
                    { 215, "Storage", "Home & Living", "Laundry Bags" },
                    { 216, "Brands", "Home & Living", "H&M" },
                    { 217, "Brands", "Home & Living", "Marks & Spencer" },
                    { 218, "Brands", "Home & Living", "Home Center" },
                    { 219, "Brands", "Home & Living", "Spaces" },
                    { 220, "Brands", "Home & Living", "D'Decor" },
                    { 221, "Brands", "Home & Living", "story&Home" },
                    { 222, "Brands", "Home & Living", "Pure Home & Living" },
                    { 223, "Brands", "Home & Living", "Swayam" },
                    { 224, "Brands", "Home & Living", "Raymond Home" },
                    { 225, "Brands", "Home & Living", "Maspar" },
                    { 226, "Brands", "Home & Living", "My Trident" },
                    { 227, "Brands", "Home & Living", "Cortina" },
                    { 228, "Brands", "Home & Living", "Random" },
                    { 229, "Brands", "Home & Living", "Ellementry" },
                    { 230, "Brands", "Home & Living", "ROMEE" },
                    { 231, "Brands", "Home & Living", "SEJ by Nisha Gupta" },
                    { 232, "Makeup", "Beauty", "Lipstick" },
                    { 233, "Makeup", "Beauty", "Lip Gloss" },
                    { 234, "Makeup", "Beauty", "Mascara" },
                    { 235, "Makeup", "Beauty", "Runners" },
                    { 236, "Makeup", "Beauty", "Eyeliner" },
                    { 237, "Makeup", "Beauty", "Kajal" },
                    { 238, "Makeup", "Beauty", "EyeShadow" },
                    { 239, "Makeup", "Beauty", "Foundation" },
                    { 240, "Makeup", "Beauty", "Primer" },
                    { 241, "Makeup", "Beauty", "Concealer" },
                    { 242, "Makeup", "Beauty", "Campact" },
                    { 243, "Makeup", "Beauty", "Nail Polish" },
                    { 244, "Skincare, Bath & Body", "Beauty", "Face Moisturiser" },
                    { 245, "Skincare, Bath & Body", "Beauty", "Cleanser" },
                    { 246, "Skincare, Bath & Body", "Beauty", "Masks & Peels" },
                    { 247, "Skincare, Bath & Body", "Beauty", "Sunscream" },
                    { 248, "Skincare, Bath & Body", "Beauty", "Facewash" },
                    { 249, "Skincare, Bath & Body", "Beauty", "Eye Cream" },
                    { 250, "Skincare, Bath & Body", "Beauty", "Lip Balm" },
                    { 251, "Skincare, Bath & Body", "Beauty", "Body Lotion" },
                    { 252, "Skincare, Bath & Body", "Beauty", "Body Wash" },
                    { 253, "Skincare, Bath & Body", "Beauty", "Body Scrub" },
                    { 254, "Skincare, Bath & Body", "Beauty", "Hand Cream" },
                    { 255, "Haircare", "Beauty", "Shampoo" },
                    { 256, "Haircare", "Beauty", "Conditioner" },
                    { 257, "Haircare", "Beauty", "Hair Cream" },
                    { 258, "Haircare", "Beauty", "Hair Oil" },
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
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "MainCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "MainCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "MainCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "MainCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MainCategories",
                keyColumn: "MainCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductSpecifications",
                keyColumn: "SpecificationId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 288);
        }
    }
}
