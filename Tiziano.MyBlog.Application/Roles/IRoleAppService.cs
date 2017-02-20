using System.Threading.Tasks;
using Abp.Application.Services;
using Tiziano.MyBlog.Roles.Dto;

namespace Tiziano.MyBlog.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
