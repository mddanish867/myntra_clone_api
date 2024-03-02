using Microsoft.EntityFrameworkCore;
using myntra_clone_api.Data;
using myntra_clone_api.Models;

namespace myntra_clone_api.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoriesService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<SubCategory>> GetAllCategoryAsync()
        {
            return await _dbContext.SubCategories.ToListAsync();
        }

        public IEnumerable<SubCategory> GetCategoryAsync(string maincategory, string category, string subcategory)
        {
            IQueryable<SubCategory> query = _dbContext.SubCategories;
            if (!string.IsNullOrEmpty(maincategory))
            {
                query = query.Where(x => x.MainCategory == (maincategory));
            }
            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(x => x.Category == (category));
            }
            if (!string.IsNullOrEmpty(subcategory))
            {
                query = query.Where(x => x.SubCategoryName == (subcategory));
            }
            return query.ToList();
        }
    }
}
