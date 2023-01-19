using Invoices.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DAL.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Client> GetAll();

        Client GetbyId(int id);

        Client Add(Client entity);

        Client Update(int id);

        void Delete(int id);

    }
}
