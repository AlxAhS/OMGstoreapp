using Invoices.BL;
using Invoices.DAL.Repo;

namespace CaDummy
{
    internal class Program
    {
        private static ProductRepository _context;
        static void Main(string[] args)
        {


            ProductBL bl = new ProductBL(_context);
            var products = bl.GetAll();

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }

        }
    }
}