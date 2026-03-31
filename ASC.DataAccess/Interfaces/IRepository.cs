using ASC.Model;
using System.Linq.Expressions;
using ASC.Model.BaseTypes;

namespace ASC.DataAccess
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> FindAsync(string partitionKey, string rowKey);
        Task<IEnumerable<T>> FindAllByPartitionKeyAsync(string partitionKey);
        Task<IEnumerable<T>> FindAllAsync();
    }
}