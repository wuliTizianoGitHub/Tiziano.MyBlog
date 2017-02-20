using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Tiziano.MyBlog.EntityFramework;

namespace Tiziano.MyBlog
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(MyBlogCoreModule))]
    public class MyBlogDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MyBlogDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
