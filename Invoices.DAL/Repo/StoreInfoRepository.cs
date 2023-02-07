using DAL.DataContext;
using Invoices.DAL.Interfaces;
using Invoices.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.DAL.Repo
{
	public class StoreInfoRepository : IStoreInfoRepository
	{
		private readonly DatabaseContext _context;
		public StoreInfoRepository(DatabaseContext context)
		{
			_context = context;
		}
		public IEnumerable<StoreInfo> GetAll()
		{
			return _context.StoreInfo;
		}
		public StoreInfo GetbyId(int id)
		{
			return _context.StoreInfo.Find(id);
		}
		public StoreInfo Add(StoreInfo entity)
		{
			throw new NotImplementedException();
		}
		public StoreInfo Update(int id)
		{
			throw new NotImplementedException();
		}
		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

	}
	 
}
