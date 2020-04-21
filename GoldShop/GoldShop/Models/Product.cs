using System;
using System.ComponentModel.DataAnnotations;

namespace GoldShop.Models
{
    public class Product : AuditableEntity<Guid>
    {
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        public double Price { get; set; }
        public Guid ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
