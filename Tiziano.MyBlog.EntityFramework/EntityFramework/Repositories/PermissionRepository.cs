using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiziano.MyBlog.Authorization.Permissions;

namespace Tiziano.MyBlog.EntityFramework.Repositories
{
    public class PermissionRepository : MyBlogRepositoryBase<Permission,long>, IPermissionRepository
    {
        public PermissionRepository(IDbContextProvider<MyBlogDbContext> dbContextProvider):base(dbContextProvider)
        {

        }

        public List<Permission> GetPermissionsByUserIdAsync(long? UserId)
        {
           return   Context.MyPermissions.Where(p=>p.UserId== UserId.Value).ToList();
        }
        public List<Permission> GetPermissionsByRoleIdAsync(int? RoleId)
        {
            return Context.MyPermissions.Where(p => p.RoleId == RoleId.Value).ToList();
        }
    }
}
