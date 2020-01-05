using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Roadway.Domain;
using Roadway.Domain.Contracts;

namespace Roadway.Data.Repositories
{
    public abstract class EfRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity, IAggregateRoot
    {
        protected DbContext Context { get; }

        protected EfRepository(DbContext context)
        {
            Context = context;
        }

        public IQueryable<TEntity> All()
        {
            return this.Context.Set<TEntity>();
        }

        public IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Disable(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}