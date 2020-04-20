using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoldShop.Models
{
    public class GoldShopDbContext : IdentityDbContext<Account, IdentityRole, string>
    {
        public GoldShopDbContext(DbContextOptions<GoldShopDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            ConfigurationRelationship.ConfigDefaultDB(builder);

            base.OnModelCreating(builder);
        }
    }
}
