using FH.Host.API.Infrastructure.AppConfigurtaion;
using FH.Host.API.Model.LogEntity;
using Microsoft.EntityFrameworkCore;

namespace FH.Host.API.Infrastructure.LogDB
{
    public class FangHuaHostLogDbContext : DbContext
    {
        public FangHuaHostLogDbContext(DbContextOptions<FangHuaHostLogDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                AppConfigurtaionService.Configuration["ConnectionStrings:DefaultLog"]);
        }

        /// <summary>
        /// 数据初始化
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<FH_Log> FH_Log { get; set; }

        public DbSet<FH_SqlLog> FH_SqlLog { get; set; }
    }
}