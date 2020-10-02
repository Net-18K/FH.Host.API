using FH.Host.API.Infrastructure.SqlSugar;
using FH.Host.API.Model.LogEntity;
using System.Threading.Tasks;

namespace FH.Host.API.Application.SqlLog
{
    /// <summary>
    /// Sql日志服务
    /// </summary>
    //[ApiExplorerSettings(GroupName = "FH.Host.Admin.API")]
    //[Route("api/[controller]")]
    //[ApiController]
    public class SqlLogService
    {
        private readonly ILogRepository<FH_SqlLog> _context;

        public SqlLogService(ILogRepository<FH_SqlLog> repository)
        {
            _context = repository;
        }

        /// <summary>
        /// 添加Sql执行日志
        /// </summary>
        /// <returns></returns>
        //[HttpGet("AddSqlLog")]
        public async Task AddSqlLog(string sql)
        {
            var model = new FH_SqlLog()
            {
                Sql = sql
            };
            await _context.InsertReturnLongAsync(model);
        }
    }
}