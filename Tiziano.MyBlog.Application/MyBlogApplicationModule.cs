using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Tiziano.MyBlog
{
    [DependsOn(typeof(MyBlogCoreModule), typeof(AbpAutoMapperModule))]
    public class MyBlogApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
