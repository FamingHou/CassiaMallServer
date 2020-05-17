using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CassiaMall.Authorization.Roles;
using CassiaMall.Authorization.Users;
using CassiaMall.MultiTenancy;

namespace CassiaMall.EntityFrameworkCore
{
    public class CassiaMallDbContext : AbpZeroDbContext<Tenant, Role, User, CassiaMallDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CassiaMallDbContext(DbContextOptions<CassiaMallDbContext> options)
            : base(options)
        {
        }
    }
}
