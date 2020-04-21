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
        IProductCategoriesService _productCategoriesService;

        public ProductCategoryController(IProductCategoriesService productCategoriesService)
        {
            _productCategoriesService = productCategoriesService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductCategoryResponse>> Create([FromBody] ProductCategoryRequest request)
        {
            ErrorModel errors = new ErrorModel();
            try
            {
                ProductCategoryResponse productCategoryResponse = await _productCategoriesService.Create(request);
                if(productCategoryResponse != null)
                {
                    return Ok(productCategoryResponse);
                }
            }
            catch(Exception ex)
            {
                errors.Add(ex.Message);
            }
            return BadRequest(errors);
        }
    }
}