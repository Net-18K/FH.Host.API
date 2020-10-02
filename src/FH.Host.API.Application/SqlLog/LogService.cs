using FH.Host.API.Infrastructure.SqlSugar;
using FH.Host.API.Model.LogEntity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace FH.Host.API.Application.SqlLog
{
    /// <summary>
    /// 日志服务
    /// </summary>
    //[ApiExplorerSettings(GroupName = "FH.Host.Admin.API")]
    //[Route("api/[controller]")]
    //[ApiController]
    public class LogService
    {
        private readonly ILogRepository<FH_Log> _context;

        public LogService(ILogRepository<FH_Log> repository)
        {
            _context = repository;
        }
    }
}