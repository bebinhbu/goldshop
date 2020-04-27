using System;
using System.Threading.Tasks;
using GoldShop.DTOs;
using GoldShop.Models;

namespace GoldShop.Repositories
{
    public interface IProductCategoryRepository
    {
        ///<summary>
        ///Create Product Category Async
        ///</summary>
        ///<param name="request"></param>
        ///<param name="isCommit"></param>
        ///<returns></returns>
        Task<ProductCategoryDTO> CreateAsync(ProductCategoryRequest request, bool isCommit = true);

        ///<summary>
        ///Update Product Category Async
        ///</summary>
        ///<param name="request"></param>
        ///<param name="isCommit"></param>
        ///<returns></returns>
        Task<ProductCategoryDTO> UpdateAsync(ProductCategoryRequest request, bool isCommit = true);

        ///<summary>
        ///Check Exist Category By Id Async
        ///</summary>
        ///<param name="id"></param>
        ///<returns></returns>
        Task<bool> CheckExistCategoryByIdAsync(Guid id);

        ///<summary>
        ///Check Exist Category By Name Async
        ///</summary>
        ///<param name="categoryName"></param>
        ///<returns></returns>
        Task<bool> CheckExistNameAsync(string categoryName, Guid? id = null);

        ///<summary>
        ///Get Category By Id Async
        ///</summary>
        ///<param name="id"></param>
        ///<param name="isTrackingEnable"></param>
        ///<returns></returns>
        Task<ProductCategory> GetCategoryByIdAsync(Guid id, bool isTrackingEnable = false);

        ///<summary>
        ///Delete Category By Id Async
        ///</summary>
        ///<param name="id"></param>
        ///<param name="isCommit"></param>
        ///<returns></returns>
        Task<Guid> DeleteCategory(Guid id, bool isCommit = true);
    }
}
