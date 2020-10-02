using System;

namespace FH.Host.API.Infrastructure.LogDBDto.SqlLogDto
{
    /// <summary>
    /// 创建Sql日志实体类
    /// </summary>
    public class CreateSqlLogDto
    {
        /// <summary>
        /// 执行时间
        /// </summary>
        public DateTime Date { get; set; } = DateTime.Now;

        /// <summary>
        /// Sql语句
        /// </summary>
        public string Sql { get; set; }
    }
}