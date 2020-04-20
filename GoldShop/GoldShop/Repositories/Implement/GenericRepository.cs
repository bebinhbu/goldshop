using GoldShop.Models.Infrastructure;
using GoldShop.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GoldShop.Repositories.Implement
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected GoldShopDbContext Context;

        public GenericRepository(GoldShopDbContext context)
        {
            Context = context;
        }

        public Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate)
            => Context.Set<T>().FirstOrDefaultAsync(predicate);

        public async Task Add(T entity, bool isCommit = true)
        {
            await Context.Set<T>().AddAsync(entity);
            await SaveChanges(isCommit);
        }

        public Task Update(T entity, bool isCommit = true)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChanges(isCommit);
        }

        public Task Remove(T entity, bool isCommit = true)
        {
            Context.Set<T>().Remove(entity);
            return SaveChanges(isCommit);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await Context.Set<T>().Where(predicate).ToListAsync();
        }

        private async Task SaveChanges(bool isCommit)
        {
            if(isCommit)
            {
                await Context.SaveChangesAsync();
            }
        }
    }
}
