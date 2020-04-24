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

        public async Task<ProductCategoryDTO> UpdateAsync(ProductCategoryRequest request, bool isCommit = true)
        {
            try
            {
                _context.ChangeTracker.AutoDetectChangesEnabled = true;

                var productCategory = await GetCategoryByIdAsync(request.Id.Value,true);
                productCategory = _mapper.Map(request, productCategory);
                if (isCommit)
                {
                    await _context.SaveChangesAsync();
                }

                return _mapper.Map<ProductCategoryDTO>(productCategory);
            }
            finally
            {
                _context.ChangeTracker.AutoDetectChangesEnabled = false;
            }
        }

        public async Task<bool> CheckExistCategoryByIdAsync(Guid id)
        {
            return await _context.ProductCategories.AsNoTracking().AnyAsync(x => x.DeletedAt == null && x.Id == id);
        }

        public async Task<bool> CheckExistNameAsync(string categoryName, Guid? id = null)
        {
            return await _context.ProductCategories.AsNoTracking().AnyAsync(x => x.DeletedAt == null && x.Name.ToLower() == categoryName.ToLower() && x.Id != id);
        }

        public async Task<ProductCategory> GetCategoryByIdAsync(Guid id, bool isTrackingEnable = false)
        {
            return isTrackingEnable
           ? await _context.ProductCategories.AsTracking().SingleOrDefaultAsync(x => x.DeletedAt == null && x.Id == id)
           : await _context.ProductCategories.AsNoTracking().SingleOrDefaultAsync(x => x.DeletedAt == null && x.Id == id);
        }
    }
}