using DAL.DataContext;
using Invoices.API.Data.Interface;
using Invoices.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Invoices.API.Data
{
    public class ClientRepository : InterfaceClient
    {
        private readonly DatabaseContext _context;

        public ClientRepository(DatabaseContext context)
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

        public async Task<Client> GetClientByIdAsync(int clientId)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(u => u.ClientID == clientId);
            return client;
        }

        public async Task<Client> GetClientByDocumentIDAsync(string documentId)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(u => u.DocumentID == documentId);
            return client;
        }

        public async Task<Client> GetClientByNameAsync(string clientName)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(u => u.ClientName == clientName);
            return client;
        }

        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            var clients = await _context.Clients.ToListAsync();
            return clients;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;

        }
    }
}
