using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Roadway.Data.Contexts;
using Roadway.Domain;
using Roadway.Domain.Contracts;

namespace Roadway.Data.Repositories
{
    public class EfRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity, IAggregateRoot
    {
        private DbContext Context { get; }

        protected EfRepository(DbContext context)
        {
            Context = context;
        }

        public IQueryable<TEntity> All()
        {
            return Context.Set<TEntity>();
        }

        public IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate)
        {
            return All().Where(predicate);
        }

        public async Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Filter(predicate).FirstAsync();
        }

        public async Task<TEntity> FindById(int id)
        {
            return await FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await All().FirstOrDefaultAsync(predicate);
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await Context.Set<TEntity>().AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            await Context.SaveChangesAsync();
        }

        public async Task<TEntity> DisableAsync(TEntity entity)
        {
            entity.Disabled = true;
            await UpdateAsync(entity);
            return entity;
        }

        public int Count()
        {
            return Context.Set<TEntity>().Count();
        }
    }
}