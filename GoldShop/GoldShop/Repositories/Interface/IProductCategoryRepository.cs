using System;
using System.Threading.Tasks;
using GoldShop.DTOs;
using GoldShop.Models;

namespace GoldShop.Repositories
{
    public interface IProductCategoryRepository
    {
        Task<ProductCategoryDTO> CreateAsync(ProductCategoryRequest request, bool isCommit = true);
        Task<bool> FindByIdAsync(Guid id);
        Task<bool> CheckExistNameAsync(string name);
    }
}
