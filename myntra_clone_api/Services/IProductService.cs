using myntra_clone_api.Models;
using System.Drawing;

namespace myntra_clone_api.Services
{
    public interface IProductService
    {
        Task<List<Products>> GetAllProductAsync();
    }

}
