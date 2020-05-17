using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CassiaMall.EntityFrameworkCore
{
    public static class CassiaMallDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CassiaMallDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CassiaMallDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
