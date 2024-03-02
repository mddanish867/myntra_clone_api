using Microsoft.EntityFrameworkCore;
using myntra_clone_api.Data;
using myntra_clone_api.Models;
using System.Drawing;

namespace myntra_clone_api.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<Products>> GetAllProductAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }        
    }
}
