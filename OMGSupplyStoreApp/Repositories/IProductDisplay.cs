using OMGSupplyStoreApp.Models;

namespace OMGSupplyStoreApp.Repositories
{
    public interface IProductDisplay
    {
        Task<IEnumerable<ProductDisplayModel>> GetProducts(int productId = 0);

    }
}
