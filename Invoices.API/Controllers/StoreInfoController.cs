using DAL.DataContext;
using Invoices.BL;
using Invoices.DAL.Interfaces;
using Invoices.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Invoices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreInfoController : ControllerBase
    {
		private readonly IRepositoryAsync<StoreInfo> _repo;

		public StoreInfoController(IRepositoryAsync<StoreInfo> repository) 
        {
			 _repo = repository;
		}

        // GET: api/StoreInfo
        [HttpGet]
		public async Task<IEnumerable<StoreInfo>> GetAllStoreInfo()
		{
			return await _repo.GetAll();
		}

		// GET: api/StoreInfo/5
		[HttpGet("{id}")]
		public async Task<StoreInfo> GetStoreInfo(int id)
		{
			return await _repo.GetbyId(id);
		}

        // POST: api/StoreInfo
        [HttpPost]
		public async Task<StoreInfo> InsertStoreInfo(StoreInfo entity)
		{
			return await _repo.Add(entity);
		}

		// PUT: api/StoreInfo/5
		[HttpPut("{id}")]
		public async Task<StoreInfo> Update(StoreInfo entity)
		{
			return await _repo.Update(entity);
		}

		// DELETE: api/StoreInfo/5
		[HttpDelete("{id}")]
		public async Task<StoreInfo> Delete(int id)
		{
			return await _repo.Delete(id);
		}

	}
}
