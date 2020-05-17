using Abp.Authorization;
using CassiaMall.Authorization.Roles;
using CassiaMall.Authorization.Users;

namespace CassiaMall.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
