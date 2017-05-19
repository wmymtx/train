using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace RIA.Train.EntityFramework.Repositories
{
    public abstract class TrainRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TrainDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TrainRepositoryBase(IDbContextProvider<TrainDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TrainRepositoryBase<TEntity> : TrainRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TrainRepositoryBase(IDbContextProvider<TrainDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
