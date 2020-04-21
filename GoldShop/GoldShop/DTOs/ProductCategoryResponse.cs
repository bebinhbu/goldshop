using GoldShop.Models;
using System;

namespace GoldShop.DTOs
{
    public class ProductCategoryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public ProductCategoryResponse(ProductCategory productCategory)
        {
            Id = productCategory.Id;
            Name = productCategory.Name;
            Description = productCategory.Description;
        }
    }
}
