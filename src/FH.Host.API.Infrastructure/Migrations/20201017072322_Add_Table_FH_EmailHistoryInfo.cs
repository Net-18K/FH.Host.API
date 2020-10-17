using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FH.Host.API.Infrastructure.Migrations
{
    public partial class Add_Table_FH_EmailHistoryInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FH_EmailHistoryInfo",
                columns: table => new
                {
                    EHID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreateUserID = table.Column<int>(nullable: false),
                    CreateAdminID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastUpdateTime = table.Column<DateTime>(nullable: false),
                    DeleteTimeAndRemark = table.Column<string>(nullable: true),
                    RecipientId = table.Column<string>(nullable: false),
                    EmailBody = table.Column<string>(nullable: false),
                    EmailCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_EmailHistoryInfo", x => x.EHID);
                });

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
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(2261), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3902), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3920), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3924), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3926), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3929), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "FH_GuidePagesMenuInfo",
                keyColumn: "MenuID",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3986), new DateTime(2020, 10, 17, 15, 23, 22, 146, DateTimeKind.Local).AddTicks(3986) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FH_EmailHistoryInfo");

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

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9902), new DateTime(2020, 10, 11, 9, 39, 41, 956, DateTimeKind.Local).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(492), new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(502), new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(504), new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(505), new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(510), new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "FH_CopywritingInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "LastUpdateTime" },
                values: new object[] { new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(514), new DateTime(2020, 10, 11, 9, 39, 41, 957, DateTimeKind.Local).AddTicks(514) });

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
    }
}