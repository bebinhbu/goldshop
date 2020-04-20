using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace GoldShop.DTOs
{
    public class TokenModel
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public double expires_in { get; set; }
        public TokenModel() { }
        public TokenModel(string token, JwtSecurityToken properties)
        {
            access_token = token;
            token_type = "bearer";
            expires_in = Math.Floor(properties.ValidTo.Subtract(properties.ValidFrom).TotalMinutes);
        }
    }
}
