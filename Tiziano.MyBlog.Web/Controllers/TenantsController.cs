using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Tiziano.MyBlog.Authorization;
using Tiziano.MyBlog.MultiTenancy;

namespace Tiziano.MyBlog.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : MyBlogControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}