using FH.Host.API.Model.Model;
using SqlSugar;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FH.Host.API.Infrastructure.SqlSugar
{
    /// <summary>
    /// SqlSugar对日志操作方法的封装接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ILogRepository<T> where T : class, new()
    {
        /// <summary>
        /// 执行数据库主体
        /// </summary>
        ISqlSugarClient LogDb { get; }

        /// <summary>
        /// 插入 返回自增间的值bigint异步
        /// </summary>
        /// <param name="model"></param>
        /// <param name="ignoreColumn">需要排除的列</param>
        /// <returns></returns>
        Task<long> InsertReturnLongAsync(T model, params string[] ignoreColumn);

        /// <summary>
        /// 插入 返回自增间的值bigint
        /// </summary>
        /// <param name="model"></param>
        /// <param name="ignoreColumn">需要排除的列</param>
        /// <returns></returns>
        long InsertReturnLong(T model, params string[] ignoreColumn);

        /// <summary>
        /// 分页查询异步
        /// </summary>
        /// <param name="whereExpression">表达式树</param>
        /// <param name="intPageIndex">当前页</param>
        /// <param name="intPageSize">每页容量</param>
        /// <param name="strOrderByFileds">排序字段</param>
        /// <returns></returns>
        Task<PageModel<T>> QueryPageAsync(Expression<Func<T, bool>> whereExpression, int intPageIndex = 1, int intPageSize = 20, string strOrderByFileds = null);

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="whereExpression">表达式树</param>
        /// <param name="intPageIndex">当前页</param>
        /// <param name="intPageSize">每页容量</param>
        /// <param name="strOrderByFileds">排序字段</param>
        /// <returns></returns>
        PageModel<T> QueryPage(Expression<Func<T, bool>> whereExpression, int intPageIndex = 1, int intPageSize = 20, string strOrderByFileds = null);
    }
}