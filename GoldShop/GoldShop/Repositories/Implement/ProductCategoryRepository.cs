using System.Threading.Tasks;
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

        public async Task<ProductCategory> Create(ProductCategoryRequest request,bool isCommit)
        {
            ProductCategory productCategory = new ProductCategory()
            {
                Id = new System.Guid(),
                Name = request.Name,
                Description = request.Description,
                Active = true
            };
            await _context.ProductCategories.AddAsync(productCategory);
            if(isCommit)
            {
                await _context.SaveChangesAsync();
            }

            return productCategory;
        }
    }
}