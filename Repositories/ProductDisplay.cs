using Microsoft.EntityFrameworkCore;
using OMGSupplyStoreApp.Data;
using OMGSupplyStoreApp.Models;
using Invoices.DAL.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace OMGSupplyStoreApp.Repositories
{
    //public class ProductDisplay : IProductDisplay
    //{
    //    private readonly ApplicationDbContext _dbContext;

    //    public ProductDisplay(ApplicationDbContext dbContext)
    //    {
    //        _dbContext = dbContext;
    //    }

    //    public async Task<IEnumerable<ProductDisplayModel>> GetProducts(int productId = 0)
    //    {
            
    //        IEnumerable<Product> product = await (from Product in _dbContext.Products
    //                                        select new Product
    //                                        {
    //                                            ID = Product.ID,
    //                                            Name = Product.Name,
    //                                            Price = Product.Price,
    //                                        }
    //                                        ).ToListAsync();
    //        if (productId > 0)
    //        {
    //            product = product.Where(a => a.ID == productId).ToList();
    //        }
    //        return product;
    //    }
    //}
}
