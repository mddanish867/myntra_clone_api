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
