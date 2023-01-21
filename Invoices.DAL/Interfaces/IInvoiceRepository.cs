using Invoices.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DAL.Interfaces
{
    internal interface IInvoiceRepository
    {
        IEnumerable<Invoice> GetAll();
        Invoice GetbyId(int id);
        Invoice Add(Invoice entity);
        Invoice Update(int id);
        void Delete(int id);

    }
}
