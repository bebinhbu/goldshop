using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldShop.Models
{
    public class Product : AuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public Guid ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
