using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoldShop.Models
{
    public class ProductCategory : AuditableEntity<Guid>
    {
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
