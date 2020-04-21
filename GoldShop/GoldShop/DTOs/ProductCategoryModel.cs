using GoldShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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

    public class ProductCategoryRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
