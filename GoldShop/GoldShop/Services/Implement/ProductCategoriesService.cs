using System;
using System.Threading.Tasks;
using GoldShop.DTOs;
using GoldShop.Repositories;

namespace GoldShop.Services
{
    public class ProductCategoriesService : IProductCategoriesService
    {
        private readonly IProductCategoryRepository _categoryRepository;

        public ProductCategoriesService(IProductCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<ProductCategoryResponse> Create(ProductCategoryRequest request)
        {
            var productCategory = await _categoryRepository.Create(request,true);

            if(productCategory == null)
            {
                throw new Exception("Cannot create product category");
            }

            return new ProductCategoryResponse(productCategory);
        }
    }
}
