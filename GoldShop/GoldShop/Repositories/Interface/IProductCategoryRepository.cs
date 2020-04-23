using System;
using System.Threading.Tasks;
using GoldShop.DTOs;
using GoldShop.Models;

namespace GoldShop.Repositories
{
    public interface IProductCategoryRepository
    {
        Task<ProductCategoryDTO> CreateAsync(ProductCategoryRequest request, bool isCommit = true);
        Task<bool> ExistCategoryByIdAsync(Guid id);
        Task<bool> CheckExistNameAsync(string categoryName);
    }
}
