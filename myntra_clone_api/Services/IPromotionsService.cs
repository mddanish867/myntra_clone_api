using myntra_clone_api.Models;

namespace myntra_clone_api.Services
{
    public interface IPromotionsService
    {
        IEnumerable<Promotions> GetPromotionAsync(string promotionType);

    }
}
