using System.Linq.Expressions;

namespace Invoices.DAL.Interfaces
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetbyId(int? id);
        Task<T> Add(T entity);
        Task<T> Delete(int id);
        Task<T> Update(T entity);
        Task<T> Find(Expression<Func<T, bool>> expr);
        Task Save();
    }
}
