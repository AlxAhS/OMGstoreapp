using Invoices.BL.Interfaces;
using Invoices.DAL.Models;
using Invoices.DAL.Repo;

namespace Invoices.BL
{
    public class ProductBL : IProductBL
    {
        private readonly ProductRepository _context;

        public ProductBL(ProductRepository context)
        {
            _context= context;
        }
        public Product Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetbyId(int id)
        {
            return _context.GetbyId(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return (IEnumerable<Product>)_context.GetAll();
        }

        public Product Update(int id)
        {
            throw new NotImplementedException();
        }


    }
}
