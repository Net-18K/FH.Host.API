using FH.Host.API.Infrastructure.SqlSugar;
using FH.Host.API.Model.ModelEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FH.Host.API.Application.BackGroundImage
{
    /// <summary>
    /// 背景图片服务
    /// </summary>
    [ApiExplorerSettings(GroupName = "FH.Host.App.API")]
    [Route("api/BackGroundImageInfoService")]
    [ApiController]
    [Authorize]
    public class BackGroundImageInfoService
    {
        private readonly IOwnerRepository<FH_BackGroundImageInfo> _context;

        public BackGroundImageInfoService(IOwnerRepository<FH_BackGroundImageInfo> context)
        {
            _context = context;
        }

        /// <summary>
        /// 得到所有背景图片信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllBackGroundImageInfo")]
        [AllowAnonymous]
        public async Task<List<FH_BackGroundImageInfo>> GetAllBackGroundImageInfo()
        {
            return await _context.GetAll();
        }
    }
}