using System.Linq.Expressions;

namespace Invoices.DAL.Interfaces
{
    public interface IRepository<T>:IDisposable where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetbyId(int? id);
        Task<T> Add(T entity);
        Task<T> Delete(int id);
        Task Update(T entity);
        Task<T> Find(Expression<Func<T, bool>> expr);
        Task Save();
    }
}
