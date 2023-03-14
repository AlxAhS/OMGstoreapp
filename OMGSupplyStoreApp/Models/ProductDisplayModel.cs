using Invoices.DAL.Models;

namespace OMGSupplyStoreApp.Models
{
    public class ProductDisplayModel
    {
        public IEnumerable<Product> Products { get; set;}

        //The follow line will work when we will have implemented search function 
        //public string STerm { get; set; } = "";
    }
}
