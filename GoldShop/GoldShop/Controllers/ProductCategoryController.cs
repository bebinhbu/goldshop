using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GoldShop.DTOs;
using GoldShop.Services;

namespace GoldShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IProductCategoriesService _productCategoriesService;

        public ProductCategoryController(IProductCategoriesService productCategoriesService)
        {
            _productCategoriesService = productCategoriesService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorDetails),StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductCategoryResponse>> Create([FromBody] ProductCategoryRequest request)
        {
            var productCategoryResponse = await _productCategoriesService.Create(request);

            return Ok(productCategoryResponse);
        }
    }
}