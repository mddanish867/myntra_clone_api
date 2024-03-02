using myntra_clone_api.Models;
using System.Drawing;

namespace myntra_clone_api.Services
{
    public interface ICategoriesService
    {
        Task<List<SubCategory>> GetAllCategoryAsync();
        IEnumerable<SubCategory> GetCategoryAsync(string maincategory, string category, string subcategory);
    }
}
