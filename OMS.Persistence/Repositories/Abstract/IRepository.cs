using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Persistence.Repositories.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> Add(TEntity entity);
        Task<bool> AddRange(IEnumerable<TEntity> entities);
        Task Remove(TEntity entity);
        Task RemoveRange(IEnumerable<TEntity> entities);
    }
}
