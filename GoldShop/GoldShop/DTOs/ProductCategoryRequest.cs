using System;

namespace GoldShop.DTOs
{
    public class ProductCategoryRequest
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
