using AutoMapper;
using System.Drawing.Drawing2D;
using System.Drawing;
using myntra_clone_api.Models;
using myntra_clone_api.Models.DTO;

namespace myntra_clone_api.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        // Insatll AutoMapper Nuget named AutoMapper and inject into Program.cs file
        public AutoMapperProfiles()
        {
            CreateMap<Products, ProductsDto>().ReverseMap();
            CreateMap<SubCategory, CategoriesDTO>().ReverseMap();
            CreateMap<ProductSpecification, ProductSpecificationDto>().ReverseMap();
            CreateMap<Promotions, PromotionsDto>().ReverseMap();

        }
    }
}
