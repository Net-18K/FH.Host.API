using FH.Host.API.Infrastructure.AppConfigurtaion;
using FH.Host.API.Model.LogEntity;
using log4net;
using Microsoft.Extensions.DependencyInjection;
using SqlSugar;
using System;
using System.Collections.Generic;

namespace FH.Host.API.Infrastructure.SqlSugar
{
    /// <summary>
    /// SqlSugar框架服务
    /// </summary>
    public static class SqlSugarService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(SqlSugarService));

        public static void AddSqlSugarSevice(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddScoped<ISqlSugarClient>(o =>
            {
                // 连接字符串
                var listConfig = new List<ConnectionConfig>
                {
                    new ConnectionConfig
                    {
                        ConfigId = AppConfigurtaionService.Configuration["ConnectionStrings:DefaultDBConfigId"],// 此链接标志，用以后面切库使用
                        ConnectionString = AppConfigurtaionService.Configuration["ConnectionStrings:Default"],// 业务库连接字符串
                        DbType = DbType.SqlServer,
                        IsShardSameThread = true,
                        IsAutoCloseConnection = true,// 开启自动释放模式和EF原理一样我就不多解释了
                        InitKeyType = InitKeyType.Attribute,// 从特性读取主键和自增列信息

                        AopEvents = new AopEvents
                        {
                            OnLogExecuting = (sql, pars) =>
                            {
                            // MiniProfiler.Current.CustomTiming("SQL：", GetParas(pars) + "【SQL语句】：" + sql);
                            if (AppConfigurtaionService.Configuration["ConnectionStrings:DbMSSQLMainIsLogSql"] == "True")// 是否记录Sql语句到日志文件中的开关
                            {
                                    log.Info(GetParas(pars) + "【SQL语句】：" + sql);
                            }
                             if (AppConfigurtaionService.Configuration["ConnectionStrings:DbMSSQLMainIsLogSqlToLog"] == "True")// 是否记录Sql语句到数据库中的开关
                            {
                                    // 添加Sql语句到日志库
                                    LogDB.Insertable<FH_SqlLog>(new FH_SqlLog(){Sql = GetParas(pars) + "【SQL语句】：" + sql});
                            }
                            }
                        }
                    },
                    new ConnectionConfig
                    {
                        ConfigId = AppConfigurtaionService.Configuration["ConnectionStrings:DefaultLogDBConfigId"],// 此链接标志，用以后面切库使用
                        ConnectionString = AppConfigurtaionService.Configuration["ConnectionStrings:DefaultLog"],// 日志库连接字符串
                        DbType = DbType.SqlServer,
                        IsShardSameThread = true,
                        IsAutoCloseConnection = true,// 开启自动释放模式和EF原理一样我就不多解释了
                        InitKeyType = InitKeyType.Attribute,// 从特性读取主键和自增列信息

                        AopEvents = new AopEvents
                        {
                            OnLogExecuting = (sql, pars) =>
                            {
                            // MiniProfiler.Current.CustomTiming("SQL：", GetParas(pars) + "【SQL语句】：" + sql);
                            if (AppConfigurtaionService.Configuration["ConnectionStrings:DbMSSQLLogIsLogSql"] == "True")// 是否记录Sql语句到日志文件中的开关
                            {
                                    log.Info(GetParas(pars) + "【SQL语句】：" + sql);
                            }
                            }
                        }
                    }
                };
                return new SqlSugarClient(listConfig);
            });
        }

        private static string GetParas(SugarParameter[] pars)
        {
            string key = "【SQL参数】：";
            foreach (var param in pars)
            {
                key += $"{param.ParameterName}:{param.Value}\r\n";
            }
            return key;
        }

        /// <summary>
        /// 初始化日志数据库实例(用来添加日志到数据库)
        /// </summary>
        public static SqlSugarClient LogDB => GetLogInstance();

        /// <summary>
        /// 得到Log数据库实例(用来添加日志到数据库)
        /// </summary>
        /// <returns></returns>
        private static SqlSugarClient GetLogInstance()
        {
            var db = new SqlSugarClient(
                new ConnectionConfig
                {
                    ConnectionString = AppConfigurtaionService.Configuration["ConnectionStrings:DefaultLog"],// 日志库连接字符串
                    DbType = DbType.SqlServer,
                    IsShardSameThread = true,
                    IsAutoCloseConnection = true,// 开启自动释放模式和EF原理一样我就不多解释了
                    InitKeyType = InitKeyType.Attribute,// 从特性读取主键和自增列信息
                });
            return db;
        }

        #region 弃用

        /// <summary>
        /// 初始化数据库实例
        /// </summary>
        // public SqlSugarClient DB => GetInstance();

        /// <summary>
        /// 得到数据库实例
        /// </summary>
        /// <returns></returns>
        //SqlSugarClient GetInstance()
        //{
        //    var db = new SqlSugarClient(
        //        new ConnectionConfig
        //        {
        //            ConnectionString = AppConfigurtaionService.Configuration["ConnectionStrings:Default"],
        //            DbType = DbType.SqlServer,
        //            IsShardSameThread = true,
        //            IsAutoCloseConnection = true,// 开启自动释放模式和EF原理一样我就不多解释了
        //            InitKeyType = InitKeyType.Attribute// 从特性读取主键和自增列信息
        //        });

        //    //添加Sql打印事件，开发中可以删掉这个代码
        //    db.Aop.OnLogExecuting = (sql, pars) =>
        //    {
        //        Console.WriteLine(sql + "\r\n" + db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
        //        Console.WriteLine();
        //    };

        //    return db;
        //}

        #endregion 弃用
    }
}