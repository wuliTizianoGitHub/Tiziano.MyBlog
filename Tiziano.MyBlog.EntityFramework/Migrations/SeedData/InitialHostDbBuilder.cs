using Tiziano.MyBlog.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Tiziano.MyBlog.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MyBlogDbContext _context;

        public InitialHostDbBuilder(MyBlogDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
