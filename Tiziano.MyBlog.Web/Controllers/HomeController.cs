using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using System.Threading.Tasks;
using Tiziano.MyBlog.Users;
using Tiziano.MyBlog.Users.Dto;
using Tiziano.MyBlog.Web.Models.Account;
using Tiziano.MyBlog.MultiTenancy;
using Tiziano.MyBlog.Authorization.Roles;

namespace Tiziano.MyBlog.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyBlogControllerBase
    {
        private readonly TenantManager _tenantManager; //多租户管理器
        private readonly RoleManager _roleManager;     //角色管理器
        private readonly UserManager _userManager;     //角色管理器
        private readonly IUserAppService _iUserAppService;
        public HomeController(IUserAppService iUserAppService, TenantManager tenantManager, RoleManager roleManager, UserManager userManager)
        {
            _iUserAppService = iUserAppService;
            _tenantManager = tenantManager;
            _roleManager = roleManager;
            _userManager = userManager;
    }

        public async Task<ActionResult>  Index()
        {
            GetUserOutput user = null;
            if (AbpSession.UserId.HasValue) {
                user = await _iUserAppService.GetUserAsync(AbpSession.UserId.Value);
            }
            var tentant = await _tenantManager.GetByIdAsync(AbpSession.TenantId.Value);
            var role = await _iUserAppService.GetRoleAsync(AbpSession.UserId.Value);


            return View(new HomeUserViewModel { ProfilePhoto= user.ProfilePhoto, Surname = user .Surname, TenancyName= tentant .TenancyName, RoleName = role.DisplayName });
        }
	}
}