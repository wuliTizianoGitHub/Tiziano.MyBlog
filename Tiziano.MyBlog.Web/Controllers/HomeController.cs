using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Tiziano.MyBlog.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyBlogControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}