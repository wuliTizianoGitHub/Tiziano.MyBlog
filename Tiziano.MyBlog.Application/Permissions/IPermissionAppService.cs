using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiziano.MyBlog.Permissions.Dto;

namespace Tiziano.MyBlog.Permissions
{
    public interface IPermissionAppService: IApplicationService
    {
        //获取所有的主页左侧菜单栏
        Task<GetAllMenuPermissionOutput> GetAllMenuPermissionByUserIdOrRoleIdAsync(long? UserId, int? RoleId);
    }
}
