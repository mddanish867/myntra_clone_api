using System.ComponentModel.DataAnnotations;

namespace myntra_clone_api.Models.DTO
{
    public class ProductSpecificationDto
    {
        public int SpecificationId { get; set; }
        public string SpecificationKey { get; set; }
        public string SpecificationValue { get; set; }
        public int ProductId { get; set; }
    }
}
