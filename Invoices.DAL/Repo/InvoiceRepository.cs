using DAL.DataContext;
using Invoices.DAL.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DAL.Repo
{
    public class InvoiceRepository
    {
        private readonly DatabaseContext _context;

        public InvoiceRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Invoice> GetInvoices()
        {
            return _context.Invoices;
        }

        public Invoice GetInvoice(int Id)
        {
            return _context.Invoices.Find(Id);
        }
    }
}
