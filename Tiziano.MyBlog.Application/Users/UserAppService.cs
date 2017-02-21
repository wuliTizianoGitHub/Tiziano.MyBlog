using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Tiziano.MyBlog.Authorization;
using Tiziano.MyBlog.Users.Dto;
using Microsoft.AspNet.Identity;
using Tiziano.MyBlog.Authorization.Roles;
using Tiziano.MyBlog.Roles.Dto;
using Abp.Authorization.Users;

namespace Tiziano.MyBlog.Users
{
    /* THIS IS JUST A SAMPLE. */
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class UserAppService : MyBlogAppServiceBase, IUserAppService
    {

        private readonly IRepository<User, long> _userRepository;
        private readonly IRepository<Role, int> _roleRepository;
        private readonly IPermissionManager _permissionManager;
        private readonly IRepository<UserRole, long> _userRoleRepository;

        public UserAppService(IRepository<User, long> userRepository, IPermissionManager permissionManager, IRepository<UserRole, long> userRoleRepository, IRepository<Role, int> roleRepository)
        {
            _userRepository = userRepository;
            _permissionManager = permissionManager;
            _userRoleRepository = userRoleRepository;
            _roleRepository = roleRepository;
        }

        public async Task ProhibitPermission(ProhibitPermissionInput input)
        {
            var user = await UserManager.GetUserByIdAsync(input.UserId);
            var permission = _permissionManager.GetPermission(input.PermissionName);

            await UserManager.ProhibitPermissionAsync(user, permission);
        }

        //Example for primitive method parameters.
        public async Task RemoveFromRole(long userId, string roleName)
        {
            CheckErrors(await UserManager.RemoveFromRoleAsync(userId, roleName));
        }

        public async Task<ListResultDto<UserListDto>> GetUsers()
        {
            var users = await _userRepository.GetAllListAsync();

            return new ListResultDto<UserListDto>(
                users.MapTo<List<UserListDto>>()
                );
        }

        public async Task CreateUser(CreateUserInput input)
        {
            var user = input.MapTo<User>();

            user.TenantId = AbpSession.TenantId;
            user.Password = new PasswordHasher().HashPassword(input.Password);
            user.IsEmailConfirmed = true;

            CheckErrors(await UserManager.CreateAsync(user));
        }

        public async Task<GetUserOutput> GetUserAsync(long Id)
        {
           var user =  await UserManager.GetUserByIdAsync(Id);
           return  user.MapTo<GetUserOutput>();
        }

        public async Task<GetRoleOutput> GetRoleAsync(long UserId)
        {
            var userRole = await _userRoleRepository.FirstOrDefaultAsync(s=>s.UserId == UserId);
            var role = await _roleRepository.GetAsync(userRole.RoleId);
            return role.MapTo<GetRoleOutput>();
        }

    }
}