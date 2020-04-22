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
        Task<ProductCategoryDTO> CreateAsync(ProductCategoryRequest request);

        ///<summary>
        ///Update Category Async
        ///</summary>
        ///<param name="id"></param>
        ///<param name="request"></param>
        ///<returns></returns>
        Task<ProductCategoryDTO> UpdateAsync(Guid id, ProductCategoryRequest request);
    }
}
