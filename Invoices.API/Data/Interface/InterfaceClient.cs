using Invoices.DAL.Models;

namespace Invoices.API.Data.Interface
{
    public interface InterfaceClient
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();
        Task<IEnumerable<Client>> GetClientsAsync();
        Task<Client> GetClientByIdAsync(int id);
        Task<Client> GetClientByDocumentIDAsync(string documentId);
        Task<Client> GetClientByNameAsync(string clientName);

    }
}
