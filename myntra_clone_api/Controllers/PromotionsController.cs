using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myntra_clone_api.Data;
using myntra_clone_api.Models.DTO;
using myntra_clone_api.Services;
using System.Text.Json;

namespace myntra_clone_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IPromotionsService _promotions;
        private readonly IMapper mapper;
        private readonly ILogger<PromotionsController> logger;

        public PromotionsController(ApplicationDbContext dbContext,
            IPromotionsService promotions,
            IMapper mapper,
            ILogger<PromotionsController> logger)
        {
            this._dbContext = dbContext;
            this._promotions = promotions;
            this.mapper = mapper;
            this.logger = logger;
        }

        [HttpGet]
        [Route("all_category")]
        public IActionResult GetPromotionAsync([FromQuery] string promotionType)
        {
            try
            {
                var promotions = _promotions.GetPromotionAsync(promotionType);
                // log response 
                logger.LogInformation($"Finished GetCategoryAsync request data: {JsonSerializer.Serialize(promotions)}");

                if (promotions == null)
                {
                    return NotFound();
                }
                var promotionDto = mapper.Map<IEnumerable<PromotionsDto>>(promotions);

                return Ok(promotionDto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }

        }
    }
}
