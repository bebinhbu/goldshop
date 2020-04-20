using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldShop.Models
{
    public class Account : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
    }
}
