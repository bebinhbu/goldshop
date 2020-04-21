using System.Threading.Tasks;
using GoldShop.DTOs;

namespace GoldShop.Services
{
    public interface IProductCategoriesService
    {
        Task<ProductCategoryResponse> Create(ProductCategoryRequest request);
    }
}
