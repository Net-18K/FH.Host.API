using FH.Host.API.Infrastructure.AppConfigurtaion;
using FH.Host.API.Model.DefaultEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
        }

        public DbSet<FH_Admin> FH_Admin { get; set; }

        public DbSet<FH_Users> FH_Users { get; set; }
    }
}