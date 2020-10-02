using Microsoft.EntityFrameworkCore;

namespace FH.Host.API.Infrastructure.LogDB
{
    public class LogDbInitializer
    {
        public void InitializeAsync(FangHuaHostLogDbContext context)
        {
            // 根据Migrations修改/创建数据库
            context.Database.MigrateAsync();
        }
    }
}