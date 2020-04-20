using Microsoft.AspNetCore.Identity;
namespace GoldShop.Models
{
    public class Account : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
    }
}
