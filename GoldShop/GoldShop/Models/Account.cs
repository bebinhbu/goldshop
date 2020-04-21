using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GoldShop.Models
{
    public class Account : IdentityUser
    {
        [PersonalData]
        [MaxLength(50)]
        public string FullName { get; set; }
    }
}
