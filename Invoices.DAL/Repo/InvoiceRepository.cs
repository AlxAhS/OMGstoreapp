using DAL.DataContext;
using Invoices.DAL.Interfaces;
using Invoices.DAL.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DAL.Repo
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly DatabaseContext _context;

        public InvoiceRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _context.Invoices;
        }

        public Invoice GetbyId(int id)
        {
            return _context.Invoices.Find(id);
        }
        public Invoice Add(Invoice entity)
        {
            throw new NotImplementedException();
        }
        public Invoice Update(int id)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
         
    }
}
