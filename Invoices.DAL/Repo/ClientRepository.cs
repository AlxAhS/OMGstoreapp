using DAL.DataContext;
using Invoices.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DAL.Repo
{
    public class ClientRepository
    {
        private readonly DatabaseContext _context;

        public ClientRepository(DatabaseContext context)
        {
            _context= context;
        }

        public IEnumerable<Client> GetClients()
        {
            return _context.Clients;
        }

        public Client GetClient (int Id)
        {
            return _context.Clients.Find(Id);
        }
    }
}
