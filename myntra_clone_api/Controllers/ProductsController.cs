using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using myntra_clone_api.Data;
using myntra_clone_api.Models;
using myntra_clone_api.Models.DTO;
using myntra_clone_api.Services;
using System.Text.Json;

namespace myntra_clone_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IProductService _productService;
        private readonly IProductSpecificationService _productSpecification;
        private readonly IMapper mapper;
        private readonly ILogger<ProductsController> logger;

        public ProductsController(ApplicationDbContext dbContext,
            IProductService productService,
            IProductSpecificationService productSpecification,
            IMapper mapper,
            ILogger<ProductsController> logger)
        {
            this._dbContext = dbContext;
            this._productService = productService;
            this._productSpecification = productSpecification;
            this.mapper = mapper;
            this.logger = logger;
        }

        // Get all Product
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                //throw new Exception("This is custome exception");

                // Get data from dtaabase - Products models
                var allProducts = await _productService.GetAllProductAsync();               
                // Log response
                logger.LogInformation($"Finished GetAllProducts request data: {JsonSerializer.Serialize(allProducts)}");                       

                // Using Automapper makes much clear code as compare to above method

                var productDto = mapper.Map<List<ProductsDto>>(allProducts);
                return Ok(productDto);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }

        }

        [HttpGet]
        [Route("{productId}")]
        public async Task<IActionResult> GetProductSpecificationAsync(int productId)
        {
            try
            {
                var productSpecification = await _productSpecification.GetProductSpecificationAsync(productId);
                // Log response
                logger.LogInformation($"Finished GetProductSpecificationAsync request data: {JsonSerializer.Serialize(productSpecification)}");
                // Using Automapper makes much clear code as compare to above method                
                return Ok(mapper.Map<List<ProductSpecificationDto>>(productSpecification));
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }



    }
}
