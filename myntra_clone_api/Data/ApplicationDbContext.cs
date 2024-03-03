using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using myntra_clone_api.Models;
using System.Drawing;

namespace myntra_clone_api.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductSpecification> ProductSpecifications { get; set; }
        public DbSet<Promotions> Promotions { get; set; }


        // Only for manual entry to database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed the data for MainCategory            
            var mainCategory = new List<MainCategory>
            {
                new MainCategory()
                {
                    MainCategoryId = 1,
                    MainCategoryName = "Men"
                },
                new MainCategory()
                {
                    MainCategoryId = 2,
                    MainCategoryName = "Women"
                },
                new MainCategory()
                {
                    MainCategoryId = 3,
                    MainCategoryName = "Kids"
                },
                new MainCategory()
                {
                    MainCategoryId = 4,
                    MainCategoryName = "Home & Living"
                },
                new MainCategory()
                {
                    MainCategoryId = 5,
                    MainCategoryName = "Beauty"
                },
            };
            // Seed main category to database
            modelBuilder.Entity<MainCategory>().HasData(mainCategory);


            // Seed the data for Category            
            var category = new List<Category>
            {
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Topwear",
                    MainCategory = "Men"

                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Bottomwear",
                    MainCategory = "Men"

                },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Footwear",
                    MainCategory = "Men"
                },
                new Category()
                {
                    CategoryId = 4,
                    CategoryName = "Sports & Active Wears",
                    MainCategory = "Men"
                },
                new Category()
                {
                    CategoryId = 5,
                    CategoryName = "Fashion Accessories",
                    MainCategory = "Men"
                },
                new Category()
                {
                    CategoryId = 6,
                    CategoryName = "Indian & Festive Wears",
                    MainCategory = "Men"
                },
                new Category()
                {
                    CategoryId = 7,
                    CategoryName = "Inner Wear & Sleep Wear",
                    MainCategory = "Men"
                },
                new Category()
                {
                    CategoryId = 8,
                    CategoryName = "Plus Size",
                    MainCategory = "Men"
                },
                new Category()
                {
                    CategoryId = 9,
                    CategoryName = "Personsal Care & Grooming",
                    MainCategory = "Men"
                },
                new Category()
                {
                    CategoryId = 10,
                    CategoryName = "Sunglasses & Frames",
                    MainCategory = "Men"
                },
                new Category()
                {
                    CategoryId = 11,
                    CategoryName = "Watches",
                    MainCategory = "Men"
                },
                new Category()
                {
                    CategoryId = 12,
                    CategoryName = "Gadgets",
                    MainCategory = "Men"
                },
                new Category()
                {
                    CategoryId =13,
                    CategoryName = "Bags & Backpacks",
                    MainCategory = "Men"
                },
                new Category()
                {
                    CategoryId = 14,
                    CategoryName = "Luggages & Trolleys",
                    MainCategory = "Men"
                },
                new Category()
                {
                    CategoryId = 15,
                    CategoryName = "Indian & Fusion Wear",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 16,
                    CategoryName = "Western Wear",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 17,
                    CategoryName = "Maternity",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 18,
                    CategoryName = "Belt Scarves & More",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 19,
                    CategoryName = "Watches & Wearables",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 20,
                    CategoryName = "Plus Size",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 21,
                    CategoryName = "Sunglasses & Frames",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 22,
                    CategoryName = "Footwears",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 23,
                    CategoryName = "Sports & Active Wear",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 24,
                    CategoryName = "Lingeries & Sleepwear",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 25,
                    CategoryName = "Beauty & Personal Care",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 26,
                    CategoryName = "Gadgets",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 27,
                    CategoryName = "Jwellery",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 28,
                    CategoryName = "Backpacks",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 29,
                    CategoryName = "Handbags Bags & Wallets",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 30,
                    CategoryName = "Luggages & Trolleys",
                    MainCategory = "Women"
                },
                new Category()
                {
                    CategoryId = 31,
                    CategoryName = "BoysClothing",
                    MainCategory = "Kids"
                },
                new Category()
                {
                    CategoryId = 32,
                    CategoryName = "GirlsClothing",
                    MainCategory = "Kids"
                },
                new Category()
                {
                    CategoryId = 33,
                    CategoryName = "Footwear",
                    MainCategory = "Kids"
                },
                new Category()
                {
                    CategoryId = 34,
                    CategoryName = "Toys & Games",
                    MainCategory = "Kids"
                },
                new Category()
                {
                    CategoryId = 35,
                    CategoryName = "Infants",
                    MainCategory = "Kids"
                },
                new Category()
                {
                    CategoryId = 36,
                    CategoryName = "Home & Bath",
                    MainCategory = "Kids"
                },
                new Category()
                {
                    CategoryId = 37,
                    CategoryName = "Personal Care",
                    MainCategory = "Kids"
                },
                new Category()
                {
                    CategoryId = 38,
                    CategoryName = "Kids Accessories",
                    MainCategory = "Kids"
                },
                new Category()
                {
                    CategoryId = 39,
                    CategoryName = "Brands",
                    MainCategory = "Kids"
                },
                new Category()
                {
                    CategoryId = 40,
                    CategoryName = "Bed Linen & Furnishing",
                    MainCategory = "Home&Living"
                },
                new Category()
                {
                    CategoryId = 41,
                    CategoryName = "Bath",
                    MainCategory = "Home&Living"
                },
                new Category()
                {
                    CategoryId = 42,
                    CategoryName = "Flooring",
                    MainCategory = "Home&Living"
                },
                new Category()
                {
                    CategoryId = 43,
                    CategoryName = "Lamps & Lighting",
                    MainCategory = "Home&Living"
                },
                new Category()
                {
                    CategoryId = 44,
                    CategoryName = "Home Decor",
                    MainCategory = "Home&Living"
                },
                new Category()
                {
                    CategoryId = 45,
                    CategoryName = "Cushions & Cushion Covers",
                    MainCategory = "Home&Living"
                },
                new Category()
                {
                    CategoryId = 46,
                    CategoryName = "Curtains",
                    MainCategory = "Home&Living"
                },
                new Category()
                {
                    CategoryId = 47,
                    CategoryName = "Home Gift Sets",
                    MainCategory = "Home&Living"
                },
                new Category()
                {
                    CategoryId = 48,
                    CategoryName = "Kitchens & Table",
                    MainCategory = "Home&Living"
                },
                new Category()
                {
                    CategoryId = 49,
                    CategoryName = "Storage",
                    MainCategory = "Home&Living"
                },
                new Category()
                {
                    CategoryId = 50,
                    CategoryName = "Brands",
                    MainCategory = "Home&Living"
                },
                new Category()
                {
                    CategoryId = 51,
                    CategoryName = "Makeup",
                    MainCategory = "Beauty"
                },
                new Category()
                {
                    CategoryId = 52,
                    CategoryName = "Skincare Bath & Body",
                    MainCategory = "Beauty"
                },
                new Category()
                {
                    CategoryId = 53,
                    CategoryName = "Baby Care",
                    MainCategory = "Beauty"
                },
                new Category()
                {
                    CategoryId = 54,
                    CategoryName = "Masks",
                    MainCategory = "Beauty"
                },
                new Category()
                {
                    CategoryId = 55,
                    CategoryName = "Haircare",
                    MainCategory = "Beauty"
                },
                new Category()
                {
                    CategoryId = 56,
                    CategoryName = "Fragrances",
                    MainCategory = "Beauty"
                },
                new Category()
                {
                    CategoryId = 57,
                    CategoryName = "Appliances",
                    MainCategory = "Beauty"
                },
                 new Category()
                {
                    CategoryId = 58,
                    CategoryName = "Men's Grooming",
                    MainCategory = "Beauty"
                },
                 new Category()
                {
                    CategoryId = 59,
                    CategoryName = "Beauty Gift & Makeup Set",
                    MainCategory = "Beauty"
                },
                  new Category()
                {
                    CategoryId = 60,
                    CategoryName = "Premium Beauty",
                    MainCategory = "Beauty"
                },
                   new Category()
                {
                    CategoryId = 61,
                    CategoryName = "Wellness & Hygiene",
                    MainCategory = "Beauty"
                },
                    new Category()
                {
                    CategoryId = 62,
                    CategoryName = "Top Brands",
                    MainCategory = "Beauty"
                },

            };
            // Seed category to database
            modelBuilder.Entity<Category>().HasData(category);

            // Seed the data for SubCategory            
            var subCategory = new List<SubCategory>
            {
                new SubCategory()
                {
                    SubCategoryId = 1,
                    MainCategory = "Men",
                    Category = "Topwear",
                    SubCategoryName = "T-Shirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 2,
                    MainCategory = "Men",
                    Category = "Topwear",
                    SubCategoryName = "Casual Shirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 3,
                    MainCategory = "Men",
                    Category = "Topwear",
                    SubCategoryName = "Formal Shirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 4,
                    MainCategory = "Men",
                    Category = "Topwear",
                    SubCategoryName = "Sweatshirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 5,
                    MainCategory = "Men",
                    Category = "Topwear",
                    SubCategoryName = "Sweaters"
                },
                new SubCategory()
                {
                    SubCategoryId = 6,
                    MainCategory = "Men",
                    Category = "Topwear",
                    SubCategoryName = "Jackets"
                },
                new SubCategory()
                {
                    SubCategoryId = 7,
                    MainCategory = "Men",
                    Category = "Topwear",
                    SubCategoryName = "Blazers & Coats"
                },
                new SubCategory()
                {
                    SubCategoryId = 8,
                    MainCategory = "Men",
                    Category = "Topwear",
                    SubCategoryName = "Suits"
                },
                new SubCategory()
                {
                    SubCategoryId = 9,
                    MainCategory = "Men",
                    Category = "Topwear",
                    SubCategoryName = "Rain Jackets"
                },
                new SubCategory()
                {
                    SubCategoryId = 10,
                    MainCategory = "Men",
                    Category = "Indian & Festive Wear",
                    SubCategoryName = "Kurtas & Kurta Sets"
                },
                new SubCategory()
                {
                    SubCategoryId = 11,
                    MainCategory = "Men",
                    Category = "Indian & Festive Wear",
                    SubCategoryName = "Sherwanis"
                },
                new SubCategory()
                {
                    SubCategoryId = 12,
                    MainCategory = "Men",
                    Category = "Indian & Festive Wear",
                    SubCategoryName = "Nehru Jackets"
                },
                new SubCategory()
                {
                    SubCategoryId = 13,
                    MainCategory = "Men",
                    Category = "Indian & Festive Wear",
                    SubCategoryName = "Dhoti"
                },
                new SubCategory()
                {
                    SubCategoryId = 14,
                    MainCategory = "Men",
                    Category = "Bottomwear",
                    SubCategoryName = "Jeans"
                },
                new SubCategory()
                {
                    SubCategoryId = 15,
                    MainCategory = "Men",
                    Category = "Bottomwear",
                    SubCategoryName = "Casual Trousers"
                },
                new SubCategory()
                {
                    SubCategoryId = 16,
                    MainCategory = "Men",
                    Category = "Bottomwear",
                    SubCategoryName = "Formal Trousers"
                },
                new SubCategory()
                {
                    SubCategoryId = 17,
                    MainCategory = "Men",
                    Category = "Bottomwear",
                    SubCategoryName = "Shorts"
                },
                new SubCategory()
                {
                    SubCategoryId = 18,
                    MainCategory = "Men",
                    Category = "Bottomwear",
                    SubCategoryName = "Track Pants & Joggers"
                },
                new SubCategory()
                {
                    SubCategoryId = 19,
                    MainCategory = "Men",
                    Category = "Innerwear & Sleepwear",
                    SubCategoryName = "Briefs & Trunks"
                },
                new SubCategory()
                {
                    SubCategoryId = 20,
                    MainCategory = "Men",
                    Category = "Innerwear & Sleepwear",
                    SubCategoryName = "Boxers"
                },
                new SubCategory()
                {
                    SubCategoryId = 21,
                    MainCategory = "Men",
                    Category = "Innerwear & Sleepwear",
                    SubCategoryName = "Vests"
                },
                new SubCategory()
                {
                    SubCategoryId = 22,
                    MainCategory = "Men",
                    Category = "Innerwear & Sleepwear",
                    SubCategoryName = "Sleepwear & Loungwear"
                },
                new SubCategory()
                {
                    SubCategoryId = 23,
                    MainCategory = "Men",
                    Category = "Innerwear & Sleepwear",
                    SubCategoryName = "Thermals"
                },
                new SubCategory()
                {
                    SubCategoryId = 24,
                    MainCategory = "Men",
                    Category = "Footwear",
                    SubCategoryName = "Casual Shoues"
                },
                new SubCategory()
                {
                    SubCategoryId = 25,
                    MainCategory = "Men",
                    Category = "Footwear",
                    SubCategoryName = "Sports Shoes"
                },
                new SubCategory()
                {
                    SubCategoryId = 26,
                    MainCategory = "Men",
                    Category = "Footwear",
                    SubCategoryName = "Formal Shoes"
                },
                new SubCategory()
                {
                    SubCategoryId = 27,
                    MainCategory = "Men",
                    Category = "Footwear",
                    SubCategoryName = "Sneakers"
                },
                new SubCategory()
                {
                    SubCategoryId = 28,
                    MainCategory = "Men",
                    Category = "Footwear",
                    SubCategoryName = "Sandals & Floaters"
                },
                new SubCategory()
                {
                    SubCategoryId = 29,
                    MainCategory = "Men",
                    Category = "Footwear",
                    SubCategoryName = "Flip Flops"
                },
                new SubCategory()
                {
                    SubCategoryId = 30,
                    MainCategory = "Men",
                    Category = "Footwear",
                    SubCategoryName = "Socks"
                },
                new SubCategory()
                {
                    SubCategoryId = 31,
                    MainCategory = "Men",
                    Category = "Sports & Active Wear",
                    SubCategoryName = "Sports Shoes"
                },
                new SubCategory()
                {
                    SubCategoryId = 32,
                    MainCategory = "Men",
                    Category = "Sports & Active Wear",
                    SubCategoryName = "Sport Sandals"
                },
                new SubCategory()
                {
                    SubCategoryId = 33,
                    MainCategory = "Men",
                    Category = "Sports & Active Wear",
                    SubCategoryName = "Active T-Shirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 34,
                    MainCategory = "Men",
                    Category = "Sports & Active Wear",
                    SubCategoryName = "Track Pants & Shorts"
                },
                new SubCategory()
                {
                    SubCategoryId = 35,
                    MainCategory = "Men",
                    Category = "Sports & Active Wear",
                    SubCategoryName = "Tracksuits"
                },
                new SubCategory()
                {
                    SubCategoryId = 36,
                    MainCategory = "Men",
                    Category = "Sports & Active Wear",
                    SubCategoryName = "Jackets & Sweatshirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 37,
                    MainCategory = "Men",
                    Category = "Sports & Active Wear",
                    SubCategoryName = "Sports Accessories"
                },
                new SubCategory()
                {
                    SubCategoryId = 38,
                    MainCategory = "Men",
                    Category = "Sports & Active Wear",
                    SubCategoryName = "Swimwear"
                },
                new SubCategory()
                {
                    SubCategoryId = 39,
                    MainCategory = "Men",
                    Category = "Gadgets",
                    SubCategoryName = "Smart Wearables"
                },
                new SubCategory()
                {
                    SubCategoryId = 40,
                    MainCategory = "Men",
                    Category = "Gadgets",
                    SubCategoryName = "Fitness Gadgets"
                },
                new SubCategory()
                {
                    SubCategoryId = 41,
                    MainCategory = "Men",
                    Category = "Gadgets",
                    SubCategoryName = "Headphones"
                },
                new SubCategory()
                {
                    SubCategoryId = 42,
                    MainCategory = "Men",
                    Category = "Gadgets",
                    SubCategoryName = "Speakers"
                },
                new SubCategory()
                {
                    SubCategoryId = 43,
                    MainCategory = "Men",
                    Category = "Fashion Accessories",
                    SubCategoryName = "Socks"
                },
                new SubCategory()
                {
                    SubCategoryId = 44,
                    MainCategory = "Men",
                    Category = "Fashion Accessories",
                    SubCategoryName = "Wallets"
                },
                new SubCategory()
                {
                    SubCategoryId = 45,
                    MainCategory = "Men",
                    Category = "Fashion Accessories",
                    SubCategoryName = "Belts"
                },
                new SubCategory()
                {
                    SubCategoryId = 46,
                    MainCategory = "Men",
                    Category = "Fashion Accessories",
                    SubCategoryName = "Perfumes & Body Mists"
                },
                new SubCategory()
                {
                    SubCategoryId = 47,
                    MainCategory = "Men",
                    Category = "Fashion Accessories",
                    SubCategoryName = "Trimmers"
                },
                new SubCategory()
                {
                    SubCategoryId = 48,
                    MainCategory = "Men",
                    Category = "Fashion Accessories",
                    SubCategoryName = "Deodorants"
                },
                new SubCategory()
                {
                    SubCategoryId = 49,
                    MainCategory = "Men",
                    Category = "Fashion Accessories",
                    SubCategoryName = "Ties,Cufflinks & Pocket Squares"
                },
                new SubCategory()
                {
                    SubCategoryId = 50,
                    MainCategory = "Men",
                    Category = "Fashion Accessories",
                    SubCategoryName = "Accessory Gift Sets"
                },
                new SubCategory()
                {
                    SubCategoryId = 51,
                    MainCategory = "Men",
                    Category = "Fashion Accessories",
                    SubCategoryName = "Caps & Hats"
                },
                new SubCategory()
                {
                    SubCategoryId = 52,
                    MainCategory = "Men",
                    Category = "Fashion Accessories",
                    SubCategoryName = "Phone Cases"
                },
                new SubCategory()
                {
                    SubCategoryId = 53,
                    MainCategory = "Men",
                    Category = "Fashion Accessories",
                    SubCategoryName = "Rings & Wristwear"
                },
                new SubCategory()
                {
                    SubCategoryId = 54,
                    MainCategory = "Men",
                    Category = "Fashion Accessories",
                    SubCategoryName = "Helmets"
                },
                new SubCategory()
                {
                    SubCategoryId = 55,
                    MainCategory = "Women",
                    Category = "Indian & Fusion Wear",
                    SubCategoryName = "Kurtas & Suits"
                },
                new SubCategory()
                {
                    SubCategoryId = 56,
                    MainCategory = "Women",
                    Category = "Indian & Fusion Wear",
                    SubCategoryName = "Kurtis, Tunic & Tops"
                },
                new SubCategory()
                {
                    SubCategoryId = 57,
                    MainCategory = "Women",
                    Category = "Indian & Fusion Wear",
                    SubCategoryName = "Sarees"
                },
                new SubCategory()
                {
                    SubCategoryId = 58,
                    MainCategory = "Women",
                    Category = "Indian & Fusion Wear",
                    SubCategoryName = "Ethnic Wear"
                },
                new SubCategory()
                {
                    SubCategoryId = 59,
                    MainCategory = "Women",
                    Category = "Indian & Fusion Wear",
                    SubCategoryName = "Leggings, Salwar & Churidars"
                },
                new SubCategory()
                {
                    SubCategoryId = 60,
                    MainCategory = "Women",
                    Category = "Indian & Fusion Wear",
                    SubCategoryName = "Skirts & Palazzos"
                },
                new SubCategory()
                {
                    SubCategoryId = 61,
                    MainCategory = "Women",
                    Category = "Indian & Fusion Wear",
                    SubCategoryName = "Dress Materials"
                },
                new SubCategory()
                {
                    SubCategoryId = 62,
                    MainCategory = "Women",
                    Category = "Indian & Fusion Wear",
                    SubCategoryName = "Lehengas Cholis"
                },
                new SubCategory()
                {
                    SubCategoryId = 63,
                    MainCategory = "Women",
                    Category = "Indian & Fusion Wear",
                    SubCategoryName = "Dupattas & Shawls"
                },
                new SubCategory()
                {
                    SubCategoryId = 64,
                    MainCategory = "Women",
                    Category = "Indian & Fusion Wear",
                    SubCategoryName = "Jackets"
                },
                new SubCategory()
                {
                    SubCategoryId = 65,
                    MainCategory = "Women",
                    Category = "Western Wear",
                    SubCategoryName = "Dresses"
                },
                new SubCategory()
                {
                    SubCategoryId = 66,
                    MainCategory = "Women",
                    Category = "Western Wear",
                    SubCategoryName = "Tops"
                },
                new SubCategory()
                {
                    SubCategoryId = 67,
                    MainCategory = "Women",
                    Category = "Western Wear",
                    SubCategoryName = "Tshirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 68,
                    MainCategory = "Women",
                    Category = "Western Wear",
                    SubCategoryName = "Jeans"
                },
                new SubCategory()
                {
                    SubCategoryId = 69,
                    MainCategory = "Women",
                    Category = "Western Wear",
                    SubCategoryName = "Trousers & Capris"
                },
                new SubCategory()
                {
                    SubCategoryId = 70,
                    MainCategory = "Women",
                    Category = "Western Wear",
                    SubCategoryName = "Shorts & Skirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 71,
                    MainCategory = "Women",
                    Category = "Western Wear",
                    SubCategoryName = "Co-ords"
                },
                new SubCategory()
                {
                    SubCategoryId = 72,
                    MainCategory = "Women",
                    Category = "Western Wear",
                    SubCategoryName = "Playsuits"
                },
                new SubCategory()
                {
                    SubCategoryId = 73,
                    MainCategory = "Women",
                    Category = "Western Wear",
                    SubCategoryName = "Shrug"
                },
                new SubCategory()
                {
                    SubCategoryId = 74,
                    MainCategory = "Women",
                    Category = "Western Wear",
                    SubCategoryName = "Sweaters & Sweatshirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 75,
                    MainCategory = "Women",
                    Category = "Western Wear",
                    SubCategoryName = "Jackets & Coats"
                },
                new SubCategory()
                {
                    SubCategoryId = 76,
                    MainCategory = "Women",
                    Category = "Western Wear",
                    SubCategoryName = "Blazers & Waiscoats"
                },
                new SubCategory()
                {
                    SubCategoryId = 77,
                    MainCategory = "Women",
                    Category = "Footwear",
                    SubCategoryName = "Flats"
                },
                new SubCategory()
                {
                    SubCategoryId = 78,
                    MainCategory = "Women",
                    Category = "Footwear",
                    SubCategoryName = "Casual Shoes"
                },
                new SubCategory()
                {
                    SubCategoryId = 79,
                    MainCategory = "Women",
                    Category = "Footwear",
                    SubCategoryName = "Heels"
                },
                new SubCategory()
                {
                    SubCategoryId = 80,
                    MainCategory = "Women",
                    Category = "Footwear",
                    SubCategoryName = "Boots"
                },
                new SubCategory()
                {
                    SubCategoryId = 81,
                    MainCategory = "Women",
                    Category = "Footwear",
                    SubCategoryName = "Sports Shoes & Floaters"
                },
                new SubCategory()
                {
                    SubCategoryId = 82,
                    MainCategory = "Women",
                    Category = "Sports & Active Wear",
                    SubCategoryName = "Clothing"
                },
                new SubCategory()
                {
                    SubCategoryId = 83,
                    MainCategory = "Women",
                    Category = "Sports & Active Wear",
                    SubCategoryName = "Footwear"
                },
                new SubCategory()
                {
                    SubCategoryId = 84,
                    MainCategory = "Women",
                    Category = "Sports & Active Wear",
                    SubCategoryName = "Sports Accessories"
                },
                new SubCategory()
                {
                    SubCategoryId = 85,
                    MainCategory = "Women",
                    Category = "Sports & Active Wear",
                    SubCategoryName = "Sport Equipment"
                },
                new SubCategory()
                {
                    SubCategoryId = 86,
                    MainCategory = "Women",
                    Category = "Lingerie & Sleepwear",
                    SubCategoryName = "Bra"
                },
                new SubCategory()
                {
                    SubCategoryId = 87,
                    MainCategory = "Women",
                    Category = "Lingerie & Sleepwear",
                    SubCategoryName = "Briefs"
                },
                new SubCategory()
                {
                    SubCategoryId = 88,
                    MainCategory = "Women",
                    Category = "Lingerie & Sleepwear",
                    SubCategoryName = "Shapewear"
                },
                new SubCategory()
                {
                    SubCategoryId = 89,
                    MainCategory = "Women",
                    Category = "Lingerie & Sleepwear",
                    SubCategoryName = "Sleepwears & Loungewear"
                },
                new SubCategory()
                {
                    SubCategoryId = 90,
                    MainCategory = "Women",
                    Category = "Lingerie & Sleepwear",
                    SubCategoryName = "Swimwear"
                },
                new SubCategory()
                {
                    SubCategoryId = 91,
                    MainCategory = "Women",
                    Category = "Lingerie & Sleepwear",
                    SubCategoryName = "Camisoles & Thermal"
                },
                new SubCategory()
                {
                    SubCategoryId = 92,
                    MainCategory = "Women",
                    Category = "Beauty & Personal Care",
                    SubCategoryName = "Makeup"
                },
                new SubCategory()
                {
                    SubCategoryId = 93,
                    MainCategory = "Women",
                    Category = "Beauty & Personal Care",
                    SubCategoryName = "Skincare"
                },
                new SubCategory()
                {
                    SubCategoryId = 94,
                    MainCategory = "Women",
                    Category = "Beauty & Personal Care",
                    SubCategoryName = "Premium Beauty"
                },
                new SubCategory()
                {
                    SubCategoryId = 95,
                    MainCategory = "Women",
                    Category = "Beauty & Personal Care",
                    SubCategoryName = "Lipstic"
                },
                new SubCategory()
                {
                    SubCategoryId = 96,
                    MainCategory = "Women",
                    Category = "Beauty & Personal Care",
                    SubCategoryName = "Fragrances"
                },
                new SubCategory()
                {
                    SubCategoryId = 97,
                    MainCategory = "Women",
                    Category = "Gadgets",
                    SubCategoryName = "Smart Wearables"
                },
                new SubCategory()
                {
                    SubCategoryId = 98,
                    MainCategory = "Women",
                    Category = "Gadgets",
                    SubCategoryName = "Fitness Gadgets"
                },
                new SubCategory()
                {
                    SubCategoryId = 99,
                    MainCategory = "Women",
                    Category = "Gadgets",
                    SubCategoryName = "Headphones"
                },
                new SubCategory()
                {
                    SubCategoryId = 100,
                    MainCategory = "Women",
                    Category = "Gadgets",
                    SubCategoryName = "Speakers"
                },
                new SubCategory()
                {
                    SubCategoryId = 101,
                    MainCategory = "Women",
                    Category = "Jwellery",
                    SubCategoryName = "Fashion Jwellery"
                },
                new SubCategory()
                {
                    SubCategoryId = 102,
                    MainCategory = "Women",
                    Category = "Jwellery",
                    SubCategoryName = "Fine Jewellery"
                },
                new SubCategory()
                {
                    SubCategoryId = 103,
                    MainCategory = "Women",
                    Category = "Jwellery",
                    SubCategoryName = "Earrings"
                },
                new SubCategory()
                {
                    SubCategoryId = 104,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "T-Shirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 105,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "Shirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 106,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "Shorts"
                },
                new SubCategory()
                {
                    SubCategoryId = 107,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "Jeans"
                },
                new SubCategory()
                {
                    SubCategoryId = 108,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "Trousers"
                },
                new SubCategory()
                {
                    SubCategoryId = 109,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "Clothing Sets"
                },
                new SubCategory()
                {
                    SubCategoryId = 110,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "Ethinic Wear"
                },
                new SubCategory()
                {
                    SubCategoryId = 111,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "Track Pants & Pyjamas"
                },
                new SubCategory()
                {
                    SubCategoryId = 112,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "Jacket, Sweater & Sweatshirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 113,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "Party Wear"
                },
                new SubCategory()
                {
                    SubCategoryId = 114,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "Innerwear & Thermals"
                },
                new SubCategory()
                {
                    SubCategoryId = 115,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "Nightwear & Loungewear"
                },
                new SubCategory()
                {
                    SubCategoryId = 116,
                    MainCategory = "Kids",
                    Category = "Boys Clothing",
                    SubCategoryName = "Value Packs"
                },
                new SubCategory()
                {
                    SubCategoryId = 117,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Dresses"
                },
                new SubCategory()
                {
                    SubCategoryId = 118,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Tops"
                },
                new SubCategory()
                {
                    SubCategoryId = 119,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Tshirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 120,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Clothing Sets"
                },
                new SubCategory()
                {
                    SubCategoryId = 121,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Lehengas choli"
                },
                new SubCategory()
                {
                    SubCategoryId = 122,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Kurta Sets"
                },
                new SubCategory()
                {
                    SubCategoryId = 123,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Party Wear"
                },
                new SubCategory()
                {
                    SubCategoryId = 124,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Dungarees & Jumpsuits"
                },
                new SubCategory()
                {
                    SubCategoryId = 125,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Skirts & Leggings"
                },
                new SubCategory()
                {
                    SubCategoryId = 126,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Jeans, Trousers & Capris"
                },
                new SubCategory()
                {
                    SubCategoryId = 127,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "jacket, Sweater & Sweatshirts"
                },
                new SubCategory()
                {
                    SubCategoryId = 128,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Innerwear & Thermals"
                },
                new SubCategory()
                {
                    SubCategoryId = 129,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Nightwear & Loungewear"
                },
                new SubCategory()
                {
                    SubCategoryId = 130,
                    MainCategory = "Kids",
                    Category = "Girls Clothing",
                    SubCategoryName = "Value Packs"
                },
                new SubCategory()
                {
                    SubCategoryId = 131,
                    MainCategory = "Kids",
                    Category = "Footwear",
                    SubCategoryName = "Casual Shoes"
                },
                new SubCategory()
                {
                    SubCategoryId = 132,
                    MainCategory = "Kids",
                    Category = "Footwear",
                    SubCategoryName = "Flipflops"
                },
                new SubCategory()
                {
                    SubCategoryId = 133,
                    MainCategory = "Kids",
                    Category = "Footwear",
                    SubCategoryName = "Sports Shoes"
                },
                new SubCategory()
                {
                    SubCategoryId = 134,
                    MainCategory = "Kids",
                    Category = "Footwear",
                    SubCategoryName = "Flats"
                },
                new SubCategory()
                {
                    SubCategoryId = 135,
                    MainCategory = "Kids",
                    Category = "Footwear",
                    SubCategoryName = "Sandals"
                },
                new SubCategory()
                {
                    SubCategoryId = 136,
                    MainCategory = "Kids",
                    Category = "Footwear",
                    SubCategoryName = "Heels"
                },
                new SubCategory()
                {
                    SubCategoryId = 137,
                    MainCategory = "Kids",
                    Category = "Footwear",
                    SubCategoryName = "School Shoes"
                },
                new SubCategory()
                {
                    SubCategoryId = 138,
                    MainCategory = "Kids",
                    Category = "Footwear",
                    SubCategoryName = "Socks"
                },
                new SubCategory()
                {
                    SubCategoryId = 139,
                    MainCategory = "Kids",
                    Category = "Toys & Games",
                    SubCategoryName = "Learning & Development"
                },
                new SubCategory()
                {
                    SubCategoryId = 140,
                    MainCategory = "Kids",
                    Category = "Toys & Games",
                    SubCategoryName = "Activity Toys"
                },
                new SubCategory()
                {
                    SubCategoryId = 141,
                    MainCategory = "Kids",
                    Category = "Toys & Games",
                    SubCategoryName = "Soft Toys"
                },
                new SubCategory()
                {
                    SubCategoryId = 142,
                    MainCategory = "Kids",
                    Category = "Toys & Games",
                    SubCategoryName = "Action Figure / Play set"
                },
                new SubCategory()
                {
                    SubCategoryId = 143,
                    MainCategory = "Kids",
                    Category = "Infants",
                    SubCategoryName = "Bodysuits"
                },
                new SubCategory()
                {
                    SubCategoryId = 144,
                    MainCategory = "Kids",
                    Category = "Infants",
                    SubCategoryName = "Rompers & Sleepsuits"
                },
                new SubCategory()
                {
                    SubCategoryId = 145,
                    MainCategory = "Kids",
                    Category = "Infants",
                    SubCategoryName = "Clothing Sets"
                },
                new SubCategory()
                {
                    SubCategoryId = 146,
                    MainCategory = "Kids",
                    Category = "Infants",
                    SubCategoryName = "Tshirts & Tops"
                },
                new SubCategory()
                {
                    SubCategoryId = 147,
                    MainCategory = "Kids",
                    Category = "Infants",
                    SubCategoryName = "Dresses"
                },
                new SubCategory()
                {
                    SubCategoryId = 148,
                    MainCategory = "Kids",
                    Category = "Infants",
                    SubCategoryName = "Bottom Wear"
                },
                new SubCategory()
                {
                    SubCategoryId = 149,
                    MainCategory = "Kids",
                    Category = "Infants",
                    SubCategoryName = "Winter Wear"
                },
                new SubCategory()
                {
                    SubCategoryId = 150,
                    MainCategory = "Kids",
                    Category = "Infants",
                    SubCategoryName = "Innerwear & Sleepwear"
                },
                new SubCategory()
                {
                    SubCategoryId = 151,
                    MainCategory = "Kids",
                    Category = "Infants",
                    SubCategoryName = "Infant Care"
                },
                new SubCategory()
                {
                    SubCategoryId = 152,
                    MainCategory = "Kids",
                    Category = "Kids Accessories",
                    SubCategoryName = "Bags & Backpacks"
                },
                new SubCategory()
                {
                    SubCategoryId = 153,
                    MainCategory = "Kids",
                    Category = "Kids Accessories",
                    SubCategoryName = "Watches"
                },
                new SubCategory()
                {
                    SubCategoryId = 154,
                    MainCategory = "Kids",
                    Category = "Kids Accessories",
                    SubCategoryName = "Jewellery & Hair accessory"
                },
                new SubCategory()
                {
                    SubCategoryId = 155,
                    MainCategory = "Kids",
                    Category = "Kids Accessories",
                    SubCategoryName = "Sunglasses"
                },
                new SubCategory()
                {
                    SubCategoryId = 156,
                    MainCategory = "Kids",
                    Category = "Kids Accessories",
                    SubCategoryName = "Masks & Protective Gears"
                },
                new SubCategory()
                {
                    SubCategoryId = 157,
                    MainCategory = "Kids",
                    Category = "Kids Accessories",
                    SubCategoryName = "Caps & Hats"
                },
                new SubCategory()
                {
                    SubCategoryId = 158,
                    MainCategory = "Kids",
                    Category = "Brands",
                    SubCategoryName = "H&M"
                },
                new SubCategory()
                {
                    SubCategoryId = 159,
                    MainCategory = "Kids",
                    Category = "Brands",
                    SubCategoryName = "Max Kids"
                },
                new SubCategory()
                {
                    SubCategoryId = 160,
                    MainCategory = "Kids",
                    Category = "Brands",
                    SubCategoryName = "Pantaloons"
                },
                new SubCategory()
                {
                    SubCategoryId = 161,
                    MainCategory = "Kids",
                    Category = "Brands",
                    SubCategoryName = "United Colors of Benetton Kids"
                },
                new SubCategory()
                {
                    SubCategoryId = 162,
                    MainCategory = "Kids",
                    Category = "Brands",
                    SubCategoryName = "YK"
                },
                new SubCategory()
                {
                    SubCategoryId = 163,
                    MainCategory = "Kids",
                    Category = "Brands",
                    SubCategoryName = "U.S. Polo Assn, Kids"
                },
                new SubCategory()
                {
                    SubCategoryId = 164,
                    MainCategory = "Kids",
                    Category = "Brands",
                    SubCategoryName = "Mothercare"
                },
                new SubCategory()
                {
                    SubCategoryId = 165,
                    MainCategory = "Kids",
                    Category = "Brands",
                    SubCategoryName = "HRX"
                },
                new SubCategory()
                {
                    SubCategoryId = 166,
                    MainCategory = "Home & Living",
                    Category = "Bed Linen & Furnishing",
                    SubCategoryName = "Bed Runners"
                },
                new SubCategory()
                {
                    SubCategoryId = 167,
                    MainCategory = "Home & Living",
                    Category = "Bed Linen & Furnishing",
                    SubCategoryName = "Mattress Protectors"
                },
                new SubCategory()
                {
                    SubCategoryId = 168,
                    MainCategory = "Home & Living",
                    Category = "Bed Linen & Furnishing",
                    SubCategoryName = "Bedsheets"
                },
                new SubCategory()
                {
                    SubCategoryId = 169,
                    MainCategory = "Home & Living",
                    Category = "Bed Linen & Furnishing",
                    SubCategoryName = "Bedding Sets"
                },
                new SubCategory()
                {
                    SubCategoryId = 170,
                    MainCategory = "Home & Living",
                    Category = "Bed Linen & Furnishing",
                    SubCategoryName = "Blankets, Quilts & Dohars"
                },
                new SubCategory()
                {
                    SubCategoryId = 171,
                    MainCategory = "Home & Living",
                    Category = "Bed Linen & Furnishing",
                    SubCategoryName = "Pillows & Pillow Covers"
                },
                new SubCategory()
                {
                    SubCategoryId = 172,
                    MainCategory = "Home & Living",
                    Category = "Bed Linen & Furnishing",
                    SubCategoryName = "Bed Covers"
                },
                new SubCategory()
                {
                    SubCategoryId = 173,
                    MainCategory = "Home & Living",
                    Category = "Bed Linen & Furnishing",
                    SubCategoryName = "Diwan Sets"
                },
                new SubCategory()
                {
                    SubCategoryId = 174,
                    MainCategory = "Home & Living",
                    Category = "Bed Linen & Furnishing",
                    SubCategoryName = "Chair Pads & Covers"
                },
                new SubCategory()
                {
                    SubCategoryId = 175,
                    MainCategory = "Home & Living",
                    Category = "Bed Linen & Furnishing",
                    SubCategoryName = "Sofa Covers"
                },
                new SubCategory()
                {
                    SubCategoryId = 176,
                    MainCategory = "Home & Living",
                    Category = "Flooring",
                    SubCategoryName = "Floor Runners"
                },
                new SubCategory()
                {
                    SubCategoryId = 177,
                    MainCategory = "Home & Living",
                    Category = "Flooring",
                    SubCategoryName = "Carpets"
                },
                new SubCategory()
                {
                    SubCategoryId = 178,
                    MainCategory = "Home & Living",
                    Category = "Flooring",
                    SubCategoryName = "Floor Mats Dhurries"
                },
                new SubCategory()
                {
                    SubCategoryId = 179,
                    MainCategory = "Home & Living",
                    Category = "Flooring",
                    SubCategoryName = "Door Mats"
                },
                new SubCategory()
                {
                    SubCategoryId = 180,
                    MainCategory = "Home & Living",
                    Category = "Bath",
                    SubCategoryName = "Bath Towels"
                },
                new SubCategory()
                {
                    SubCategoryId = 181,
                    MainCategory = "Home & Living",
                    Category = "Bath",
                    SubCategoryName = "Hand & Face Towels"
                },
                new SubCategory()
                {
                    SubCategoryId = 182,
                    MainCategory = "Home & Living",
                    Category = "Bath",
                    SubCategoryName = "Beach Towels"
                },
                new SubCategory()
                {
                    SubCategoryId = 183,
                    MainCategory = "Home & Living",
                    Category = "Bath",
                    SubCategoryName = "Towels Set"
                },
                new SubCategory()
                {
                    SubCategoryId = 184,
                    MainCategory = "Home & Living",
                    Category = "Bath",
                    SubCategoryName = "Bath Rugs"
                },
                new SubCategory()
                {
                    SubCategoryId = 185,
                    MainCategory = "Home & Living",
                    Category = "Bath",
                    SubCategoryName = "Bath Robes"
                },
                new SubCategory()
                {
                    SubCategoryId = 186,
                    MainCategory = "Home & Living",
                    Category = "Bath",
                    SubCategoryName = "Shower Curtains"
                },
                new SubCategory()
                {
                    SubCategoryId = 187,
                    MainCategory = "Home & Living",
                    Category = "Lamps & Lighting",
                    SubCategoryName = "Floor Lamps"
                },
                new SubCategory()
                {
                    SubCategoryId = 188,
                    MainCategory = "Home & Living",
                    Category = "Lamps & Lighting",
                    SubCategoryName = "Ceiling Lamps"
                },
                new SubCategory()
                {
                    SubCategoryId = 189,
                    MainCategory = "Home & Living",
                    Category = "Lamps & Lighting",
                    SubCategoryName = "Table Lamps"
                },
                new SubCategory()
                {
                    SubCategoryId = 190,
                    MainCategory = "Home & Living",
                    Category = "Lamps & Lighting",
                    SubCategoryName = "Wall Lamps"
                },
                new SubCategory()
                {
                    SubCategoryId = 191,
                    MainCategory = "Home & Living",
                    Category = "Lamps & Lighting",
                    SubCategoryName = "Outdoor Lamps"
                },
                new SubCategory()
                {
                    SubCategoryId = 192,
                    MainCategory = "Home & Living",
                    Category = "Lamps & Lighting",
                    SubCategoryName = "String Lights"
                },
                new SubCategory()
                {
                    SubCategoryId = 193,
                    MainCategory = "Home & Living",
                    Category = "Home & Decor",
                    SubCategoryName = "Plants & Planters"
                },
                new SubCategory()
                {
                    SubCategoryId = 194,
                    MainCategory = "Home & Living",
                    Category = "Home & Decor",
                    SubCategoryName = "Aromas & Candles"
                },
                new SubCategory()
                {
                    SubCategoryId = 195,
                    MainCategory = "Home & Living",
                    Category = "Home & Decor",
                    SubCategoryName = "Clocks"
                },
                new SubCategory()
                {
                    SubCategoryId = 196,
                    MainCategory = "Home & Living",
                    Category = "Home & Decor",
                    SubCategoryName = "Mirrors"
                },
                new SubCategory()
                {
                    SubCategoryId = 197,
                    MainCategory = "Home & Living",
                    Category = "Home & Decor",
                    SubCategoryName = "Wall Decor"
                },
                new SubCategory()
                {
                    SubCategoryId = 198,
                    MainCategory = "Home & Living",
                    Category = "Home & Decor",
                    SubCategoryName = "Festive Decor"
                },
                new SubCategory()
                {
                    SubCategoryId = 199,
                    MainCategory = "Home & Living",
                    Category = "Home & Decor",
                    SubCategoryName = "Pooja Essentials"
                },
                new SubCategory()
                {
                    SubCategoryId = 200,
                    MainCategory = "Home & Living",
                    Category = "Home & Decor",
                    SubCategoryName = "Wall Shelves"
                },
                new SubCategory()
                {
                    SubCategoryId = 201,
                    MainCategory = "Home & Living",
                    Category = "Home & Decor",
                    SubCategoryName = "Fountains"
                },
                new SubCategory()
                {
                    SubCategoryId = 202,
                    MainCategory = "Home & Living",
                    Category = "Home & Decor",
                    SubCategoryName = "Showpieces & Vases"
                },
                new SubCategory()
                {
                    SubCategoryId = 203,
                    MainCategory = "Home & Living",
                    Category = "Home & Decor",
                    SubCategoryName = "Ottoman"
                },
                new SubCategory()
                {
                    SubCategoryId = 204,
                    MainCategory = "Home & Living",
                    Category = "Kitchen & Table",
                    SubCategoryName = "Table Runners"
                },
                new SubCategory()
                {
                    SubCategoryId = 205,
                    MainCategory = "Home & Living",
                    Category = "Kitchen & Table",
                    SubCategoryName = "Dinnerware & Serveware"
                },
                new SubCategory()
                {
                    SubCategoryId = 206,
                    MainCategory = "Home & Living",
                    Category = "Kitchen & Table",
                    SubCategoryName = "Cups & Mugs"
                },
                new SubCategory()
                {
                    SubCategoryId = 207,
                    MainCategory = "Home & Living",
                    Category = "Kitchen & Table",
                    SubCategoryName = "Backware & Cookware"
                },
                new SubCategory()
                {
                    SubCategoryId = 208,
                    MainCategory = "Home & Living",
                    Category = "Kitchen & Table",
                    SubCategoryName = "Kitchen Storage & tools"
                },
                new SubCategory()
                {
                    SubCategoryId = 209,
                    MainCategory = "Home & Living",
                    Category = "Kitchen & Table",
                    SubCategoryName = "Bar & Drinkware"
                },
                new SubCategory()
                {
                    SubCategoryId = 210,
                    MainCategory = "Home & Living",
                    Category = "Kitchen & Table",
                    SubCategoryName = "Table Covers & Furnishings"
                },
                new SubCategory()
                {
                    SubCategoryId = 211,
                    MainCategory = "Home & Living",
                    Category = "Storage",
                    SubCategoryName = "Bins"
                },
                new SubCategory()
                {
                    SubCategoryId = 212,
                    MainCategory = "Home & Living",
                    Category = "Storage",
                    SubCategoryName = "Hangers"
                },
                new SubCategory()
                {
                    SubCategoryId = 213,
                    MainCategory = "Home & Living",
                    Category = "Storage",
                    SubCategoryName = "Organisers"
                },
                new SubCategory()
                {
                    SubCategoryId = 214,
                    MainCategory = "Home & Living",
                    Category = "Storage",
                    SubCategoryName = "Hooks & Holders"
                },
                new SubCategory()
                {
                    SubCategoryId = 215,
                    MainCategory = "Home & Living",
                    Category = "Storage",
                    SubCategoryName = "Laundry Bags"
                },
                new SubCategory()
                {
                    SubCategoryId = 216,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "H&M"
                },
                new SubCategory()
                {
                    SubCategoryId = 217,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "Marks & Spencer"
                },
                new SubCategory()
                {
                    SubCategoryId = 218,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "Home Center"
                },
                new SubCategory()
                {
                    SubCategoryId = 219,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "Spaces"
                },
                new SubCategory()
                {
                    SubCategoryId = 220,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "D'Decor"
                },
                new SubCategory()
                {
                    SubCategoryId =221,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "story&Home"
                },
                new SubCategory()
                {
                    SubCategoryId = 222,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "Pure Home & Living"
                },
                new SubCategory()
                {
                    SubCategoryId = 223,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "Swayam"
                },
                new SubCategory()
                {
                    SubCategoryId =224,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "Raymond Home"
                },
                new SubCategory()
                {
                    SubCategoryId = 225,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "Maspar"
                },
                new SubCategory()
                {
                    SubCategoryId = 226,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "My Trident"
                },
                new SubCategory()
                {
                    SubCategoryId = 227,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "Cortina"
                },
                new SubCategory()
                {
                    SubCategoryId = 228,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "Random"
                },
                new SubCategory()
                {
                    SubCategoryId = 229,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "Ellementry"
                },
                new SubCategory()
                {
                    SubCategoryId = 230,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "ROMEE"
                },
                new SubCategory()
                {
                    SubCategoryId = 231,
                    MainCategory = "Home & Living",
                    Category = "Brands",
                    SubCategoryName = "SEJ by Nisha Gupta"
                },
                new SubCategory()
                {
                    SubCategoryId = 232,
                    MainCategory = "Beauty",
                    Category = "Makeup",
                    SubCategoryName = "Lipstick"
                },
                new SubCategory()
                {
                    SubCategoryId = 233,
                    MainCategory = "Beauty",
                    Category = "Makeup",
                    SubCategoryName = "Lip Gloss"
                },
                new SubCategory()
                {
                    SubCategoryId = 234,
                    MainCategory = "Beauty",
                    Category = "Makeup",
                    SubCategoryName = "Mascara"
                },
                new SubCategory()
                {
                    SubCategoryId = 235,
                    MainCategory = "Beauty",
                    Category = "Makeup",
                    SubCategoryName = "Runners"
                },new SubCategory()
                {
                    SubCategoryId = 236,
                    MainCategory = "Beauty",
                    Category = "Makeup",
                    SubCategoryName = "Eyeliner"
                },
                new SubCategory()
                {
                    SubCategoryId = 237,
                    MainCategory = "Beauty",
                    Category = "Makeup",
                    SubCategoryName = "Kajal"
                },
                new SubCategory()
                {
                    SubCategoryId = 238,
                    MainCategory = "Beauty",
                    Category = "Makeup",
                    SubCategoryName = "EyeShadow"
                },
                new SubCategory()
                {
                    SubCategoryId = 239,
                    MainCategory = "Beauty",
                    Category = "Makeup",
                    SubCategoryName = "Foundation"
                },
                new SubCategory()
                {
                    SubCategoryId = 240,
                    MainCategory = "Beauty",
                    Category = "Makeup",
                    SubCategoryName = "Primer"
                },
                new SubCategory()
                {
                    SubCategoryId = 241,
                    MainCategory = "Beauty",
                    Category = "Makeup",
                    SubCategoryName = "Concealer"
                },
                new SubCategory()
                {
                    SubCategoryId = 242,
                    MainCategory = "Beauty",
                    Category = "Makeup",
                    SubCategoryName = "Campact"
                },
                new SubCategory()
                {
                    SubCategoryId = 243,
                    MainCategory = "Beauty",
                    Category = "Makeup",
                    SubCategoryName = "Nail Polish"
                },
                new SubCategory()
                {
                    SubCategoryId = 244,
                    MainCategory = "Beauty",
                    Category = "Skincare, Bath & Body",
                    SubCategoryName = "Face Moisturiser"
                },
                new SubCategory()
                {
                    SubCategoryId = 245,
                    MainCategory = "Beauty",
                    Category = "Skincare, Bath & Body",
                    SubCategoryName = "Cleanser"
                },
                new SubCategory()
                {
                    SubCategoryId = 246,
                    MainCategory = "Beauty",
                    Category = "Skincare, Bath & Body",
                    SubCategoryName = "Masks & Peels"
                },
                new SubCategory()
                {
                    SubCategoryId = 247,
                    MainCategory = "Beauty",
                    Category = "Skincare, Bath & Body",
                    SubCategoryName = "Sunscream"
                },
                new SubCategory()
                {
                    SubCategoryId = 248,
                    MainCategory = "Beauty",
                    Category = "Skincare, Bath & Body",
                    SubCategoryName = "Facewash"
                },
                new SubCategory()
                {
                    SubCategoryId = 249,
                    MainCategory = "Beauty",
                    Category = "Skincare, Bath & Body",
                    SubCategoryName = "Eye Cream"
                },
                new SubCategory()
                {
                    SubCategoryId = 250,
                    MainCategory = "Beauty",
                    Category = "Skincare, Bath & Body",
                    SubCategoryName = "Lip Balm"
                },
                new SubCategory()
                {
                    SubCategoryId = 251,
                    MainCategory = "Beauty",
                    Category = "Skincare, Bath & Body",
                    SubCategoryName = "Body Lotion"
                },
                new SubCategory()
                {
                    SubCategoryId = 252,
                    MainCategory = "Beauty",
                    Category = "Skincare, Bath & Body",
                    SubCategoryName = "Body Wash"
                },
                new SubCategory()
                {
                    SubCategoryId = 253,
                    MainCategory = "Beauty",
                    Category = "Skincare, Bath & Body",
                    SubCategoryName = "Body Scrub"
                },
                new SubCategory()
                {
                    SubCategoryId = 254,
                    MainCategory = "Beauty",
                    Category = "Skincare, Bath & Body",
                    SubCategoryName = "Hand Cream"
                },
                new SubCategory()
                {
                    SubCategoryId = 255,
                    MainCategory = "Beauty",
                    Category = "Haircare",
                    SubCategoryName = "Shampoo"
                },
                new SubCategory()
                {
                    SubCategoryId = 256,
                    MainCategory = "Beauty",
                    Category = "Haircare",
                    SubCategoryName = "Conditioner"
                },
                new SubCategory()
                {
                    SubCategoryId = 257,
                    MainCategory = "Beauty",
                    Category = "Haircare",
                    SubCategoryName = "Hair Cream"
                },
                new SubCategory()
                {
                    SubCategoryId = 258,
                    MainCategory = "Beauty",
                    Category = "Haircare",
                    SubCategoryName = "Hair Oil"
                },
                new SubCategory()
                {
                    SubCategoryId = 259,
                    MainCategory = "Beauty",
                    Category = "Haircare",
                    SubCategoryName = "Hair Gel"
                },
                new SubCategory()
                {
                    SubCategoryId = 260,
                    MainCategory = "Beauty",
                    Category = "Haircare",
                    SubCategoryName = "Hair Color"
                },
                new SubCategory()
                {
                    SubCategoryId = 261,
                    MainCategory = "Beauty",
                    Category = "Haircare",
                    SubCategoryName = "Hair Serum"
                },
                new SubCategory()
                {
                    SubCategoryId = 262,
                    MainCategory = "Beauty",
                    Category = "Haircare",
                    SubCategoryName = "Hair Accessory"
                },
                new SubCategory()
                {
                    SubCategoryId = 263,
                    MainCategory = "Beauty",
                    Category = "Frangrances",
                    SubCategoryName = "Perfume"
                },
                new SubCategory()
                {
                    SubCategoryId = 264,
                    MainCategory = "Beauty",
                    Category = "Frangrances",
                    SubCategoryName = "Deodorant"
                },
                new SubCategory()
                {
                    SubCategoryId = 265,
                    MainCategory = "Beauty",
                    Category = "Frangrances",
                    SubCategoryName = "Body Mist"
                },
                new SubCategory()
                {
                    SubCategoryId = 266,
                    MainCategory = "Beauty",
                    Category = "Appliances",
                    SubCategoryName = "Hair Straightner"
                },
                new SubCategory()
                {
                    SubCategoryId = 267,
                    MainCategory = "Beauty",
                    Category = "Appliances",
                    SubCategoryName = "Hair Dryer"
                },
                new SubCategory()
                {
                    SubCategoryId = 268,
                    MainCategory = "Beauty",
                    Category = "Appliances",
                    SubCategoryName = "Epilator"
                },
                new SubCategory()
                {
                    SubCategoryId = 269,
                    MainCategory = "Beauty",
                    Category = "Mens's Grooming",
                    SubCategoryName = "Trimmers"
                },
                new SubCategory()
                {
                    SubCategoryId = 270,
                    MainCategory = "Beauty",
                    Category = "Mens's Grooming",
                    SubCategoryName = "Beard Oil"
                },
                new SubCategory()
                {
                    SubCategoryId = 271,
                    MainCategory = "Beauty",
                    Category = "Mens's Grooming",
                    SubCategoryName = "Hair Wax"
                },
                new SubCategory()
                {
                    SubCategoryId = 272,
                    MainCategory = "Beauty",
                    Category = "Beauty Gift & Makeup Set",
                    SubCategoryName = "Beauty Gift"
                },
                new SubCategory()
                {
                    SubCategoryId = 273,
                    MainCategory = "Beauty",
                    Category = "Beauty Gift & Makeup Set",
                    SubCategoryName = "Makeup Kit"
                },
                new SubCategory()
                {
                    SubCategoryId = 274,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "Lakme"
                },
                new SubCategory()
                {
                    SubCategoryId = 275,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "Maybelline"
                },
                new SubCategory()
                {
                    SubCategoryId = 276,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "LOreal"
                },
                new SubCategory()
                {
                    SubCategoryId = 277,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "Philips"
                },
                new SubCategory()
                {
                    SubCategoryId = 278,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "Bath & Body Works"
                },
                new SubCategory()
                {
                    SubCategoryId = 279,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "THE BODY SHOP"
                },
                new SubCategory()
                {
                    SubCategoryId = 280,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "Biotique"
                },
                new SubCategory()
                {
                    SubCategoryId = 281,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "Mamaearth"
                },
                new SubCategory()
                {
                    SubCategoryId = 282,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "MCaffeine"
                },
                new SubCategory()
                {
                    SubCategoryId = 283,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "Nivea"
                },
                new SubCategory()
                {
                    SubCategoryId = 284,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "Lotus Herbals"
                },
                new SubCategory()
                {
                    SubCategoryId = 285,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "LOreal Professionnel"
                },
                new SubCategory()
                {
                    SubCategoryId = 286,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "KAMA AYURVEDA"
                },
                new SubCategory()
                {
                    SubCategoryId = 287,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "M.A.C"
                },
                new SubCategory()
                {
                    SubCategoryId = 288,
                    MainCategory = "Beauty",
                    Category = "Top Brands",
                    SubCategoryName = "Forest Essentials"
                },
            };
            // Seed subcategory to database
            modelBuilder.Entity<SubCategory>().HasData(subCategory);

            //// Seed the data for product
            //var products = new List<Products>
            //{
            //    new Products()
            //    {
            //        ProductId = 1,
            //        ProductName = "Amazon Brand - Symbol",
            //        ProductImage = "https://m.media-amazon.com/images/I/713n+TxyfCL._AC_UL480_QL65_.jpg",
            //        Description = "Men's Cotton Rich Solid Polo T-Shirt Regular Fit (Available in Plus Size)",
            //        MainCategory ="Men",
            //        Category = "Topwear",
            //        SubCategory = "T-Shirts",
            //        IsCOD= true,
            //        Rating = 4.5,
            //        OriginalPrice = 760.00,
            //        DiscountedPrice = 722.00,                   
            //        Sellers = "LUX INDUSTRIES LIMITED",
            //        ProductDetails = "Red Tshirt for men,Pack of 2,Other solid,Regular length,Polo collar,Short, regular sleeves,Knitted cotton fabric",
            //        SizeFit = "Regular Fit,The model (height 6') is wearing a size M",
            //        MaterialCare = "Cotton,Machine Wash",

            //    },
            //    new Products()
            //    {
            //        ProductId = 2,
            //        ProductName = "Lymio",
            //        ProductImage = "https://m.media-amazon.com/images/I/71AEwEupFuL._SL1500_.jpg",
            //        Description = "Lymio Men T-Shirt || T-Shirt for Men || Plain T Shirt || T-Shirt (Rib)",
            //        MainCategory ="Men",
            //        Category = "Topwear",
            //        SubCategory = "T-Shirts",
            //        IsCOD= false,
            //        Rating = 3.8,
            //        OriginalPrice = 4999.00,
            //        DiscountedPrice = 349.00,                    
            //        Sellers = "Lymio INDUSTRIES LIMITED",
            //        ProductDetails = "Green Tshirt for men,Other solid,Regular length,Polo collar,Short, regular sleeves,Knitted cotton fabric",
            //        SizeFit = "Regular Fit,The model (height 6') is wearing a size M",
            //        MaterialCare = "Cotton,Machine Wash",

            //    },

            //};
            //// Seed main product to database
            //modelBuilder.Entity<Products>().HasData(products);

            // Seed the data for product specification
            var productSpecifications = new List<ProductSpecification>
            {
                new ProductSpecification()
                {
                    SpecificationId = 1,
                    SpecificationKey = "Fabrick",
                    SpecificationValue = "Cotton",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 2,
                    SpecificationKey = "Fit",
                    SpecificationValue = "Regular Fit",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 3,
                    SpecificationKey = "Length",
                    SpecificationValue = "Regular",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 4,
                    SpecificationKey = "Main Trend",
                    SpecificationValue = "New Basic",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 5,
                    SpecificationKey = "MultiPack Set",
                    SpecificationValue = "2",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 6,
                    SpecificationKey = "Collar",
                    SpecificationValue = "Polo Collar",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 7,
                    SpecificationKey = "No of Items",
                    SpecificationValue = "2",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 8,
                    SpecificationKey = "Ocasion",
                    SpecificationValue = "Casual",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 9,
                    SpecificationKey = "Package Contains",
                    SpecificationValue = "2 tshirts",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 10,
                    SpecificationKey = "Patern",
                    SpecificationValue = "Solid",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 11,
                    SpecificationKey = "Pattern Coverage",
                    SpecificationValue = "Placement",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 12,
                    SpecificationKey = "Sleeve Length",
                    SpecificationValue = "Short Sleeve",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 13,
                    SpecificationKey = "Sleeve Styling",
                    SpecificationValue = "Regular Sleeve",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 14,
                    SpecificationKey = "Surface Stylying",
                    SpecificationValue = "Applique",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 15,
                    SpecificationKey = "Sustainable",
                    SpecificationValue = "Regular",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 16,
                    SpecificationKey = "Wash Care",
                    SpecificationValue = "Machine Wash",
                    ProductId = 1
                },
                new ProductSpecification()
                {
                    SpecificationId = 17,
                    SpecificationKey = "Weave Type",
                    SpecificationValue = "Knitted",
                    ProductId = 1
                },


            };
            // Seed product specification to database
            modelBuilder.Entity<ProductSpecification>().HasData(productSpecifications);

            // Seed the data for product promotions
            var promotions = new List<Promotions>
                {
                new Promotions()
                {
                    PromoionId = 29,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/babe0d1a-b7fe-4b36-8a98-b275523963721690787339222-Shop-By-Category_HP-4_14.jpg",
                    PromotionMainCategory="Kids",
                    PromotionCategory="",
                    PromotionSubCategory="",
                    PromotionDiscount="50",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 30,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/3c2095db-905a-4346-9712-2fac7bcbbbd71690787339011-Shop-By-Category_HP-4_15.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Footwear",
                    PromotionSubCategory="",
                    PromotionDiscount="50",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 31,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/c1c8027f-1a22-4a0b-8be2-848edab298cf1690787339044-Shop-By-Category_HP-4_16.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Footwear",
                    PromotionSubCategory="",
                    PromotionDiscount="40",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 32,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/278917b5-1658-4c2c-b122-f623b1d909701690787339290-Shop-By-Category_HP-4_17.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="",
                    PromotionSubCategory="Wallets,Belts",
                    PromotionDiscount="40",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 33,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/6c53770e-b7b2-466a-b36e-a0b2bff1a7591690787339109-Shop-By-Category_HP-4_18.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Topwear",
                    PromotionSubCategory="Formal Shirts",
                    PromotionDiscount="40",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 34,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/54852b61-90d6-484a-84c9-a8560247ffc21690787339307-Shop-By-Category_HP-4_19.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Indian & Festive Wear",
                    PromotionSubCategory="",
                    PromotionDiscount="60",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 35,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/5d78afb6-38bb-43bd-bc67-1e4f6026b6ae1690787339327-Shop-By-Category_HP-4_20.jpg",
                    PromotionMainCategory="Home & Living",
                    PromotionCategory="Home Décor",
                    PromotionSubCategory="",
                    PromotionDiscount="40",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 36,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/90dcb992-9fb4-4208-8249-aa1a01b2851d1690787339476-Shop-By-Category_HP-4_21.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Handbags, Bags & Wallets",
                    PromotionSubCategory="",
                    PromotionDiscount="40",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 37,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/e4fcb9f0-f79a-41b7-b7b2-8828bb6e95e61690787339426-Shop-By-Category_HP-4_22.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Gadgets",
                    PromotionSubCategory="",
                    PromotionDiscount="70",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 38,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/66882f76-0bbe-4741-8890-0426695e09131690787339238-Shop-By-Category_HP-4_23.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Jewellery",
                    PromotionSubCategory="",
                    PromotionDiscount="80",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 39,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/6aa501b3-ce05-48f5-96fe-ecb64682dbc71690787339409-Shop-By-Category_HP-4_24.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Plus Size",
                    PromotionSubCategory="",
                    PromotionDiscount="60",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 40,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/b6e15609-4f52-44db-80c1-2a955fd4ac6e1690787339341-Shop-By-Category_HP-4_25.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Plus Size",
                    PromotionSubCategory="",
                    PromotionDiscount="60",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 41,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/7916724b-be74-4920-b58d-ada0617cdee91690787339392-Shop-By-Category_HP-4_26.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Smart Wearables",
                    PromotionSubCategory="",
                    PromotionDiscount="80",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 42,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/5c541739-5c23-4846-a875-f19a170cea151690787339460-Shop-By-Category_HP-4_27.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Sleepwear & Loungewear",
                    PromotionSubCategory="",
                    PromotionDiscount="30",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 43,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/76932333-b792-4f54-983c-45aaf70e04ef1690787338936-Shop-By-Category_HP-4_28.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Western Wear",
                    PromotionSubCategory="Blazers & Waistcoats",
                    PromotionDiscount="40",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 44,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/a351ad62-c1d1-4bb4-9967-d3966f8446521690787338974-Shop-By-Category_HP-4_29.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Sunglasses & Frames",
                    PromotionSubCategory="",
                    PromotionDiscount="80",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 45,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/130ceab4-ac68-42c5-a9f4-478ba7f903db1690787339061-Shop-By-Category_HP-4_30.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Topwear",
                    PromotionSubCategory="Formal Shirts",
                    PromotionDiscount="40",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 46,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/cda4c195-22c1-4e11-a9dc-4728d69c3f2b1690787338956-Shop-By-Category_HP-4_31.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Western Wear",
                    PromotionSubCategory="Dresses",
                    PromotionDiscount="40",
                    PromotionBrands=""
                },
                // blank  image
                new Promotions()
                {
                    PromoionId = 47,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_196,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/46090f9c-e337-4a58-9d67-16bf4b977c6f1690787339358-Shop-By-Category_HP-4_32.jpg",
                    PromotionMainCategory="",
                    PromotionCategory="",
                    PromotionSubCategory="",
                    PromotionDiscount="",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 48,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_196,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/89e0a0ee-225d-4880-a761-6aa895d252871690787338993-Shop-By-Category_HP-4_33.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Bags & Backpacks",
                    PromotionSubCategory="",
                    PromotionDiscount="30",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 49,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_196,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/82cdf918-9ad9-41fa-a5a7-c4c86fbad90c1690787338876-Shop-By-Category_HP-4_34.jpg",
                    PromotionMainCategory="",
                    PromotionCategory="Bags & Backpacks",
                    PromotionSubCategory="",
                    PromotionDiscount="30",
                    PromotionBrands=""
                },
                new Promotions()
                {
                    PromoionId = 50,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_196,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/ed2e98bc-e4f4-4e85-bc74-537142205d0f1690787339374-Shop-By-Category_HP-4_35.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Footwear",
                    PromotionSubCategory="Flip Flops",
                    PromotionDiscount="30",
                    PromotionBrands=""
                },
                // blank image
                new Promotions()
                {
                    PromoionId = 51,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_196,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/c61b51c7-67cb-4d02-9f50-3492d08c0bba1690787339256-Shop-By-Category_HP-4_36.jpg",
                    PromotionMainCategory="",
                    PromotionCategory="",
                    PromotionSubCategory="",
                    PromotionDiscount="",
                    PromotionBrands=""
                },
                //blank image
                new Promotions()
                {
                    PromoionId = 52,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_196,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/c61b51c7-67cb-4d02-9f50-3492d08c0bba1690787339256-Shop-By-Category_HP-4_36.jpg",
                    PromotionMainCategory="",
                    PromotionCategory="",
                    PromotionSubCategory="",
                    PromotionDiscount="",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 1,
                    PromotionType = "Banner",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_980,c_limit,fl_progressive,dpr_2.0/assets/images/2022/6/27/53b4daed-cd2c-4111-86c5-14f737eceb351656325318973-Handbags_Desk.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Handbags, Bags & Wallets",
                    PromotionSubCategory="",
                    PromotionDiscount="50",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 2,
                    PromotionType = "MEDAL WORTHY BRANDS TO BAG",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/3/51084b8a-9c9e-4b03-bc4a-dfd7738590eb1691076143197-image_png949061620--1-.png",
                    PromotionMainCategory="Men",
                    PromotionCategory="Footwear",
                    PromotionSubCategory="",
                    PromotionDiscount="50",
                    PromotionBrands="U.S. Polo Assn."
                },
                 new Promotions()
                {
                    PromoionId = 3,
                    PromotionType = "MEDAL WORTHY BRANDS TO BAG",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/3/a9734bdc-8054-4806-8ab4-748d7dfdfe411691066316796-unnamed---2023-08-03T180830.165.png",
                    PromotionMainCategory="Men",
                    PromotionCategory="Footwear",
                    PromotionSubCategory="",
                    PromotionDiscount="50",
                    PromotionBrands="ALDO"
                },
                 new Promotions()
                {
                    PromoionId = 4,
                    PromotionType = "MEDAL WORTHY BRANDS TO BAG",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/3/bf39dcbb-1a94-481c-b943-43fca34bf0581691066296958-unnamed---2023-08-03T180811.304.png",
                    PromotionMainCategory="Women",
                    PromotionCategory="Footwear",
                    PromotionSubCategory="",
                    PromotionDiscount="40",
                    PromotionBrands="Metro"
                },
                 new Promotions()
                {
                    PromoionId = 5,
                    PromotionType = "MEDAL WORTHY BRANDS TO BAG",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/3/bf39dcbb-1a94-481c-b943-43fca34bf0581691066296958-unnamed---2023-08-03T180811.304.png",
                    PromotionMainCategory="Women",
                    PromotionCategory="Footwear",
                    PromotionSubCategory="",
                    PromotionDiscount="40",
                    PromotionBrands="Mochi"
                },
                 new Promotions()
                {
                    PromoionId = 6,
                    PromotionType = "MEDAL WORTHY BRANDS TO BAG",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/3/d6529cc8-ff03-4d85-88b7-5358a1d5a46b1691057399814-image_png1830835492.png",
                    PromotionMainCategory="",
                    PromotionCategory="Luggages & Trolleys",
                    PromotionSubCategory="",
                    PromotionDiscount="35",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 7,
                    PromotionType = "MEDAL WORTHY BRANDS TO BAG",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/3/4cde4706-089f-4049-9d9c-116d8631af381691056679844-image_png1175979315.png",
                    PromotionMainCategory="",
                    PromotionCategory="Luggages & Trolleys",
                    PromotionSubCategory="",
                    PromotionDiscount="35",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 8,
                    PromotionType = "MEDAL WORTHY BRANDS TO BAG",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/retaillabs/2023/8/4/71a69cc9-210a-4a95-b37f-78319c8f33761691141606256-image_png2064277310.png",
                    PromotionMainCategory="Beauty",
                    PromotionCategory="Skincare Bath & Body",
                    PromotionSubCategory="",
                    PromotionDiscount="35",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 9,
                    PromotionType = "GRAND GLOBAL BRANDS",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/81bcb28d-55f3-4d7b-bb5a-7cf7ee7fd8031690773011370-The_Collective.png",
                    PromotionMainCategory="Men",
                    PromotionCategory="Skincare Bath & Body",
                    PromotionSubCategory="",
                    PromotionDiscount="40",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 10,
                    PromotionType = "GRAND GLOBAL BRANDS",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/7aac1f32-1a1a-4ba6-924b-ee1c28553aed1690773011304-Nautica.png",
                    PromotionMainCategory="Men",
                    PromotionCategory="Topwear",
                    PromotionSubCategory="",
                    PromotionDiscount="50",
                    PromotionBrands="Nautica"
                },
                 new Promotions()
                {
                    PromoionId = 11,
                    PromotionType = "GRAND GLOBAL BRANDS",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/437645a4-988c-4f53-aff3-b1fdb34938481690773011106-FCUK.png",
                    PromotionMainCategory="",
                    PromotionCategory="",
                    PromotionSubCategory="",
                    PromotionDiscount="40",
                    PromotionBrands="French Connection"
                },
                 new Promotions()
                {
                    PromoionId = 12,
                    PromotionType = "GRAND GLOBAL BRANDS",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/0c399e2c-9797-483d-bf6c-0852d5d21db21690773010989-BHPC.png",
                    PromotionMainCategory="",
                    PromotionCategory="",
                    PromotionSubCategory="",
                    PromotionDiscount="40",
                    PromotionBrands="Polo"
                },
                 new Promotions()
                {
                    PromoionId = 13,
                    PromotionType = "GRAND GLOBAL BRANDS",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/044555a5-9987-4a06-8679-8aeb2dd963f91690773011013-boohooMan.png",
                    PromotionMainCategory="Men",
                    PromotionCategory="",
                    PromotionSubCategory="",
                    PromotionDiscount="40",
                    PromotionBrands="boohooMAN"
                },
                 new Promotions()
                {
                    PromoionId = 14,
                    PromotionType = "GRAND GLOBAL BRANDS",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/2/805eeb23-ec17-4b50-b798-1244133c02041690955797245-image_png_1993656242.png",
                    PromotionMainCategory="Men",
                    PromotionCategory="",
                    PromotionSubCategory="",
                    PromotionDiscount="30",
                    PromotionBrands="Mango"
                },
                 new Promotions()
                {
                    PromoionId = 15,
                    PromotionType = "GRAND GLOBAL BRANDS",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/6b6c7162-0086-4967-90c8-ec4792ec200c1690773011082-Dorothy_Perkin-_Boohoo.png",
                    PromotionMainCategory="Women",
                    PromotionCategory="Footwear",
                    PromotionSubCategory="",
                    PromotionDiscount="30",
                    PromotionBrands="Boohoo"
                },
                 new Promotions()
                {
                    PromoionId = 16,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/0dedd7c2-6c01-4ab0-a907-8928e56066d41690787339184-Shop-By-Category_HP-4_02.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Indian & Fusion Wear",
                    PromotionSubCategory="Ethnic Wear",
                    PromotionDiscount="50",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 17,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/bfab4827-0ea6-4a5b-8b8d-167d497ae78e1690787339167-Shop-By-Category_HP-4_03.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Topwear",
                    PromotionSubCategory="Casual Shirts",
                    PromotionDiscount="40",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 18,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/c61cfcfb-749f-4d8e-a318-0ea8f8705a1c1690787339442-Shop-By-Category_HP-4_04.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Sports & Active Wear",
                    PromotionSubCategory="",
                    PromotionDiscount="30",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 19,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/a50c2dec-c5bc-46f3-b754-294fb46c61971690787339077-Shop-By-Category_HP-4_05.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Men",
                    PromotionSubCategory="",
                    PromotionDiscount="30",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 20,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/da4059bf-14f1-4928-b5b9-be8719887b8e1690787339149-Shop-By-Category_HP-4_06.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Western Wear",
                    PromotionSubCategory="",
                    PromotionDiscount="40",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 21,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/3a804edc-ce57-4eb5-bb6a-493d458973661690787338896-Shop-By-Category_HP-4_07.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Sports & Active Wear",
                    PromotionSubCategory="",
                    PromotionDiscount="30",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 22,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/84870fc6-4805-41a4-b9eb-a8d7adb6c0d21690787339128-Shop-By-Category_HP-4_08.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Indian & Fusion Wear",
                    PromotionSubCategory="Leggings, Salwars & Churidars",
                    PromotionDiscount="30",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 23,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/069d06bc-1b75-43f4-b8d1-1ec46193eb021690787339028-Shop-By-Category_HP-4_09.jpg",
                    PromotionMainCategory="Men",
                    PromotionCategory="Innerwear & Sleepwear",
                    PromotionSubCategory="",
                    PromotionDiscount="70",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 24,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/19755254-9c13-40a3-9cab-2bb9714391ab1690787339274-Shop-By-Category_HP-4_10.jpg",
                    PromotionMainCategory="Women",
                    PromotionCategory="Innerwear & Sleepwear",
                    PromotionSubCategory="",
                    PromotionDiscount="70",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 25,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/dd262b36-3a75-464a-97b5-235984080d851690787338916-Shop-By-Category_HP-4_11.jpg",
                    PromotionMainCategory="",
                    PromotionCategory="Watches",
                    PromotionSubCategory="",
                    PromotionDiscount="80",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 26,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/d26e5ed5-d846-4692-88a5-54ab7d79203b1690787339203-Shop-By-Category_HP-4_12.jpg",
                    PromotionMainCategory="",
                    PromotionCategory="Personal Care & Grooming",
                    PromotionSubCategory="",
                    PromotionDiscount="60",
                    PromotionBrands=""
                },
                 new Promotions()
                {
                    PromoionId = 27,
                    PromotionType = "SHOP BY CATEGORY",
                    PromotionImage="https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/dd3d6118-cd57-4e73-a4a4-e7f8a6bfde7b1690787339093-Shop-By-Category_HP-4_13.jpg",
                    PromotionMainCategory="",
                    PromotionCategory="Beauty & Personal Care",
                    PromotionSubCategory="",
                    PromotionDiscount="60",
                    PromotionBrands=""
                }
            };
            // Seed product promotions to database
            modelBuilder.Entity<Promotions>().HasData(promotions);
        }
    }
}
