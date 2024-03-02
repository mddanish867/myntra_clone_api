using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace myntra_clone_api.Migrations
{
    /// <inheritdoc />
    public partial class addedpromotions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "PromoionId", "PromotionBrands", "PromotionCategory", "PromotionDiscount", "PromotionImage", "PromotionMainCategory", "PromotionSubCategory", "PromotionType" },
                values: new object[,]
                {
                    { 1, "", "Handbags, Bags & Wallets", "50", "https://assets.myntassets.com/f_webp,w_980,c_limit,fl_progressive,dpr_2.0/assets/images/2022/6/27/53b4daed-cd2c-4111-86c5-14f737eceb351656325318973-Handbags_Desk.jpg", "Women", "", "Banner" },
                    { 2, "U.S. Polo Assn.", "Footwear", "50", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/3/51084b8a-9c9e-4b03-bc4a-dfd7738590eb1691076143197-image_png949061620--1-.png", "Men", "", "MEDAL WORTHY BRANDS TO BAG" },
                    { 3, "ALDO", "Footwear", "50", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/3/a9734bdc-8054-4806-8ab4-748d7dfdfe411691066316796-unnamed---2023-08-03T180830.165.png", "Men", "", "MEDAL WORTHY BRANDS TO BAG" },
                    { 4, "Metro", "Footwear", "40", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/3/bf39dcbb-1a94-481c-b943-43fca34bf0581691066296958-unnamed---2023-08-03T180811.304.png", "Women", "", "MEDAL WORTHY BRANDS TO BAG" },
                    { 5, "Mochi", "Footwear", "40", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/3/bf39dcbb-1a94-481c-b943-43fca34bf0581691066296958-unnamed---2023-08-03T180811.304.png", "Women", "", "MEDAL WORTHY BRANDS TO BAG" },
                    { 6, "", "Luggages & Trolleys", "35", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/3/d6529cc8-ff03-4d85-88b7-5358a1d5a46b1691057399814-image_png1830835492.png", "", "", "MEDAL WORTHY BRANDS TO BAG" },
                    { 7, "", "Luggages & Trolleys", "35", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/3/4cde4706-089f-4049-9d9c-116d8631af381691056679844-image_png1175979315.png", "", "", "MEDAL WORTHY BRANDS TO BAG" },
                    { 8, "", "Skincare Bath & Body", "35", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/retaillabs/2023/8/4/71a69cc9-210a-4a95-b37f-78319c8f33761691141606256-image_png2064277310.png", "Beauty", "", "MEDAL WORTHY BRANDS TO BAG" },
                    { 9, "", "Skincare Bath & Body", "40", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/81bcb28d-55f3-4d7b-bb5a-7cf7ee7fd8031690773011370-The_Collective.png", "Men", "", "GRAND GLOBAL BRANDS" },
                    { 10, "Nautica", "Topwear", "50", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/7aac1f32-1a1a-4ba6-924b-ee1c28553aed1690773011304-Nautica.png", "Men", "", "GRAND GLOBAL BRANDS" },
                    { 11, "French Connection", "", "40", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/437645a4-988c-4f53-aff3-b1fdb34938481690773011106-FCUK.png", "", "", "GRAND GLOBAL BRANDS" },
                    { 12, "Polo", "", "40", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/0c399e2c-9797-483d-bf6c-0852d5d21db21690773010989-BHPC.png", "", "", "GRAND GLOBAL BRANDS" },
                    { 13, "boohooMAN", "", "40", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/044555a5-9987-4a06-8679-8aeb2dd963f91690773011013-boohooMan.png", "Men", "", "GRAND GLOBAL BRANDS" },
                    { 14, "Mango", "", "30", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/8/2/805eeb23-ec17-4b50-b798-1244133c02041690955797245-image_png_1993656242.png", "Men", "", "GRAND GLOBAL BRANDS" },
                    { 15, "Boohoo", "Footwear", "30", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/6b6c7162-0086-4967-90c8-ec4792ec200c1690773011082-Dorothy_Perkin-_Boohoo.png", "Women", "", "GRAND GLOBAL BRANDS" },
                    { 16, "", "Indian & Fusion Wear", "50", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/0dedd7c2-6c01-4ab0-a907-8928e56066d41690787339184-Shop-By-Category_HP-4_02.jpg", "Women", "Ethnic Wear", "SHOP BY CATEGORY" },
                    { 17, "", "Topwear", "40", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/bfab4827-0ea6-4a5b-8b8d-167d497ae78e1690787339167-Shop-By-Category_HP-4_03.jpg", "Men", "Casual Shirts", "SHOP BY CATEGORY" },
                    { 18, "", "Sports & Active Wear", "30", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/c61cfcfb-749f-4d8e-a318-0ea8f8705a1c1690787339442-Shop-By-Category_HP-4_04.jpg", "Women", "", "SHOP BY CATEGORY" },
                    { 19, "", "Men", "30", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/a50c2dec-c5bc-46f3-b754-294fb46c61971690787339077-Shop-By-Category_HP-4_05.jpg", "Men", "", "SHOP BY CATEGORY" },
                    { 20, "", "Western Wear", "40", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/da4059bf-14f1-4928-b5b9-be8719887b8e1690787339149-Shop-By-Category_HP-4_06.jpg", "Women", "", "SHOP BY CATEGORY" },
                    { 21, "", "Sports & Active Wear", "30", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/3a804edc-ce57-4eb5-bb6a-493d458973661690787338896-Shop-By-Category_HP-4_07.jpg", "Women", "", "SHOP BY CATEGORY" },
                    { 22, "", "Indian & Fusion Wear", "30", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/84870fc6-4805-41a4-b9eb-a8d7adb6c0d21690787339128-Shop-By-Category_HP-4_08.jpg", "Women", "Leggings, Salwars & Churidars", "SHOP BY CATEGORY" },
                    { 23, "", "Innerwear & Sleepwear", "70", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/069d06bc-1b75-43f4-b8d1-1ec46193eb021690787339028-Shop-By-Category_HP-4_09.jpg", "Men", "", "SHOP BY CATEGORY" },
                    { 24, "", "Innerwear & Sleepwear", "70", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/19755254-9c13-40a3-9cab-2bb9714391ab1690787339274-Shop-By-Category_HP-4_10.jpg", "Women", "", "SHOP BY CATEGORY" },
                    { 25, "", "Watches", "80", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/dd262b36-3a75-464a-97b5-235984080d851690787338916-Shop-By-Category_HP-4_11.jpg", "", "", "SHOP BY CATEGORY" },
                    { 26, "", "Personal Care & Grooming", "60", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/d26e5ed5-d846-4692-88a5-54ab7d79203b1690787339203-Shop-By-Category_HP-4_12.jpg", "", "", "SHOP BY CATEGORY" },
                    { 27, "", "Beauty & Personal Care", "60", "https://assets.myntassets.com/f_webp,w_163,c_limit,fl_progressive,dpr_2.0/assets/images/2023/7/31/dd3d6118-cd57-4e73-a4a4-e7f8a6bfde7b1690787339093-Shop-By-Category_HP-4_13.jpg", "", "", "SHOP BY CATEGORY" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "PromoionId",
                keyValue: 27);
        }
    }
}
