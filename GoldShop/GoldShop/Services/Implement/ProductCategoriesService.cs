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
            if(await _categoryRepository.CheckExistName(request.Name))
            {
                throw new Exception("Category name is existed");
            }
            var productCategory = await _categoryRepository.Create(request,true);

            return new ProductCategoryResponse(productCategory);
        }
    }
}
