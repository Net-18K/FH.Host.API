using FH.Host.API.Infrastructure.AppConfigurtaion;
using FH.Host.API.Model.Model;
using SqlSugar;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FH.Host.API.Infrastructure.SqlSugar
{
    /// <summary>
    /// SqlSugar对日志操作方法的封装类
    /// </summary>
    /// <typeparam name="T">需要操作的实体类(表)</typeparam>
    public class LogRepository<T> : ILogRepository<T> where T : class, new()
    {
        private SqlSugarClient _dbBase;

        /// <summary>
        /// 对外的扩展操作
        /// </summary>
        public LogRepository(ISqlSugarClient sqlSugar)
        {
            _dbBase = sqlSugar as SqlSugarClient;
            _dbBase.ChangeDatabase(AppConfigurtaionService.Configuration["ConnectionStrings:DefaultLogDBConfigId"]);// 切换到日志库标记
        }

        /// <summary>
        /// 对外的扩展操作
        /// </summary>
        public ISqlSugarClient LogDb => _logDb;

        private ISqlSugarClient _logDb
        {
            get
            {
                _dbBase.ChangeDatabase(AppConfigurtaionService.Configuration["ConnectionStrings:DefaultLogDBConfigId"]);// 切换到日志库标记
                return _dbBase;
            }
        }

        /// <summary>
        /// 插入 返回自增间的值bigint异步
        /// </summary>
        /// <param name="o"></param>
        /// <param name="ignoreColumn">需要排除的列</param>
        /// <returns></returns>
        public async Task<long> InsertReturnLongAsync(T model, params string[] ignoreColumn)
        {
            return await _dbBase.Insertable(model).IgnoreColumns(ignoreColumn).ExecuteReturnBigIdentityAsync();
        }

        /// <summary>
        /// 插入 返回自增间的值bigint
        /// </summary>
        /// <param name="o"></param>
        /// <param name="ignoreColumn">需要排除的列</param>
        /// <returns></returns>
        public long InsertReturnLong(T model, params string[] ignoreColumn)
        {
            return _dbBase.Insertable(model).IgnoreColumns(ignoreColumn).ExecuteReturnBigIdentity();
        }

        /// <summary>
        /// 分页查询异步
        /// </summary>
        /// <param name="whereExpression">表达式树</param>
        /// <param name="intPageIndex">当前页</param>
        /// <param name="intPageSize">每页容量</param>
        /// <param name="strOrderByFileds">排序字段</param>
        /// <returns></returns>
        public async Task<PageModel<T>> QueryPageAsync(Expression<Func<T, bool>> whereExpression, int intPageIndex = 1, int intPageSize = 20, string strOrderByFileds = null)
        {
            RefAsync<int> totalCount = 0;
            var list = await _dbBase.Queryable<T>()
             .WhereIF(whereExpression != null, whereExpression)
             .OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds)
             .ToPageListAsync(intPageIndex, intPageSize, totalCount);

            int pageCount = (int)(Math.Ceiling((totalCount * 1.0) / (intPageSize * 1.0)));
            return new PageModel<T>() { dataCount = totalCount, pageCount = pageCount, page = intPageIndex, pageSize = intPageSize, data = list };
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="whereExpression">表达式树</param>
        /// <param name="intPageIndex">当前页</param>
        /// <param name="intPageSize">每页容量</param>
        /// <param name="strOrderByFileds">排序字段</param>
        /// <returns></returns>
        public PageModel<T> QueryPage(Expression<Func<T, bool>> whereExpression, int intPageIndex = 1, int intPageSize = 20, string strOrderByFileds = null)
        {
            int totalCount = 0;
            var list = _dbBase.Queryable<T>()
             .WhereIF(whereExpression != null, whereExpression)
             .OrderByIF(!string.IsNullOrEmpty(strOrderByFileds), strOrderByFileds)
             .ToPageList(intPageIndex, intPageSize, ref totalCount);

            int pageCount = (int)(Math.Ceiling((totalCount * 1.0) / (intPageSize * 1.0)));
            return new PageModel<T>() { dataCount = totalCount, pageCount = pageCount, page = intPageIndex, pageSize = intPageSize, data = list };
        }
    }
}