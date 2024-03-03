using System.ComponentModel.DataAnnotations;

namespace myntra_clone_api.Models
{
    public class MainCategory
    {
        [Key]
        public int MainCategoryId { get; set; }
        public string MainCategoryName { get; set; }
    }
}
