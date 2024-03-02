using Microsoft.EntityFrameworkCore;
using myntra_clone_api.Data;
using myntra_clone_api.Models;

namespace myntra_clone_api.Services
{
    public class PromotionsService:IPromotionsService
    {
        private readonly ApplicationDbContext _dbContext;
        public PromotionsService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public IEnumerable<Promotions> GetPromotionAsync(string promotionType)
        {
            IQueryable<Promotions> query = _dbContext.Promotions;
            if (!string.IsNullOrEmpty(promotionType))
            {
                query = query.Where(x => x.PromotionType == (promotionType));
            }
            
            return query.ToList();
        }

    }
}
