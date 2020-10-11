using FH.Host.API.Infrastructure.SqlSugar;
using FH.Host.API.Model.ModelEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FH.Host.API.Application.Copywriting
{
    /// <summary>
    /// 文案服务
    /// </summary>
    [ApiExplorerSettings(GroupName = "FH.Host.APP.API")]
    [Route("api/CopywritingInfoService")]
    [ApiController]
    [Authorize]
    public class CopywritingInfoService
    {
        private readonly IOwnerRepository<FH_CopywritingInfo> _context;

        public CopywritingInfoService(IOwnerRepository<FH_CopywritingInfo> context)
        {
            _context = context;
        }

        /// <summary>
        /// 得到所有文案
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllCopywritingInfo")]
        [AllowAnonymous]
        public async Task<List<FH_CopywritingInfo>> GetAllCopywritingInfo()
        {
            return await _context.GetAll();
        }
    }
}