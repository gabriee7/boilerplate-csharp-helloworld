using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyTest.Authorization.Roles;
using MyTest.Authorization.Users;
using MyTest.MultiTenancy;
using MyTest.Products;

namespace MyTest.EntityFrameworkCore
{
    public class MyTestDbContext : AbpZeroDbContext<Tenant, Role, User, MyTestDbContext>
    {
        public DbSet<Product> Products { get; set; }
        
        public MyTestDbContext(DbContextOptions<MyTestDbContext> options)
            : base(options)
        {
        }
    }
}
