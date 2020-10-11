using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FH.Host.API.Infrastructure.Migrations
{
    public partial class Add_Table_FH_GuidePagesMenuInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuidePagesMenuInfo",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    MenuName = table.Column<string>(nullable: false),
                    MenuUrl = table.Column<string>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    MenuOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuidePagesMenuInfo", x => x.MenuID);
                });

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 7, 39, 436, DateTimeKind.Local).AddTicks(3760), new DateTime(2020, 10, 11, 9, 7, 39, 437, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 7, 39, 437, DateTimeKind.Local).AddTicks(7623), new DateTime(2020, 10, 11, 9, 7, 39, 437, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(320), new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(1194), new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.InsertData(
                table: "GuidePagesMenuInfo",
                columns: new[] { "MenuID", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime", "MenuName", "MenuOrder", "MenuUrl", "ParentId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(2000), 0, null, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(2003), "首页", 1, "https://home.fanghua.host", 0 },
                    { 2, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3130), 0, null, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3132), "QQ", 2, "https://wpa.qq.com/msgrd?v=3&uin=2875616188&site=qq&menu=yes", 0 },
                    { 3, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3146), 0, null, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3146), "微信", 3, "https://fanghua.host/assets/images/weixin.jpg", 0 },
                    { 4, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3148), 0, null, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3149), "Mr.Fang♥Mrs.Zhou", 4, "https://fh.fanghua.host", 0 },
                    { 5, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3150), 0, null, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3152), "表白小工具", 5, "https://devlove.fanghua.host", 0 },
                    { 6, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3153), 0, null, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3154), "实用小工具", 6, "https://tool.fanghua.host", 0 },
                    { 7, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3155), 0, null, 0, new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3156), "休闲小游戏", 7, "https://game.fanghua.host", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuidePagesMenuInfo");

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 9, 28, 17, 29, 27, 782, DateTimeKind.Local).AddTicks(769), new DateTime(2020, 9, 28, 17, 29, 27, 784, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 9, 28, 17, 29, 27, 785, DateTimeKind.Local).AddTicks(2057), new DateTime(2020, 9, 28, 17, 29, 27, 785, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 9, 28, 17, 29, 27, 786, DateTimeKind.Local).AddTicks(9390), new DateTime(2020, 9, 28, 17, 29, 27, 786, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 9, 28, 17, 29, 27, 787, DateTimeKind.Local).AddTicks(1476), new DateTime(2020, 9, 28, 17, 29, 27, 787, DateTimeKind.Local).AddTicks(1478) });
        }
    }
}