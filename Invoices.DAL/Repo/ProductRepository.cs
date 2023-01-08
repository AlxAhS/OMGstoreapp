using DAL.DataContext;
using Invoices.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DAL.Repo
{
    public class ProductRepository
    {
        private readonly DatabaseContext _context;
        public ProductRepository(DatabaseContext context)
        {
            _context = context;
        }


        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        public Product GetProduct(int Id)
        {
            return _context.Products.Find(Id);
        }
    }
}
