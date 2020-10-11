using FH.Host.API.Infrastructure.AppConfigurtaion;
using FH.Host.API.Model.DefaultEntity;
using FH.Host.API.Model.ModelEntity;
using Microsoft.EntityFrameworkCore;

namespace FH.Host.API.Infrastructure.DB
{
    public class FangHuaHostDbContext : DbContext
    {
        public FangHuaHostDbContext(DbContextOptions<FangHuaHostDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                AppConfigurtaionService.Configuration["ConnectionStrings:Default"]);
        }

        /// <summary>
        /// 数据初始化
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FH_Admin>().HasData(
                new FH_Admin { Id = 1, AdminName = "Admin", AdminPwd = "Admin123456" },
                new FH_Admin { Id = 2, AdminName = "Mr.Fang", AdminPwd = "Fh2269..." });

            modelBuilder.Entity<FH_Users>().HasData(
                new FH_Users { Id = 1, UserName = "Admin", UserPwd = "Admin123456" },
                new FH_Users { Id = 2, UserName = "Mr.Fang", UserPwd = "Fh2269..." });

            modelBuilder.Entity<FH_GuidePagesMenuInfo>().HasData(
                new FH_GuidePagesMenuInfo()
                {
                    MenuID = 1,
                    MenuName = "首页",
                    MenuUrl = "https://home.fanghua.host",
                    MenuOrder = 1
                },
                new FH_GuidePagesMenuInfo()
                {
                    MenuID = 2,
                    MenuName = "QQ",
                    MenuUrl = "https://wpa.qq.com/msgrd?v=3&uin=2875616188&site=qq&menu=yes",
                    MenuOrder = 2
                },
                new FH_GuidePagesMenuInfo()
                {
                    MenuID = 3,
                    MenuName = "微信",
                    MenuUrl = "https://fanghua.host/assets/images/weixin.jpg",
                    MenuOrder = 3
                },
                 new FH_GuidePagesMenuInfo()
                 {
                     MenuID = 4,
                     MenuName = "Mr.Fang♥Mrs.Zhou",
                     MenuUrl = "https://fh.fanghua.host",
                     MenuOrder = 4
                 },
                new FH_GuidePagesMenuInfo()
                {
                    MenuID = 5,
                    MenuName = "表白小工具",
                    MenuUrl = "https://devlove.fanghua.host",
                    MenuOrder = 5
                },
                new FH_GuidePagesMenuInfo()
                {
                    MenuID = 6,
                    MenuName = "实用小工具",
                    MenuUrl = "https://tool.fanghua.host",
                    MenuOrder = 6
                },
                new FH_GuidePagesMenuInfo()
                {
                    MenuID = 7,
                    MenuName = "休闲小游戏",
                    MenuUrl = "https://game.fanghua.host",
                    MenuOrder = 7
                });
        }

        public DbSet<FH_Admin> FH_Admin { get; set; }

        public DbSet<FH_Users> FH_Users { get; set; }

        public DbSet<FH_GuidePagesMenuInfo> GuidePagesMenuInfo { get; set; }
    }
}