using System.Threading.Tasks;
using GoldShop.DTOs;
using GoldShop.Models;

namespace GoldShop.Repositories
{
    public interface IProductCategoryRepository
    {
        Task<ProductCategory> Create(ProductCategoryRequest request, bool isCommit);
    }
}
