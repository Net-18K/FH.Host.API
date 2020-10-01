using FH.Host.API.Infrastructure.SqlSugar;
using FH.Host.API.Model.DefaultEntity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FH.Host.API.Application.Admin
{
    [ApiExplorerSettings(GroupName = "FH.Host.Admin.API")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminService
    {
        private readonly OwnerRepository<FH_Admin> _context;

        public AdminService(OwnerRepository<FH_Admin> repository)
        {
            System.Console.WriteLine(repository);
            _context = repository;
        }

        /// <summary>
        /// 查询所有Admin(测试)
        /// </summary>
        /// <returns></returns>
        [HttpGet("SellectAll")]
        public async Task<List<FH_Admin>> SellectAll()
        {
            return await _context.GetAll();
        }
    }
}