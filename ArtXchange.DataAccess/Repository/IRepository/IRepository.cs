using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ArtXchange.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // Retrieving data from DB based on ID. "T" means generic
        T Get(int id);

        // Retrieving list of data from DB based on number of requirements
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );

        // Retrieving only 1 obj from DB
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        // Adding entity
        void Add(T entity);
        // Removing based on ID
        void Remove(int id);
        // Removing based in complete entity
        void Remove(T entity);
        // Removing a range of entities
        void RemoveRange(IEnumerable<T> entity);
    }
}
