using Invoices.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DAL.Interfaces
{
    public interface IStoreInfoRepository
    {
		IEnumerable<StoreInfo> GetAll();
		StoreInfo GetbyId(int id);
		StoreInfo Add(StoreInfo entity);
		StoreInfo Update(int id);
		void Delete(int id);

	}
}
