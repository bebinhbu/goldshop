using GoldShop.Models.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GoldShop.Repositories.Interface
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);

        Task Add(T entity,bool isCommit);
        Task Update(T entity, bool isCommit);
        Task Remove(T entity, bool isCommit);

        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);
    }
}
