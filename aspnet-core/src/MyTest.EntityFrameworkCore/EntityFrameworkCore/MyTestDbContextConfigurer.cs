using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyTest.EntityFrameworkCore
{
    public static class MyTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
