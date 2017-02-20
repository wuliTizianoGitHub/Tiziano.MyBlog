using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using Tiziano.MyBlog.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Tiziano.MyBlog.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<MyBlog.EntityFramework.MyBlogDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyBlog";
        }

        protected override void Seed(MyBlog.EntityFramework.MyBlogDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
