using DAL.DataContext;
using Invoices.API.Data.Interface;
using Invoices.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Invoices.API.Data
{
    public class ProductRepository : InterfaceProduct
    {
        private readonly DatabaseContext _context;

        public ProductRepository(DatabaseContext context)
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

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            var storeItem = await _context.Products.FirstOrDefaultAsync(u => u.ProductID == productId);
            return storeItem;
        }

        public async Task<Product> GetProductByValueAsync(string productValue)
        {
            var storeItem = await _context.Products.FirstOrDefaultAsync(u => u.ProductValue == productValue);
            return storeItem;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var storeItems = await _context.Products.ToListAsync();
            return storeItems;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;

        }
    }
}
