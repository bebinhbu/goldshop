﻿using System;
using System.Net;
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

        public async Task<ProductCategoryDTO> CreateCategoryAsync(ProductCategoryRequest request)
        {
            if(await _categoryRepository.CheckExistNameAsync(request.Name))
            {
                throw new CustomException(HttpStatusCode.BadRequest,"Category name is existed");
            }

            var productCategory = await _categoryRepository.CreateAsync(request,true);

            return productCategory;
        }

        public async Task<ProductCategoryDTO> UpdateCategoryAsync(ProductCategoryRequest request)
        {
            if(!await _categoryRepository.CheckExistCategoryByIdAsync(request.Id.Value))
            {
                throw new CustomException(HttpStatusCode.NotFound, "Product category is not found");
            }

            if (await _categoryRepository.CheckExistNameAsync(request.Name, request.Id.Value))
            {
                throw new CustomException(HttpStatusCode.BadRequest, "Category name is existed");
            }

            var productCategory = await _categoryRepository.UpdateAsync(request, true);

            return productCategory;
        }

        public async Task<Guid> DeleteCategoryAsync(Guid id)
        {
            if (!await _categoryRepository.CheckExistCategoryByIdAsync(id))
            {
                throw new CustomException(HttpStatusCode.NotFound, "Product category is not found");
            }

            var productCategory = await _categoryRepository.DeleteCategory(id, true);

            return productCategory;
        }
    }
}
