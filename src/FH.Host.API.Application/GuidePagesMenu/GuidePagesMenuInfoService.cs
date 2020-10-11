using FH.Host.API.Infrastructure.SqlSugar;
using FH.Host.API.Model.ModelEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FH.Host.API.Application.GuidePagesMenu
{
    /// <summary>
    /// 引导页菜单服务
    /// </summary>
    [ApiExplorerSettings(GroupName = "FH.Host.App.API")]
    [Route("api/GuidePagesMenuInfoService")]
    [ApiController]
    [Authorize]
    public class GuidePagesMenuInfoService
    {
        private readonly IOwnerRepository<FH_GuidePagesMenuInfo> _context;

        public GuidePagesMenuInfoService(IOwnerRepository<FH_GuidePagesMenuInfo> context)
        {
            _context = context;
        }

        /// <summary>
        /// 得到所有菜单信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllGuidePagesMenuInfo")]
        [AllowAnonymous]
        public async Task<List<FH_GuidePagesMenuInfo>> GetAllGuidePagesMenuInfo()
        {
            return await _context.GetByWhere(g => g.ParentId == 0);
        }
    }
}