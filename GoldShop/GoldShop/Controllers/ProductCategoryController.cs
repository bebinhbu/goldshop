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
        ///Create Product Category
        ///</summary>
        ///<param name="request">Category information</param>
        ///<returns>The new category information</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorDetails),StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductCategoryDTO>> Create([FromBody] ProductCategoryRequest request)
        {
            var productCategoryResponse = await _productCategoriesService.CreateAsync(request);

            return Ok(productCategoryResponse);
        }

        ///<summary>
        ///Update Product Category
        ///</summary>
        ///<param name="id">Category Id</param>
        ///<param name="request">Category information</param>
        ///<returns>The new category information</returns>
        [HttpPut("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductCategoryDTO>> Update(Guid id, [FromBody] ProductCategoryRequest request)
        {
            request.Id = id;

            var productCategoryResponse = await _productCategoriesService.UpdateAsync(request);

            return Ok(productCategoryResponse);
        }
    }
}