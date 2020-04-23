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
        ///Check Exist Category By Id Async
        ///</summary>
        ///<param name="id"></param>
        ///<returns></returns>
        Task<bool> ExistCategoryByIdAsync(Guid id);

        ///<summary>
        ///Check Exist Category By Name Async
        ///</summary>
        ///<param name="categoryName"></param>
        ///<returns></returns>
        Task<bool> CheckExistNameAsync(string categoryName);
    }
}
