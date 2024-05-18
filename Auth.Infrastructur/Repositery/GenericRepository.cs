using Auth.Core.Domain.RepositeryContract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Auth.Infrastructure.Repositery
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _Context;
        public GenericRepository(DbContext Context)
        {
            _Context = Context;
        }

        public async Task AddAsync(T entity)
        {
            await _Context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _Context.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll(string? includeProperties = null)
        {
            IQueryable<T> query = _Context.Set<T>();
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeprop in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeprop);
                }
            }
            return await query.ToListAsync(); // Assuming you're using Entity Framework Core
        }
        public async Task<T> GetAsync(Expression<Func<T, bool>> filter, string include = null)
        {
            // Assuming you want to include related entities based on the string "category"
            var query = GetQueryable(filter, include);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _Context.Set<T>().Update(entity);
            return entity;
        }


        public Task<int> CompleteAsync()
        {
            return _Context.SaveChangesAsync();
        }

        //private IQueryable<T> GetQueryable(
        //    Expression<Func<T, bool>>? filter = null,
        //    Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
        //{
        //    IQueryable<T> query = _Context.Set<T>();

        //    if (include is not null)
        //    {
        //        query = include(query);
        //    }

        //    if (filter is not null)
        //    {
        //        query = query.Where(filter);
        //    }

        //    return query;
        //}
        private IQueryable<T> GetQueryable(
     Expression<Func<T, bool>>? filter = null,
     string include = null)
        {
            IQueryable<T> query = _Context.Set<T>();

            if (!string.IsNullOrEmpty(include))
            {
                query = query.Include(include);
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query;
        }
        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> filter, string include = null)
        {

            T entity = GetSingle(filter, include);
            return entity;
        }

        public async Task<T> DeleteAsync(Expression<Func<T, bool>> filter)
        {
            T entity = GetSingle(filter);
            _Context.Set<T>().Remove(entity);
            return entity;
        }

        //private T GetSingle(Expression<Func<T, bool>>? filter = null,
        //    Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
        //{
        //    return GetQueryable(filter, include).FirstOrDefault();
        //}
        private T GetSingle(Expression<Func<T, bool>>? filter = null, string include = null)
        {
            return GetQueryable(filter, include).FirstOrDefault();
        }
    }
}
