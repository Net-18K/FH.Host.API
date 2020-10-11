using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FH.Host.API.Infrastructure.Migrations
{
    public partial class Add_Table_FH_CopywritingInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GuidePagesMenuInfo",
                table: "GuidePagesMenuInfo");

            migrationBuilder.RenameTable(
                name: "GuidePagesMenuInfo",
                newName: "FH_GuidePagesMenuInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FH_GuidePagesMenuInfo",
                table: "FH_GuidePagesMenuInfo",
                column: "MenuID");

            migrationBuilder.CreateTable(
                name: "FH_CopywritingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    Content = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_CopywritingInfo", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 953, DateTimeKind.Local).AddTicks(6516), new DateTime(2020, 10, 11, 9, 39, 41, 955, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 955, DateTimeKind.Local).AddTicks(8705), new DateTime(2020, 10, 11, 9, 39, 41, 955, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.InsertData(
                table: "FH_CopywritingInfo",
                columns: new[] { "Id", "Content", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime" },
                values: new object[,]
                {
                    { 7, "世界上一成不变的东西，只有“任何事物都是在不断变化的”这条真理。", 0, new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(514), 0, null, 0, new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(514) },
                    { 6, "如果你浪费了自己的年龄，那是挺可悲的。因为你的青春只能持续一点儿时间——很短的一点儿时间。", 0, new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(510), 0, null, 0, new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(511) },
                    { 4, "所谓天才，只不过是把别人喝咖啡的功夫都用在了工作上了。", 0, new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(504), 0, null, 0, new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(504) },
                    { 3, "你羡慕的生活都是你没熬过的苦。", 0, new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(502), 0, null, 0, new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(503) },
                    { 5, "生活便是寻求新的知识。——门捷列夫", 0, new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(505), 0, null, 0, new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(509) },
                    { 1, "当你的能力还撑不起你的野心的时，你就需要静下心来 好好学习。", 0, new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9902), 0, null, 0, new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9903) },
                    { 2, "脏的人多了，干净反倒成了一种错。", 0, new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(492), 0, null, 0, new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(494) }
                });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(7842), new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9095), new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9117), new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9120), new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9122), new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9124), new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9127), new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(5278), new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(6618), new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(6621) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FH_CopywritingInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FH_GuidePagesMenuInfo",
                table: "FH_GuidePagesMenuInfo");

            migrationBuilder.RenameTable(
                name: "FH_GuidePagesMenuInfo",
                newName: "GuidePagesMenuInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GuidePagesMenuInfo",
                table: "GuidePagesMenuInfo",
                column: "MenuID");

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

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(2000), new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3130), new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3146), new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3148), new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3150), new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3153), new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3155), new DateTime(2020, 10, 11, 9, 7, 39, 438, DateTimeKind.Local).AddTicks(3156) });
        }
    }
}