using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myntra_clone_api.Data;
using myntra_clone_api.Models.DTO;
using myntra_clone_api.Services;
using System.Drawing.Drawing2D;
using System.Text.Json;

namespace myntra_clone_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ICategoriesService _categories;
        private readonly IMapper mapper;
        private readonly ILogger<CategoriesController> logger;

        public CategoriesController(ApplicationDbContext dbContext,
            ICategoriesService categories,
            IMapper mapper,
            ILogger<CategoriesController> logger)
        {
            this._dbContext = dbContext;
            this._categories = categories;
            this.mapper = mapper;
            this.logger = logger;
        }

        // Get all categories
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            try
            {
                // Get data from dtaabase - SubCategory models
                var allCategories = await _categories.GetAllCategoryAsync();
                // Log response
                logger.LogInformation($"Finished GetAllCategories request data: {JsonSerializer.Serialize(allCategories)}");
                // Using Automapper makes much clear code as compare to above method

                var categoryDto = mapper.Map<List<CategoriesDTO>>(allCategories);
                return Ok(categoryDto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }

        }


        [HttpGet]
        [Route("all_category")]
        public  IActionResult GetCategoryAsync([FromQuery] string maincategory, [FromQuery] string category, [FromQuery] string subcategory)
        {
            try
            {
                var categoryResponse = _categories.GetCategoryAsync(maincategory, category, subcategory);
                // log response 
                logger.LogInformation($"Finished GetCategoryAsync request data: {JsonSerializer.Serialize(categoryResponse)}");

                if (categoryResponse == null)
                {
                    return NotFound();
                }
                var categoryDto = mapper.Map<IEnumerable<CategoriesDTO>>(categoryResponse);

                return Ok(categoryDto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }

        }
    
    }
}
