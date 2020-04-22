﻿using System.Net;
using System.Threading.Tasks;
using GoldShop.DTOs;
using GoldShop.Helpers;
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

        public async Task<ProductCategoryDTO> CreateAsync(ProductCategoryRequest request)
        {
            if(await _categoryRepository.CheckExistNameAsync(request.Name))
            {
                throw new CustomException(HttpStatusCode.BadRequest,"Category name is existed");
            }

            var productCategory = await _categoryRepository.CreateAsync(request,true);

            return productCategory;
        }
    }
}
