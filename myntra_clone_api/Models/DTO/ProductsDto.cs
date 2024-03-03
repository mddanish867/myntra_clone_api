using System.ComponentModel.DataAnnotations;

namespace myntra_clone_api.Models.DTO
{
    public class ProductsDto
    {
        [Required]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string Description { get; set; }
        public string MainCategory { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public bool IsCOD { get; set; }
        public double Rating { get; set; }
        public double OriginalPrice { get; set; }
        public double DiscountedPrice { get; set; }       
        public string Sellers { get; set; }
        public string ProductDetails { get; set; }
        public string SizeFit { get; set; }
        public string MaterialCare { get; set; }
    }
}
