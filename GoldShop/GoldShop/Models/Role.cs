using Microsoft.AspNetCore.Identity;

namespace GoldShop.Models
{
    public class Role : IdentityRole
    {
        public Role() { }
        public Role(string fullName) : base(fullName) { }
        public string FullName { get; set; }
    }
}
