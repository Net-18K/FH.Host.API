using FH.Host.API.Model.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FH.Host.API.Infrastructure.SqlSugar
{
    public interface ILogRepository
    {
        /// <summary>
        /// 执行数据库主体
        /// </summary>
        ISqlSugarClient LogDb { get; }

        /// <summary>
        /// 分页查询异步
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereExpression">表达式树</param>
        /// <param name="intPageIndex">当前页</param>
        /// <param name="intPageSize">每页容量</param>
        /// <param name="strOrderByFileds">排序字段</param>
        /// <returns></returns>
        Task<PageModel<T>> QueryPageAsync<T>(Expression<Func<T, bool>> whereExpression, int intPageIndex = 1, int intPageSize = 20, string strOrderByFileds = null) where T : class;

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereExpression">表达式树</param>
        /// <param name="intPageIndex">当前页</param>
        /// <param name="intPageSize">每页容量</param>
        /// <param name="strOrderByFileds">排序字段</param>
        /// <returns></returns>
        PageModel<T> QueryPage<T>(Expression<Func<T, bool>> whereExpression, int intPageIndex = 1, int intPageSize = 20, string strOrderByFileds = null) where T : class;

        /// <summary>
        /// 插入 返回自增间的值bigint异步
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <param name="ignoreColumn">需要排除的列</param>
        /// <returns></returns>
        Task<long> InsertReturnLongAsync<T>(T o, params string[] ignoreColumn) where T : class, new();

        /// <summary>
        /// 插入 返回自增间的值bigint
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <param name="ignoreColumn">需要排除的列</param>
        /// <returns></returns>
        long InsertReturnLong<T>(T o, params string[] ignoreColumn) where T : class, new();

    }
}
