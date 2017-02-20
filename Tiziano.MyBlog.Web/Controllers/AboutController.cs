using System.Web.Mvc;

namespace Tiziano.MyBlog.Web.Controllers
{
    public class AboutController : MyBlogControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}