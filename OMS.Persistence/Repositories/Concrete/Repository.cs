using Microsoft.EntityFrameworkCore;
using OMS.Persistence.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Persistence.Repositories.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public async Task<TEntity> Get(int id) => await Context.Set<TEntity>().FindAsync(id);

        public async Task<IEnumerable<TEntity>> GetAll() => await Context.Set<TEntity>().ToListAsync();
        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate) => Context.Set<TEntity>().Where(predicate);
        public async Task<TEntity> Add(TEntity entity)
        {
            await Context.Set<TEntity>().AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }
        public async Task AddRange(IEnumerable<TEntity> entities) => await Context.Set<TEntity>().AddRangeAsync(entities);
        public async Task Remove(TEntity entity) => Context.Set<TEntity>().Remove(entity);
        public async Task RemoveRange(IEnumerable<TEntity> entities) => Context.Set<TEntity>().RemoveRange(entities);
    }
}
