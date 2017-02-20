using Abp.MultiTenancy;
using Tiziano.MyBlog.Users;

namespace Tiziano.MyBlog.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}