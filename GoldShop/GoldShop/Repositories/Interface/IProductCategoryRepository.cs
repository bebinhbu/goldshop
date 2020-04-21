using System;
using System.Threading.Tasks;
using GoldShop.DTOs;
using GoldShop.Models;

namespace GoldShop.Repositories
{
    public interface IProductCategoryRepository
    {
        Task<ProductCategory> Create(ProductCategoryRequest request, bool isCommit = true);
        Task<bool> FindById(Guid id);
        Task<bool> CheckExistName(string name);
    }
}
