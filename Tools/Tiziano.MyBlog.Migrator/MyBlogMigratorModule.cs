using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Tiziano.MyBlog.EntityFramework;

namespace Tiziano.MyBlog.Migrator
{
    [DependsOn(typeof(MyBlogDataModule))]
    public class MyBlogMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyBlogDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}