using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace FH.Host.API.Infrastructure.Migrations.FangHuaHostLogDb
{
    public partial class Add_DB_FangHuaHostLog_And_Add_Table_FH_Log : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FH_Log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Thread = table.Column<int>(nullable: false),
                    Level = table.Column<string>(maxLength: 50, nullable: true),
                    Logger = table.Column<string>(nullable: true),
                    Message = table.Column<string>(maxLength: 5000, nullable: true),
                    Exception = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FH_Log", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FH_Log");
        }
    }
}