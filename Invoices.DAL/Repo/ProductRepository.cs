using DAL.DataContext;
using Invoices.DAL.Interfaces;
using Invoices.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Invoices.DAL.Repo
{
    public class ProductRepository: IProductRepository
    {
        private readonly DatabaseContext _context;

        public ProductRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetbyId(int id)
        {
            return _context.Products.Find(id);
        }

        public Product Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Update(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
