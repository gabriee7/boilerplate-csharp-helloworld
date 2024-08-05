using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyTest.Authorization.Roles;
using MyTest.Authorization.Users;
using MyTest.MultiTenancy;

namespace MyTest.EntityFrameworkCore
{
    public class MyTestDbContext : AbpZeroDbContext<Tenant, Role, User, MyTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyTestDbContext(DbContextOptions<MyTestDbContext> options)
            : base(options)
        {
        }
    }
}
