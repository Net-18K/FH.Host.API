using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FH.Host.API.Infrastructure.Migrations
{
    public partial class Add_Table_FH_BackGroundImageInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 7);

            migrationBuilder.CreateTable(
                name: "FH_BackGroundImageInfo",
                columns: table => new
                {
                    BGId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    BGUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_BackGroundImageInfo", x => x.BGId);
                });

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 919, DateTimeKind.Local).AddTicks(886), new DateTime(2020, 10, 29, 8, 48, 40, 920, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 920, DateTimeKind.Local).AddTicks(5985), new DateTime(2020, 10, 29, 8, 48, 40, 920, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.InsertData(
                table: "FH_BackGroundImageInfo",
                columns: new[] { "BGId", "BGUrl", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime" },
                values: new object[,]
                {
                    { 74, "http://objstorage.fanghua.host/assets/images/backGround/bg74.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5457), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5458) },
                    { 73, "http://objstorage.fanghua.host/assets/images/backGround/bg73.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5446), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5446) },
                    { 72, "http://objstorage.fanghua.host/assets/images/backGround/bg72.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5434), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5435) },
                    { 71, "http://objstorage.fanghua.host/assets/images/backGround/bg71.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5423), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5423) },
                    { 70, "http://objstorage.fanghua.host/assets/images/backGround/bg70.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5411), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5411) },
                    { 69, "http://objstorage.fanghua.host/assets/images/backGround/bg69.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5385), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5386) },
                    { 68, "http://objstorage.fanghua.host/assets/images/backGround/bg68.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5347), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5348) },
                    { 67, "http://objstorage.fanghua.host/assets/images/backGround/bg67.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5336), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5336) },
                    { 66, "http://objstorage.fanghua.host/assets/images/backGround/bg66.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5324), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5325) },
                    { 65, "http://objstorage.fanghua.host/assets/images/backGround/bg65.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5312), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5312) },
                    { 64, "http://objstorage.fanghua.host/assets/images/backGround/bg64.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5300), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5301) },
                    { 63, "http://objstorage.fanghua.host/assets/images/backGround/bg63.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5289), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5289) },
                    { 62, "http://objstorage.fanghua.host/assets/images/backGround/bg62.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5277), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5278) },
                    { 61, "http://objstorage.fanghua.host/assets/images/backGround/bg61.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5266), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5267) },
                    { 60, "http://objstorage.fanghua.host/assets/images/backGround/bg60.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5255), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5255) },
                    { 59, "http://objstorage.fanghua.host/assets/images/backGround/bg59.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5243), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5244) },
                    { 58, "http://objstorage.fanghua.host/assets/images/backGround/bg58.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5232), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5232) },
                    { 57, "http://objstorage.fanghua.host/assets/images/backGround/bg57.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5219), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5219) },
                    { 56, "http://objstorage.fanghua.host/assets/images/backGround/bg56.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5174), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5174) },
                    { 54, "http://objstorage.fanghua.host/assets/images/backGround/bg54.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5151), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5152) },
                    { 53, "http://objstorage.fanghua.host/assets/images/backGround/bg53.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5140), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5140) },
                    { 52, "http://objstorage.fanghua.host/assets/images/backGround/bg52.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5128), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5129) },
                    { 75, "http://objstorage.fanghua.host/assets/images/backGround/bg75.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5468), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5469) },
                    { 76, "http://objstorage.fanghua.host/assets/images/backGround/bg76.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5480), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5481) },
                    { 77, "http://objstorage.fanghua.host/assets/images/backGround/bg77.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5491), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5492) },
                    { 78, "http://objstorage.fanghua.host/assets/images/backGround/bg78.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5503), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5503) },
                    { 100, "http://objstorage.fanghua.host/assets/images/backGround/bg100.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5831), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5831) },
                    { 99, "http://objstorage.fanghua.host/assets/images/backGround/bg99.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5800), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5800) },
                    { 98, "http://objstorage.fanghua.host/assets/images/backGround/bg98.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5788), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5789) },
                    { 97, "http://objstorage.fanghua.host/assets/images/backGround/bg97.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5777), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5778) },
                    { 96, "http://objstorage.fanghua.host/assets/images/backGround/bg96.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5764), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5765) },
                    { 95, "http://objstorage.fanghua.host/assets/images/backGround/bg95.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5727), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5727) },
                    { 94, "http://objstorage.fanghua.host/assets/images/backGround/bg94.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5715), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5716) },
                    { 93, "http://objstorage.fanghua.host/assets/images/backGround/bg93.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5704), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5705) },
                    { 92, "http://objstorage.fanghua.host/assets/images/backGround/bg92.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5693), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5693) },
                    { 91, "http://objstorage.fanghua.host/assets/images/backGround/bg91.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5682), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5682) },
                    { 51, "http://objstorage.fanghua.host/assets/images/backGround/bg51.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5117), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5118) },
                    { 90, "http://objstorage.fanghua.host/assets/images/backGround/bg90.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5670), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5671) },
                    { 88, "http://objstorage.fanghua.host/assets/images/backGround/bg88.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5647), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5648) },
                    { 87, "http://objstorage.fanghua.host/assets/images/backGround/bg87.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5636), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5637) },
                    { 86, "http://objstorage.fanghua.host/assets/images/backGround/bg86.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5625), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5625) },
                    { 85, "http://objstorage.fanghua.host/assets/images/backGround/bg85.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5614), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5614) },
                    { 84, "http://objstorage.fanghua.host/assets/images/backGround/bg84.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5602), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5603) },
                    { 83, "http://objstorage.fanghua.host/assets/images/backGround/bg83.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5591), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5592) },
                    { 82, "http://objstorage.fanghua.host/assets/images/backGround/bg82.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5548), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5549) },
                    { 81, "http://objstorage.fanghua.host/assets/images/backGround/bg81.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5537), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5537) },
                    { 80, "http://objstorage.fanghua.host/assets/images/backGround/bg80.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5525), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5526) },
                    { 79, "http://objstorage.fanghua.host/assets/images/backGround/bg79.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5514), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5515) },
                    { 89, "http://objstorage.fanghua.host/assets/images/backGround/bg89.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5659), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5659) },
                    { 50, "http://objstorage.fanghua.host/assets/images/backGround/bg50.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5106), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5106) },
                    { 55, "http://objstorage.fanghua.host/assets/images/backGround/bg55.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5162), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5163) },
                    { 48, "http://objstorage.fanghua.host/assets/images/backGround/bg48.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5083), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5083) },
                    { 22, "http://objstorage.fanghua.host/assets/images/backGround/bg22.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4696), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4697) },
                    { 21, "http://objstorage.fanghua.host/assets/images/backGround/bg21.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4685), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4686) },
                    { 20, "http://objstorage.fanghua.host/assets/images/backGround/bg20.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4673), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4674) },
                    { 19, "http://objstorage.fanghua.host/assets/images/backGround/bg19.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4662), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4662) },
                    { 49, "http://objstorage.fanghua.host/assets/images/backGround/bg49.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5094), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5095) },
                    { 17, "http://objstorage.fanghua.host/assets/images/backGround/bg17.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4595), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4596) },
                    { 16, "http://objstorage.fanghua.host/assets/images/backGround/bg16.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4584), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4584) },
                    { 15, "http://objstorage.fanghua.host/assets/images/backGround/bg15.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4572), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4573) },
                    { 14, "http://objstorage.fanghua.host/assets/images/backGround/bg14.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4561), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4561) },
                    { 13, "http://objstorage.fanghua.host/assets/images/backGround/bg13.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4549), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4549) },
                    { 23, "http://objstorage.fanghua.host/assets/images/backGround/bg23.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4708), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4708) },
                    { 12, "http://objstorage.fanghua.host/assets/images/backGround/bg12.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4537), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4538) },
                    { 10, "http://objstorage.fanghua.host/assets/images/backGround/bg10.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4513), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4513) },
                    { 9, "http://objstorage.fanghua.host/assets/images/backGround/bg9.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4500), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4501) },
                    { 8, "http://objstorage.fanghua.host/assets/images/backGround/bg8.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4489), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4489) },
                    { 7, "http://objstorage.fanghua.host/assets/images/backGround/bg7.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4477), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4477) },
                    { 6, "http://objstorage.fanghua.host/assets/images/backGround/bg6.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4465), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4465) },
                    { 5, "http://objstorage.fanghua.host/assets/images/backGround/bg5.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4450), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4451) },
                    { 4, "http://objstorage.fanghua.host/assets/images/backGround/bg4.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4436), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4436) },
                    { 3, "http://objstorage.fanghua.host/assets/images/backGround/bg3.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4373), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4374) },
                    { 2, "http://objstorage.fanghua.host/assets/images/backGround/bg2.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4342), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4344) },
                    { 1, "http://objstorage.fanghua.host/assets/images/backGround/bg1.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(3651), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(3652) },
                    { 11, "http://objstorage.fanghua.host/assets/images/backGround/bg11.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4525), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4526) },
                    { 24, "http://objstorage.fanghua.host/assets/images/backGround/bg24.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4720), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4720) },
                    { 18, "http://objstorage.fanghua.host/assets/images/backGround/bg18.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4650), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4651) },
                    { 26, "http://objstorage.fanghua.host/assets/images/backGround/bg26.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4743), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4743) },
                    { 47, "http://objstorage.fanghua.host/assets/images/backGround/bg47.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5072), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5072) },
                    { 46, "http://objstorage.fanghua.host/assets/images/backGround/bg46.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5060), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5061) },
                    { 45, "http://objstorage.fanghua.host/assets/images/backGround/bg45.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5049), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5049) },
                    { 44, "http://objstorage.fanghua.host/assets/images/backGround/bg44.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5037), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(5038) },
                    { 25, "http://objstorage.fanghua.host/assets/images/backGround/bg25.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4731), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4732) },
                    { 43, "http://objstorage.fanghua.host/assets/images/backGround/bg43.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4998), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4999) },
                    { 41, "http://objstorage.fanghua.host/assets/images/backGround/bg41.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4976), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4976) },
                    { 40, "http://objstorage.fanghua.host/assets/images/backGround/bg40.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4965), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4965) },
                    { 39, "http://objstorage.fanghua.host/assets/images/backGround/bg39.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4953), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4954) },
                    { 38, "http://objstorage.fanghua.host/assets/images/backGround/bg38.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4942), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4943) },
                    { 42, "http://objstorage.fanghua.host/assets/images/backGround/bg42.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4987), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4988) },
                    { 36, "http://objstorage.fanghua.host/assets/images/backGround/bg36.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4919), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4920) },
                    { 37, "http://objstorage.fanghua.host/assets/images/backGround/bg37.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4931), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4931) },
                    { 28, "http://objstorage.fanghua.host/assets/images/backGround/bg28.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4766), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4766) },
                    { 29, "http://objstorage.fanghua.host/assets/images/backGround/bg29.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4777), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4777) },
                    { 30, "http://objstorage.fanghua.host/assets/images/backGround/bg30.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4789), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4789) },
                    { 31, "http://objstorage.fanghua.host/assets/images/backGround/bg31.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4861), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4861) },
                    { 27, "http://objstorage.fanghua.host/assets/images/backGround/bg27.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4754), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4754) },
                    { 33, "http://objstorage.fanghua.host/assets/images/backGround/bg33.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4884), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4884) },
                    { 34, "http://objstorage.fanghua.host/assets/images/backGround/bg34.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4897), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4897) },
                    { 35, "http://objstorage.fanghua.host/assets/images/backGround/bg35.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4908), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4908) },
                    { 32, "http://objstorage.fanghua.host/assets/images/backGround/bg32.jpg", 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4873), 0, null, 0, new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(4873) }
                });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2488), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2982), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2991), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2993), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2994), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2996), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(2999), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime", "MenuName", "MenuUrl" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(896), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(898), "Mr.Fang♥Mrs.Zhou", "https://love.fanghua.host" });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime", "MenuName", "MenuUrl" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1841), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1842), "首页", "https://home.fanghua.host" });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime", "MenuName", "MenuUrl" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1857), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1858), "QQ", "https://wpa.qq.com/msgrd?v=3&uin=2875616188&site=qq&menu=yes" });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime", "MenuName", "MenuUrl" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1859), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1860), "微信", "https://fanghua.host/assets/images/weixin.jpg" });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime", "MenuName", "MenuUrl" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1861), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1863), "实用小工具", "https://tool.fanghua.host" });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime", "MenuName", "MenuUrl" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1864), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(1865), "休闲小游戏", "https://game.fanghua.host" });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 920, DateTimeKind.Local).AddTicks(9141), new DateTime(2020, 10, 29, 8, 48, 40, 920, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(111), new DateTime(2020, 10, 29, 8, 48, 40, 921, DateTimeKind.Local).AddTicks(114) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FH_BackGroundImageInfo");

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 143, DateTimeKind.Local).AddTicks(2964), new DateTime(2020, 10, 17, 15, 23, 22, 145, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "FH_Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 145, DateTimeKind.Local).AddTicks(5879), new DateTime(2020, 10, 17, 15, 23, 22, 145, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(4818), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(5962), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(5978), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(5980), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(5981), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(5983), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(5985), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime", "MenuName", "MenuUrl" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(2261), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(2264), "首页", "https://home.fanghua.host" });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime", "MenuName", "MenuUrl" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3902), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3904), "QQ", "https://wpa.qq.com/msgrd?v=3&uin=2875616188&site=qq&menu=yes" });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime", "MenuName", "MenuUrl" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3920), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3922), "微信", "https://fanghua.host/assets/images/weixin.jpg" });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime", "MenuName", "MenuUrl" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3924), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3925), "Mr.Fang♥Mrs.Zhou", "https://fh.fanghua.host" });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime", "MenuName", "MenuUrl" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3926), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3927), "表白小工具", "https://devlove.fanghua.host" });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime", "MenuName", "MenuUrl" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3929), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3930), "实用小工具", "https://tool.fanghua.host" });

            migrationBuilder.InsertData(
                table: "FH_GuidePagesMenuInfo",
                columns: new[] { "MenuID", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime", "MenuName", "MenuOrder", "MenuUrl", "ParentId" },
                values: new object[] { 7, 0, new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3986), 0, null, 0, new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3986), "休闲小游戏", 7, "https://game.fanghua.host", 0 });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 145, DateTimeKind.Local).AddTicks(9858), new DateTime(2020, 10, 17, 15, 23, 22, 145, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "FH_Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(1230), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(1232) });
        }
    }
}