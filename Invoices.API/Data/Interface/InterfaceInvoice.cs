using DAL.Models;
using Invoices.DAL.Models;

namespace Invoices.API.Data.Interface
{
    public interface InterfaceInvoice
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();
        Task<IEnumerable<Invoice>> GetInvoicesAsync();
        Task<Invoice> GetInvoiceByNumberAsync(string invoiceNumber);

    }
}
