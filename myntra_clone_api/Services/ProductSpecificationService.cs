using Microsoft.EntityFrameworkCore;
using myntra_clone_api.Data;
using myntra_clone_api.Models;

namespace myntra_clone_api.Services
{
    public class ProductSpecificationService : IProductSpecificationService
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductSpecificationService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
       
        public async Task<ProductSpecification> GetProductSpecificationAsync(int productId)
        {
            return await _dbContext.ProductSpecifications.FirstOrDefaultAsync(x => x.ProductId == productId);
        }

    }
}
