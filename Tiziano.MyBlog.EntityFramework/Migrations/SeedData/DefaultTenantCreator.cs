using System.Linq;
using Tiziano.MyBlog.EntityFramework;
using Tiziano.MyBlog.MultiTenancy;

namespace Tiziano.MyBlog.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MyBlogDbContext _context;

        public DefaultTenantCreator(MyBlogDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
