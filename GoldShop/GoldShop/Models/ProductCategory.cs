using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldShop.Models
{
    public class ProductCategory : AuditableEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
