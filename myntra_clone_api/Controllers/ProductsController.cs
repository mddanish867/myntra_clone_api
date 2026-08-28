using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using myntra_clone_api.Data;
using myntra_clone_api.Models;
using myntra_clone_api.Models.DTO;
using myntra_clone_api.Services;
using System.Collections.Generic;
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
        private readonly IMapper _mapper;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ApplicationDbContext dbContext,
            IProductService productService,
            IProductSpecificationService productSpecification,
            IMapper mapper,
            ILogger<ProductsController> logger)
        {
            _dbContext = dbContext;
            _productService = productService;
            _productSpecification = productSpecification;
            _mapper = mapper;
            _logger = logger;
        }

        // Get all Product
        [HttpGet]
        public Task<IActionResult> GetAllProducts()
        {
            return HandleRequestAsync<Products, ProductsDto>(_productService.GetAllProductAsync, nameof(GetAllProducts));
        }

        [HttpGet("{productId}")]
        public Task<IActionResult> GetProductSpecificationAsync(int productId)
        {
            return HandleRequestAsync<ProductSpecification, ProductSpecificationDto>(
                () => _productSpecification.GetProductSpecificationAsync(productId),
                nameof(GetProductSpecificationAsync));
        }

        private async Task<IActionResult> HandleRequestAsync<TSource, TDto>(
            Func<Task<IEnumerable<TSource>>> serviceCall,
            string actionName)
        {
            try
            {
                var data = await serviceCall();
                _logger.LogInformation($"Finished {actionName} request data: {JsonSerializer.Serialize(data)}");
                var dto = _mapper.Map<List<TDto>>(data);
                return Ok(dto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}