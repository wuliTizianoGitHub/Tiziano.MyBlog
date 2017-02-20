using Abp.Authorization;
using Tiziano.MyBlog.Authorization.Roles;
using Tiziano.MyBlog.MultiTenancy;
using Tiziano.MyBlog.Users;

namespace Tiziano.MyBlog.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
