using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiziano.MyBlog.Authorization.Permissions
{
    public interface IPermissionRepository
    {
        List<Permission>   GetPermissionsByUserIdAsync(long? UserId);
        List<Permission> GetPermissionsByRoleIdAsync(int? RoleId);
    }
}
