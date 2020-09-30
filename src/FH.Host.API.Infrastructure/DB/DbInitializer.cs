using Microsoft.EntityFrameworkCore;

namespace FH.Host.API.Infrastructure.DB
{
    public class DbInitializer
    {
        public void InitializeAsync(FangHuaHostDbContext context)
        {
            // 根据Migrations修改/创建数据库
            context.Database.MigrateAsync();
        }
    }
}