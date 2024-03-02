using System.ComponentModel.DataAnnotations;

namespace myntra_clone_api.Models
{
    public class Promotions
    {
        [Key]
        public int PromoionId { get; set; }
        public string PromotionType { get; set; }
        public string PromotionImage { get; set; }
        public string PromotionMainCategory { get; set; }
        public string PromotionCategory { get; set; }
        public string PromotionSubCategory { get; set; }
        public string PromotionDiscount { get; set; }
        public string PromotionBrands { get; set; }
    }
}
