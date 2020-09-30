using FH.Host.API.Model.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FH.Host.API.Infrastructure.SqlSugar
{
    public interface IOwnerRepository
    {
        /// <summary>
        /// 对外执行主体
        /// </summary>
        ISqlSugarClient Db { get; }

        /// <summary>
        /// 插入 返回自增间的值bigint
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

        /// <summary>
        /// 插入 返回自增间的值int
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <param name="ignoreColumn">需要排除的列</param>
        /// <returns></returns>
        Task<int> InsertReturnIntAsync<T>(T o, params string[] ignoreColumn) where T : class, new();

        /// <summary>
        /// 插入 返回自增间的值int
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <param name="ignoreColumn">需要排除的列</param>
        /// <returns></returns>
        int InsertReturnInt<T>(T o, params string[] ignoreColumn) where T : class, new();

        /// <summary>
        /// 插入 返回T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <param name="ignoreColumn">需要排除的列</param>
        /// <returns></returns>
        Task<T> InsertReturnTAsync<T>(T o, params string[] ignoreColumn) where T : class, new();

        /// <summary>
        /// 插入 返回T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <param name="ignoreColumn">需要排除的列</param>
        /// <returns></returns>
        T InsertReturnT<T>(T o, params string[] ignoreColumn) where T : class, new();

        /// <summary>
        /// 批量插入返回受影响的行数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        Task<int> InsertListAsync<T>(List<T> o, params string[] ignoreColumn) where T : class, new();

        /// <summary>
        /// 批量插入返回受影响的行数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        int InsertList<T>(List<T> o, params string[] ignoreColumn) where T : class, new();

        /// <summary>
        /// 执行SQL语句返回受影响的行数 适合insert/update/delete
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlparms"></param>
        /// <returns></returns>
        Task<int> ExcuteSqlAsync(string sql, DbParameter[] sqlparms = null);

        /// <summary>
        /// 执行SQL语句返回受影响的行数 适合insert/update/delete
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlparms"></param>
        /// <returns></returns>
        int ExcuteSql(string sql, DbParameter[] sqlparms = null);

        /// <summary>
        /// 执行SQL语句返回唯一结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="sqlparms"></param>
        /// <returns></returns>
        Task<T> QuerySqlSingleAsync<T>(string sql, DbParameter[] sqlparms = null);

        /// <summary>
        /// 执行SQL语句返回唯一结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="sqlparms"></param>
        /// <returns></returns>
        T QuerySqlSingle<T>(string sql, DbParameter[] sqlparms = null);

        /// <summary>
        /// 执行SQL语句返回结果集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="sqlparms"></param>
        /// <returns></returns>
        Task<List<T>> QuerySqlListAsync<T>(string sql, DbParameter[] sqlparms = null);

        /// <summary>
        /// 执行SQL语句返回结果集
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="sqlparms"></param>
        /// <returns></returns>
        List<T> QuerySqlList<T>(string sql, DbParameter[] sqlparms = null);

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
    }
}