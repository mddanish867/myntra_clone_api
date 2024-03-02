using System.ComponentModel.DataAnnotations;

namespace myntra_clone_api.Models
{
    public class ProductSpecification
    {
        [Key]
        public int SpecificationId { get; set; }
        public string SpecificationKey { get; set; }
        public string SpecificationValue { get; set; }
        public int ProductId { get; set; }

    }
}
