﻿// <auto-generated />
using System;
using FH.Host.API.Infrastructure.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FH.Host.API.Infrastructure.Migrations
{
    [DbContext(typeof(FangHuaHostDbContext))]
    partial class FangHuaHostDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FH.Host.API.Model.DefaultEntity.FH_Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminName")
                        .IsRequired();

                    b.Property<string>("AdminPwd")
                        .IsRequired();

                    b.Property<int>("CreateAdminID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("CreateUserID");

                    b.Property<string>("DeleteTimeAndRemark");

                    b.Property<int>("IsDeleted");

                    b.Property<DateTime>("LastUpdateTime");

                    b.HasKey("Id");

                    b.ToTable("FH_Admin");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdminName = "Admin",
                            AdminPwd = "Admin123456",
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 10, 11, 9, 7, 39, 436, DateTimeKind.Local).AddTicks(3760),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 10, 11, 9, 7, 39, 437, DateTimeKind.Local).AddTicks(6409)
                        },
                        new
                        {
                            Id = 2,
                            AdminName = "Mr.Fang",
                            AdminPwd = "Fh2269...",
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 10, 11, 9, 7, 39, 437, DateTimeKind.Local).AddTicks(7623),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 10, 11, 9, 7, 39, 437, DateTimeKind.Local).AddTicks(7627)
                        });
                });

            modelBuilder.Entity("FH.Host.API.Model.DefaultEntity.FH_Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreateAdminID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("CreateUserID");

                    b.Property<string>("DeleteTimeAndRemark");

                    b.Property<int>("IsDeleted");

                    b.Property<DateTime>("LastUpdateTime");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("UserPwd")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("FH_Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(320),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(323),
                            UserName = "Admin",
                            UserPwd = "Admin123456"
                        },
                        new
                        {
                            Id = 2,
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(1194),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(1196),
                            UserName = "Mr.Fang",
                            UserPwd = "Fh2269..."
                        });
                });

            modelBuilder.Entity("FH.Host.API.Model.ModelEntity.FH_GuidePagesMenuInfo", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreateAdminID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("CreateUserID");

                    b.Property<string>("DeleteTimeAndRemark");

                    b.Property<int>("IsDeleted");

                    b.Property<DateTime>("LastUpdateTime");

                    b.Property<string>("MenuName")
                        .IsRequired();

                    b.Property<int>("MenuOrder");

                    b.Property<string>("MenuUrl")
                        .IsRequired();

                    b.Property<int>("ParentId");

                    b.HasKey("MenuID");

                    b.ToTable("GuidePagesMenuInfo");

                    b.HasData(
                        new
                        {
                            MenuID = 1,
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(2000),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(2003),
                            MenuName = "首页",
                            MenuOrder = 1,
                            MenuUrl = "https://home.fanghua.host",
                            ParentId = 0
                        },
                        new
                        {
                            MenuID = 2,
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3130),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3132),
                            MenuName = "QQ",
                            MenuOrder = 2,
                            MenuUrl = "https://wpa.qq.com/msgrd?v=3&uin=2875616188&site=qq&menu=yes",
                            ParentId = 0
                        },
                        new
                        {
                            MenuID = 3,
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3146),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3146),
                            MenuName = "微信",
                            MenuOrder = 3,
                            MenuUrl = "https://fanghua.host/assets/images/weixin.jpg",
                            ParentId = 0
                        },
                        new
                        {
                            MenuID = 4,
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3148),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3149),
                            MenuName = "Mr.Fang♥Mrs.Zhou",
                            MenuOrder = 4,
                            MenuUrl = "https://fh.fanghua.host",
                            ParentId = 0
                        },
                        new
                        {
                            MenuID = 5,
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3150),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3152),
                            MenuName = "表白小工具",
                            MenuOrder = 5,
                            MenuUrl = "https://devlove.fanghua.host",
                            ParentId = 0
                        },
                        new
                        {
                            MenuID = 6,
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3153),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3154),
                            MenuName = "实用小工具",
                            MenuOrder = 6,
                            MenuUrl = "https://tool.fanghua.host",
                            ParentId = 0
                        },
                        new
                        {
                            MenuID = 7,
                            CreateAdminID = 0,
                            CreateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3155),
                            CreateUserID = 0,
                            IsDeleted = 0,
                            LastUpdateTime = new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3156),
                            MenuName = "休闲小游戏",
                            MenuOrder = 7,
                            MenuUrl = "https://game.fanghua.host",
                            ParentId = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
