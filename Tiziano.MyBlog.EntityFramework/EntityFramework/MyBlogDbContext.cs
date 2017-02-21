using System.Data.Common;
using Abp.Zero.EntityFramework;
using Tiziano.MyBlog.Authorization.Roles;
using Tiziano.MyBlog.MultiTenancy;
using Tiziano.MyBlog.Users;
using System.Data.Entity;
using Tiziano.MyBlog.Authorization.Permissions;

namespace Tiziano.MyBlog.EntityFramework
{
    public class MyBlogDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
         public IDbSet<Permission> MyPermissions { get; set; }

        public MyBlogDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MyBlogDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MyBlogDbContext since ABP automatically handles it.
         */
        public MyBlogDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MyBlogDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
