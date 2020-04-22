using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using GoldShop.DTOs;
using GoldShop.Models;

namespace GoldShop.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly GoldShopDbContext _context;
        private readonly IMapper _mapper;
        public ProductCategoryRepository(GoldShopDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductCategoryDTO> CreateAsync(ProductCategoryRequest request,bool isCommit = true)
        {
            var productCategory = _mapper.Map<ProductCategory>(request);

            await _context.AddAsync(productCategory);
            if(isCommit)
            {
                await _context.SaveChangesAsync();
            }

            return _mapper.Map<ProductCategoryDTO>(productCategory);
        }

        public async Task<bool> ExistCategoryByIdAsync(Guid id)
        {
            return await _context.ProductCategories.AsNoTracking().AnyAsync(x => x.DeletedAt == null && x.Id == id);
        }

        public async Task<bool> CheckExistNameAsync(string categoryName)
        {
            return await _context.ProductCategories.AsNoTracking().AnyAsync(x => x.DeletedAt == null && x.Name.ToLower() == categoryName.ToLower());
        }
    }
}