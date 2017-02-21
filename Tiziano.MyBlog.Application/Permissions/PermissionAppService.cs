using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiziano.MyBlog.Authorization.Permissions;
using Tiziano.MyBlog.Permissions.Dto;

namespace Tiziano.MyBlog.Permissions
{
    public class PermissionAppService : IPermissionAppService
    {
        private readonly IRepository<Permission, long> _permissionRepository;
        public PermissionAppService(IRepository<Permission, long> permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }
        public async Task<GetAllMenuPermissionOutput> GetAllMenuPermissionByUserIdOrRoleIdAsync(long? UserId,int? RoleId)
        {
            return null;
        }
    }
}
