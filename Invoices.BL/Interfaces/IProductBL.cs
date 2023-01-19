using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Invoices.DAL.Models;

namespace Invoices.BL.Interfaces
{
    internal interface IProductBL
    {
        IEnumerable<Product> GetAll();
        Product GetbyId(int id);
        Product Add(Product entity);
        Product Update(int id);
        void Delete(int id);
    }
}
