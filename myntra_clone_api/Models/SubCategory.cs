using System.ComponentModel.DataAnnotations;

namespace myntra_clone_api.Models
{
    public class SubCategory
    {
        [Required]
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string MainCategory { get; set; }
        public string Category { get; set; }

    }
}
