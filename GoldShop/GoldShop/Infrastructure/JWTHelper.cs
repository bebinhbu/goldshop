using GoldShop.DTOs;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GoldShop.Helpers
{
    public class JWTHelper
    {
        public static TokenModel GenerateJwtToken(string accountId, string role, IConfiguration configuration)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, accountId),
                new Claim(ClaimTypes.Role, role)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetValue<string>("JWTToken:JwtKey")));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(configuration.GetValue<string>("JWTToken:JwtExpireDays")));

            var jwtSecurityToken = new JwtSecurityToken(
                configuration.GetValue<string>("JWTToken:JwtIssuer"),
                configuration.GetValue<string>("JWTToken:JwtIssuer"),
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new TokenModel(new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken));
        }
    }
}
