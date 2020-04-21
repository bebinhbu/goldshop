using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GoldShop.DTOs;
using GoldShop.Models;

namespace GoldShop.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly GoldShopDbContext _context;
        public ProductCategoryRepository(GoldShopDbContext context)
        {
            _context = context;
        }

        public async Task<ProductCategory> Create(ProductCategoryRequest request,bool isCommit = true)
        {
            ProductCategory productCategory = new ProductCategory()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                Active = true,
                CreatedDate = DateTime.Now
            };
            await _context.AddAsync(productCategory);
            if(isCommit)
            {
                await _context.SaveChangesAsync();
            }

            return productCategory;
        }

        public async Task<bool> FindById(Guid id)
        {
            return await _context.ProductCategories.AnyAsync(x => x.DeletedAt == null && x.Id == id);
        }

        public async Task<bool> CheckExistName(string name)
        {
            return await _context.ProductCategories.AnyAsync(x => x.DeletedAt == null && x.Name.ToLower() == name.ToLower());
        }
    }
}