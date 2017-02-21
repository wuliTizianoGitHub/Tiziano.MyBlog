using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Tiziano.MyBlog.Users.Dto;
using Tiziano.MyBlog.Roles.Dto;

namespace Tiziano.MyBlog.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);

        Task<ListResultDto<UserListDto>> GetUsers();

        Task CreateUser(CreateUserInput input);

        Task<GetUserOutput> GetUserAsync(long Id);

        Task<GetRoleOutput> GetRoleAsync(long UserId);
    }
}