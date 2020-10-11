using FH.Host.API.Infrastructure.Authorization.Jwt;
using FH.Host.API.Infrastructure.Model;
using FH.Host.API.Infrastructure.SqlSugar;
using FH.Host.API.Model.DefaultEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FH.Host.API.Application.Admin
{
    /// <summary>
    /// 管理员服务
    /// </summary>
    [ApiExplorerSettings(GroupName = "FH.Host.Admin.API")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AdminService
    {
        private readonly IOwnerRepository<FH_Admin> _context;

        public AdminService(IOwnerRepository<FH_Admin> repository)
        {
            _context = repository;
        }

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="adminName">管理员账号</param>
        /// <param name="adminPwd">管理员密码</param>
        /// <returns></returns>
        [HttpPost("AdminLogin")]
        [AllowAnonymous]
        public async Task<ResultDto> AdminLogin(string adminName, string adminPwd)
        {
            // 判断是否为空
            if (string.IsNullOrEmpty(adminName) || string.IsNullOrEmpty(adminPwd))
                // 账号或密码不能为空
                throw new Exception("Account or password cannot be empty.");
            var result = await _context
                .GetFirstOrDefault(a =>
                a.AdminName.Equals(adminName) &&
                a.AdminPwd.Equals(adminPwd));
            if (result != null)
                return new ResultDto() { ResultInfo = JwtService.GetToken(adminName) };
            else
                // 账号或密码错误
                throw new Exception("Incorrect username or password.");
        }

        /// <summary>
        /// 查询所有Admin
        /// </summary>
        /// <returns></returns>
        [HttpGet("SellectAll")]
        public async Task<List<FH_Admin>> SellectAll()
        {
            return await _context.GetAll();
        }
    }
}