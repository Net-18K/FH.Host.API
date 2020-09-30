using FH.Host.API.Infrastructure.AppConfigurtaion;
using FH.Host.API.Model.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace FH.Host.API.Infrastructure.SqlSugar
{
    public class OwnerRepository : IOwnerRepository
    {
        private SqlSugarClient _dbBase;
        public OwnerRepository(ISqlSugarClient sqlSugar)
        {
            _dbBase = sqlSugar as SqlSugarClient;
        }
        /// <summary>
        /// 对外的扩展操作
        /// </summary>
        public ISqlSugarClient Db => _db;

        private ISqlSugarClient _db
        {
            get
            {
                _dbBase.ChangeDatabase(AppConfigurtaionService.Configuration["ConnectionStrings:DefaultDBConfigId"]);// 切换到主库标记
                return _dbBase;
            }
        }

        public Task<long> InsertReturnLongAsync<T1>(T1 o, params string[] ignoreColumn) where T1 : class, new()
        {
            return _db.Insertable(o).IgnoreColumns(ignoreColumn).ExecuteReturnBigIdentityAsync();
        }

        public long InsertReturnLong<T1>(T1 o, params string[] ignoreColumn) where T1 : class, new()
        {
            return _db.Insertable(o).IgnoreColumns(ignoreColumn).ExecuteReturnBigIdentity();
        }

        public Task<int> InsertReturnIntAsync<T1>(T1 o, params string[] ignoreColumn) where T1 : class, new()
        {
            return _db.Insertable(o).IgnoreColumns(ignoreColumn).ExecuteReturnIdentityAsync();
        }

        public int InsertReturnInt<T1>(T1 o, params string[] ignoreColumn) where T1 : class, new()
        {
            return _db.Insertable(o).IgnoreColumns(ignoreColumn).ExecuteReturnIdentity();
        }

        public Task<T1> InsertReturnTAsync<T1>(T1 o, params string[] ignoreColumn) where T1 : class, new()
        {
            return _db.Insertable(o).IgnoreColumns(ignoreColumn).ExecuteReturnEntityAsync();
        }

        public T1 InsertReturnT<T1>(T1 o, params string[] ignoreColumn) where T1 : class, new()
        {
            return _db.Insertable(o).IgnoreColumns(ignoreColumn).ExecuteReturnEntity();
        }

        public Task<int> InsertListAsync<T1>(List<T1> o, params string[] ignoreColumn) where T1 : class, new()
        {
            return _db.Insertable(o.ToArray()).IgnoreColumns(ignoreColumn).ExecuteCommandAsync();
        }

        public int InsertList<T1>(List<T1> o, params string[] ignoreColumn) where T1 : class, new()
        {
            return _db.Insertable(o.ToArray()).IgnoreColumns(ignoreColumn).ExecuteCommand();
        }

        public Task<int> ExcuteSqlAsync(string sql, DbParameter[] sqlparms = null)
        {
            return _db.Ado.ExecuteCommandAsync(sql, sqlparms);
        }

        public int ExcuteSql(string sql, DbParameter[] sqlparms = null)
        {
            return _db.Ado.ExecuteCommand(sql, sqlparms);
        }

        public Task<T> QuerySqlSingleAsync<T>(string sql, DbParameter[] sqlparms = null)
        {
            return _db.Ado.SqlQuerySingleAsync<T>(sql, sqlparms);
        }

        public T QuerySqlSingle<T>(string sql, DbParameter[] sqlparms = null)
        {
            return _db.Ado.SqlQuerySingle<T>(sql, sqlparms);
        }

        public Task<List<T>> QuerySqlListAsync<T>(string sql, DbParameter[] sqlparms = null)
        {
            return _db.Ado.SqlQueryAsync<T>(sql, sqlparms);
        }

        public List<T> QuerySqlList<T>(string sql, DbParameter[] sqlparms = null)
        {
            return _db.Ado.SqlQuery<T>(sql, sqlparms);
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
    }
}
