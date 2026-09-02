```csharp
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myntra_clone_api.Data;
using myntra_clone_api.Models.DTO;
using myntra_clone_api.Services;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System; // Required for Exception
using Microsoft.AspNetCore.Http; // Required for StatusCodes

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

        /// <summary>
        /// Encapsulates common try-catch logic, error logging, and HTTP response handling for service calls.
        /// </summary>
        /// <typeparam name="T">The type of the result returned by the service logic.</typeparam>
        /// <param name="serviceLogic">A function that represents the asynchronous service call.</param>
        /// <returns>An <see cref="IActionResult"/> representing the HTTP response.</returns>
        private async Task<IActionResult> HandleServiceCall<T>(Func<Task<T>> serviceLogic)
        {
            try
            {
                T result = await serviceLogic();
                return Ok(result);
            }
            catch (KeyNotFoundException ex)
            {
                _logger.LogWarning(ex, "Resource not found: {Message}", ex.Message);
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred: {Message}", ex.Message);
                // Return a ProblemDetails object for consistent API error responses
                return StatusCode(StatusCodes.Status500InternalServerError, new ProblemDetails
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Title = "An unexpected error occurred",
                    Detail = ex.Message // In a production environment, consider hiding sensitive details or providing a correlation ID
                });
            }
        }

        // Get all categories
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return await HandleServiceCall(GetAllCategoriesInternalAsync);
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
            return await HandleServiceCall(() => GetCategoryInternalAsync(maincategory, category, subcategory));
        }

        private async Task<IEnumerable<CategoriesDTO>> GetCategoryInternalAsync(string maincategory, string category, string subcategory)
        {
            var categoryResponse = await _categories.GetCategoryAsync(maincategory, category, subcategory);
            _logger.LogInformation($"Finished GetCategoryAsync request data: {JsonSerializer.Serialize(categoryResponse)}");

            if (categoryResponse == null)
            {
                throw new KeyNotFoundException($"Category not found for maincategory='{maincategory}', category='{category}', subcategory='{subcategory}'");
            }

            return _mapper.Map<IEnumerable<CategoriesDTO>>(categoryResponse);
        }
    }
}
```