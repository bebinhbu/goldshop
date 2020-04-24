using System;
using System.Threading.Tasks;
using GoldShop.DTOs;

namespace GoldShop.Services
{
    public interface IProductCategoriesService
    {
        ///<summary>
        ///Create Category Async
        ///</summary>
        ///<param name="request"></param>
        ///<returns></returns>
        Task<ProductCategoryDTO> CreateCategoryAsync(ProductCategoryRequest request);

        ///<summary>
        ///Update Category Async
        ///</summary>
        ///<param name="request"></param>
        ///<returns></returns>
        Task<ProductCategoryDTO> UpdateCategoryAsync(ProductCategoryRequest request);
    }
}
