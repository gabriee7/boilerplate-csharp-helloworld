using Abp.Authorization;
using MyTest.Authorization.Roles;
using MyTest.Authorization.Users;

namespace MyTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
