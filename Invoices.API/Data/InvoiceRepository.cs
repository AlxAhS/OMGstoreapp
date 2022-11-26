using DAL.DataContext;
using DAL.Models;
using Invoices.API.Data.Interface;
using Invoices.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Invoices.API.Data
{
    public class InvoiceRepository : InterfaceInvoice
    {

        private readonly DatabaseContext _context;

        public InvoiceRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<IEnumerable<Invoice>> GetInvoicesAsync()
        {
            var invoice = await _context.Invoices.ToListAsync();
            return invoice;
        }

        public async Task<Invoice> GetInvoiceByNumberAsync(string invoiceNumber)
        {
            var invoice = await _context.Invoices.FirstOrDefaultAsync(u => u.InvoiceNumber == invoiceNumber);
            return invoice;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;

        }

    }
}
