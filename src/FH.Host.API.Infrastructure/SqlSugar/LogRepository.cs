using FH.Host.API.Infrastructure.AppConfigurtaion;
using FH.Host.API.Model.Model;
using SqlSugar;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FH.Host.API.Infrastructure.SqlSugar
{
    public class LogRepository : ILogRepository
    {
        private SqlSugarClient _dbBase;

        /// <summary>
        /// 对外的扩展操作
        /// </summary>
        public LogRepository(ISqlSugarClient sqlSugar)
        {
            _dbBase = sqlSugar as SqlSugarClient;
        }

        private ISqlSugarClient _db
        {
            get
            {
                _dbBase.ChangeDatabase(AppConfigurtaionService.Configuration["ConnectionStrings:DefaultLogDBConfigId"]);// 切换到日志库标记
                return _dbBase;
            }
        }

        public ISqlSugarClient LogDb => _db;

        public long InsertReturnLong<T>(T o, params string[] ignoreColumn) where T : class, new()
        {
            return _db.Insertable(o).IgnoreColumns(ignoreColumn).ExecuteReturnBigIdentity();
        }

        public Task<long> InsertReturnLongAsync<T>(T o, params string[] ignoreColumn) where T : class, new()
        {
            return _db.Insertable(o).IgnoreColumns(ignoreColumn).ExecuteReturnBigIdentityAsync();
        }

        public PageModel<T> QueryPage<T>(Expression<Func<T, bool>> whereExpression, int intPageIndex = 1, int intPageSize = 20, string strOrderByFileds = null) where T : class
        {
            int totalCount = 0;
            var list = _db.Queryable<T>()
             .WhereIF(whereExpression != null, whereExpression)
             .OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds)
             .ToPageList(intPageIndex, intPageSize, ref totalCount);

            int pageCount = (int)(Math.Ceiling((totalCount * 1.0) / (intPageSize * 1.0)));
            return new PageModel<T>() { dataCount = totalCount, pageCount = pageCount, page = intPageIndex, pageSize = intPageSize, data = list };
        }

        public async Task<PageModel<T>> QueryPageAsync<T>(Expression<Func<T, bool>> whereExpression, int intPageIndex = 1, int intPageSize = 20, string strOrderByFileds = null) where T : class
        {
            RefAsync<int> totalCount = 0;
            var list = await _db.Queryable<T>()
             .WhereIF(whereExpression != null, whereExpression)
             .OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds)
             .ToPageListAsync(intPageIndex, intPageSize, totalCount);

            int pageCount = (int)(Math.Ceiling((totalCount * 1.0) / (intPageSize * 1.0)));
            return new PageModel<T>() { dataCount = totalCount, pageCount = pageCount, page = intPageIndex, pageSize = intPageSize, data = list };
        }
    }
}