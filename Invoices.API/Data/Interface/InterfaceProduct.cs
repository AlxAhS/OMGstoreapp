using Invoices.DAL.Models;

namespace Invoices.API.Data.Interface
{
    public interface InterfaceProduct
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> GetProductByValueAsync(string productValue);
        
    }
}
