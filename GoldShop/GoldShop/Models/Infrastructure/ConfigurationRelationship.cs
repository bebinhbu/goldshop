using Microsoft.EntityFrameworkCore;

namespace GoldShop.Models
{
    public class ConfigurationRelationship
    {
        public static void ConfigDefaultDB(ModelBuilder builder) 
        {
            builder.Entity<Product>(product =>
            {
                product.HasKey(os => new { os.Id });

                product.HasOne(os => os.ProductCategory)
                    .WithMany(r => r.Products)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(os => os.ProductCategoryId)
                    .IsRequired();
            });
        }
    }
}
