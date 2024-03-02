using System.ComponentModel.DataAnnotations;

namespace myntra_clone_api.Models
{
    public class MainCategory
    {
        [Required]
        public int MainCategoryId { get; set; }
        public string MainCategoryName { get; set; }
    }
}
