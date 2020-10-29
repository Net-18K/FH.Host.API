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
                     MenuName = "Mr.Fang♥Mrs.Zhou",
                     MenuUrl = "https://love.fanghua.host",
                     MenuOrder = 1
                 },
                new FH_GuidePagesMenuInfo()
                {
                    MenuID = 2,
                    MenuName = "首页",
                    MenuUrl = "https://home.fanghua.host",
                    MenuOrder = 2
                },
                new FH_GuidePagesMenuInfo()
                {
                    MenuID = 3,
                    MenuName = "QQ",
                    MenuUrl = "https://wpa.qq.com/msgrd?v=3&uin=2875616188&site=qq&menu=yes",
                    MenuOrder = 3
                },
                new FH_GuidePagesMenuInfo()
                {
                    MenuID = 4,
                    MenuName = "微信",
                    MenuUrl = "https://fanghua.host/assets/images/weixin.jpg",
                    MenuOrder = 4
                },
                new FH_GuidePagesMenuInfo()
                {
                    MenuID = 5,
                    MenuName = "实用小工具",
                    MenuUrl = "https://tool.fanghua.host",
                    MenuOrder = 5
                },
                new FH_GuidePagesMenuInfo()
                {
                    MenuID = 6,
                    MenuName = "休闲小游戏",
                    MenuUrl = "https://game.fanghua.host",
                    MenuOrder = 6
                });

            modelBuilder.Entity<FH_CopywritingInfo>().HasData(
                new FH_CopywritingInfo()
                {
                    Id = 1,
                    Content = "当你的能力还撑不起你的野心的时，你就需要静下心来 好好学习。"
                },
                new FH_CopywritingInfo()
                {
                    Id = 2,
                    Content = "脏的人多了，干净反倒成了一种错。"
                },
                new FH_CopywritingInfo()
                {
                    Id = 3,
                    Content = "你羡慕的生活都是你没熬过的苦。"
                },
                new FH_CopywritingInfo()
                {
                    Id = 4,
                    Content = "所谓天才，只不过是把别人喝咖啡的功夫都用在了工作上了。"
                },
                new FH_CopywritingInfo()
                {
                    Id = 5,
                    Content = "生活便是寻求新的知识。——门捷列夫"
                },
                new FH_CopywritingInfo()
                {
                    Id = 6,
                    Content = "如果你浪费了自己的年龄，那是挺可悲的。因为你的青春只能持续一点儿时间——很短的一点儿时间。"
                },
                new FH_CopywritingInfo()
                {
                    Id = 7,
                    Content = "世界上一成不变的东西，只有“任何事物都是在不断变化的”这条真理。"
                });
            var obsUrl = AppConfigurtaionService.Configuration["ProjectInfo:ObjstorageUrl"];
            for (int i = 1; i < 101; i++)
            {
                modelBuilder.Entity<FH_BackGroundImageInfo>().HasData(
                    new FH_BackGroundImageInfo()
                    {
                        BGId = i,
                        BGUrl = obsUrl + "/assets/images/backGround/bg" + i + ".jpg"
                    });
            }
        }

        public DbSet<FH_Admin> FH_Admin { get; set; }

        public DbSet<FH_Users> FH_Users { get; set; }

        public DbSet<FH_GuidePagesMenuInfo> FH_GuidePagesMenuInfo { get; set; }

        public DbSet<FH_CopywritingInfo> FH_CopywritingInfo { get; set; }

        public DbSet<FH_EmailHistoryInfo> FH_EmailHistoryInfo { get; set; }

        public DbSet<FH_BackGroundImageInfo> FH_BackGroundImageInfo { get; set; }
    }
}