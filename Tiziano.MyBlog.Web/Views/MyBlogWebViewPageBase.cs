using Abp.Web.Mvc.Views;

namespace Tiziano.MyBlog.Web.Views
{
    public abstract class MyBlogWebViewPageBase : MyBlogWebViewPageBase<dynamic>
    {

    }

    public abstract class MyBlogWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyBlogWebViewPageBase()
        {
            LocalizationSourceName = MyBlogConsts.LocalizationSourceName;
        }
    }
}