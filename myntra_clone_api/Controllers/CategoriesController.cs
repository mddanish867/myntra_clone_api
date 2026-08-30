using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myntra_clone_api.Data;
using myntra_clone_api.Models.DTO;
using myntra_clone_api.Services;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace myntra_clone_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ICategoriesService _categories;
        private readonly IMapper _mapper;
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ApplicationDbContext dbContext,
            ICategoriesService categories,
            IMapper mapper,
            ILogger<CategoriesController> logger)
        {
            _dbContext = dbContext;
            _categories = categories;
            _mapper = mapper;
            _logger = logger;
        }

        // Get all categories
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return await ExecuteAsync(async () =>
            {
                var categoriesDto = await GetAllCategoriesInternalAsync();
                return Ok(categoriesDto);
            });
        }

        private async Task<List<CategoriesDTO>> GetAllCategoriesInternalAsync()
        {
            var allCategories = await _categories.GetAllCategoryAsync();
            _logger.LogInformation($"Finished GetAllCategories request data: {JsonSerializer.Serialize(allCategories)}");
            return _mapper.Map<List<CategoriesDTO>>(allCategories);
        }

        [HttpGet]
        [Route("all_category")]
        public async Task<IActionResult> GetCategoryAsync([FromQuery] string maincategory, [FromQuery] string category, [FromQuery] string subcategory)
        {
            return await ExecuteAsync(async () =>
            {
                var categoriesDto = await GetCategoryInternalAsync(maincategory, category, subcategory);
                return Ok(categoriesDto);
            });
        }

        private async Task<IEnumerable<CategoriesDTO>> GetCategoryInternalAsync(string maincategory, string category, string subcategory)
        {
            var categoryResponse = await _categories.GetCategoryAsync(maincategory, category, subcategory);
            _logger.LogInformation($"Finished GetCategoryAsync request data: {JsonSerializer.Serialize(categoryResponse)}");

            if (categoryResponse == null)
            {
                throw new KeyNotFoundException("Category not found");
            }

            return _mapper.Map<IEnumerable<CategoriesDTO>>(categoryResponse);
        }

        private async Task<IActionResult> ExecuteAsync(Func<Task<IActionResult>> action)
        {
            try
            {
                return await action();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}