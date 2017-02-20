using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Tiziano.MyBlog.EntityFramework.Repositories
{
    public abstract class MyBlogRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MyBlogDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MyBlogRepositoryBase(IDbContextProvider<MyBlogDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MyBlogRepositoryBase<TEntity> : MyBlogRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MyBlogRepositoryBase(IDbContextProvider<MyBlogDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
