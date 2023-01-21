using DAL.DataContext;
using Invoices.DAL.Interfaces;
using Invoices.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DAL.Repo
{
    public class ClientRepository : IClientRepository
    {
        private readonly DatabaseContext _context;

        public ClientRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients;
        }
        
        public Client GetbyId(int id)
        {
            return _context.Clients.Find(id);
        }
        public Client Add(Client entity)
        {
            throw new NotImplementedException();
        }
        public Client Update(int id)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /*
        
        **************************************************************************
                                        !!!!
        The next two methods included in the interface can be deleted or modified 
        Alx.AhS
        **************************************************************************

        public Client GetClient (int Id)
        {
            return _context.Clients.Find(Id);
        }

        public IEnumerable<Client> GetClients()
        {
            return _context.Clients;
        }

        */

    }
}
