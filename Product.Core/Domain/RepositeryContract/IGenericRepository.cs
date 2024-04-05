using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Domain.RepositeryContract
{
     /// <summary>
        /// Generic repository to Add, Update, Delete, Read fuctionality.
        /// </summary>
        public interface IGenericRepository<T> where T : class
        {
            /// <summary>
            /// Add Entity.
            /// </summary>
            /// <param name="toAdd"></param>
            /// <returns>Returns asynchronous Task.</returns>
            Task AddAsync(T toAdd);

            /// <summary>
            /// Update Entity.
            /// </summary>
            /// <param name="toUpdate"></param>
            /// <returns>return Generic class object as asynchronous Task.</returns>
            public Task<T> UpdateAsync(T toUpdate);

            /// <summary>
            /// Delete Entity
            /// </summary>
            /// <param name="filter">filter</param>
            /// <returns>Returns asynchronous Task.</returns>
            public Task<T> DeleteAsync(Expression<Func<T, bool>> filter);

            /// <summary>
            /// Get Entity.
            /// </summary>
            /// <param name="filter">filter</param>
            /// <returns>return Generic class object</returns>
            Task<T> GetAsync(Expression<Func<T, bool>> filter);

            /// <summary>
            /// Get all items from expression and include data from the Dbcontext.
            /// </summary>
            /// <returns>return Generic class object</returns>
            Task<IEnumerable<T>> GetAll
                (string? includeProperties = null);

            /// <summary>
            /// SaveChanges Entity
            /// </summary>
            /// <returns>return Generic integer</returns>
            Task<int> CompleteAsync();

            /// <summary>
            /// Get Entity from expression and include data from the Dbcontext
            /// </summary>
            /// <param name="filter">filter</param>
            /// <returns>return Generic class object</returns>
            Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> filter);
        }
    
}
