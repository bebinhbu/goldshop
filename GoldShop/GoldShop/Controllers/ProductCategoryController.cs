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

        ///<summary>
        ///Create Product Category Async
        ///</summary>
        ///<param name="request">Category information</param>
        ///<returns>The new category information</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorDetails),StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductCategoryDTO>> CreateCategoryAsync([FromBody] ProductCategoryRequest request)
        {
            var productCategoryResponse = await _productCategoriesService.CreateCategoryAsync(request);

            return Ok(productCategoryResponse);
        }

        ///<summary>
        ///Update Product Category Async
        ///</summary>
        ///<param name="id">Category Id</param>
        ///<param name="request">Category information</param>
        ///<returns>The new category information</returns>
        [HttpPut("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductCategoryDTO>> UpdateCategoryAsync(Guid id, [FromBody] ProductCategoryRequest request)
        {
            request.Id = id;

            var productCategoryResponse = await _productCategoriesService.UpdateCategoryAsync(request);

            return Ok(productCategoryResponse);
        }

        ///<summary>
        ///Delete Product Category Async
        ///</summary>
        ///<param name="id">Category Id</param>
        ///<returns>The old category information have deleted</returns>
        [HttpDelete("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductCategoryDTO>> DeleteCategoryAsync(Guid id)
        {
            var productCategoryResponse = await _productCategoriesService.DeleteCategoryAsync(id);

            return Ok(productCategoryResponse);
        }
    }
}