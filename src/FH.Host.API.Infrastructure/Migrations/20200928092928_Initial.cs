using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FH.Host.API.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FH_Admin",
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
                    AdminName = table.Column<string>(nullable: false),
                    AdminPwd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FH_Users",
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
                    UserName = table.Column<string>(nullable: false),
                    UserPwd = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FH_Admin",
                columns: new[] { "Id", "AdminName", "AdminPwd", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime" },
                values: new object[,]
                {
                    { 1, "Admin", "Admin123456", 0, new DateTime(2020, 9, 28, 17, 29, 27, 782, DateTimeKind.Local).AddTicks(769), 0, null, 0, new DateTime(2020, 9, 28, 17, 29, 27, 784, DateTimeKind.Local).AddTicks(8574) },
                    { 2, "Mr.Fang", "Fh2269...", 0, new DateTime(2020, 9, 28, 17, 29, 27, 785, DateTimeKind.Local).AddTicks(2057), 0, null, 0, new DateTime(2020, 9, 28, 17, 29, 27, 785, DateTimeKind.Local).AddTicks(2061) }
                });

            migrationBuilder.InsertData(
                table: "FH_Users",
                columns: new[] { "Id", "CreateAdminID", "CreateTime", "CreateUserID", "DeleteTimeAndRemark", "IsDeleted", "LastUpdateTime", "UserName", "UserPwd" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2020, 9, 28, 17, 29, 27, 786, DateTimeKind.Local).AddTicks(9390), 0, null, 0, new DateTime(2020, 9, 28, 17, 29, 27, 786, DateTimeKind.Local).AddTicks(9414), "Admin", "Admin123456" },
                    { 2, 0, new DateTime(2020, 9, 28, 17, 29, 27, 787, DateTimeKind.Local).AddTicks(1476), 0, null, 0, new DateTime(2020, 9, 28, 17, 29, 27, 787, DateTimeKind.Local).AddTicks(1478), "Mr.Fang", "Fh2269..." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FH_Admin");

            migrationBuilder.DropTable(
                name: "FH_Users");
        }
    }
}
