using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldShop.Models.Infrastructure
{
    public class GoldShopDbContext : IdentityDbContext<Account, Role, string>
    {
        public GoldShopDbContext(DbContextOptions<GoldShopDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ConfigurationRelationship.ConfigDefaultDB(builder);
        }
    }
}
