using FH.Host.API.Infrastructure.AppConfigurtaion;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FH.Host.API.Infrastructure.Authorization.Jwt
{
    /// <summary>
    /// Jwt服务类
    /// </summary>
    public class JwtService
    {
        public static string GetToken(string UserName)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name,UserName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AppConfigurtaionService.Configuration["Authentication:SecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            /*
             * Claims（payload）
             * Claims部分包含了一些跟这个Token有关的重要信息。JWT标准规定了一些字段，下面节选一些字段：
             * Iss：Token是给谁的
             * Sub：Token主题
             * Exp：Token过期时间，Unix时间戳格式
             * Iat：Token创建时间，Unix时间戳格式
             * Jti：针对当前Token的唯一标识
             * 除了规定的字段外，可以包含其他任何Json兼容的字段。
             */
            var token = new JwtSecurityToken(
                issuer: AppConfigurtaionService.Configuration["Authentication:Issuer"],
                audience: AppConfigurtaionService.Configuration["Authentication:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(int.Parse(AppConfigurtaionService.Configuration["Authentication:Expired"])),
                signingCredentials: creds);
            var retuenToken = new JwtSecurityTokenHandler().WriteToken(token);
            return retuenToken;
        }
    }
}