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
    public class ClientController : ControllerBase
    {
		private readonly IRepositoryAsync<Client> _repo;

		public ClientController(IRepositoryAsync<Client> repository   ) 
        {
			_repo = repository;
		}

        // GET: api/Clients
        [HttpGet]
		public async Task<IEnumerable<Client>> GetClients()
		{
			return await _repo.GetAll();
		}

		// GET: api/Clients/5
		[HttpGet("{id}")]
        public async Task<Client> GetClient(int id)
		{
			return await _repo.GetbyId(id);
		}

		// POST: api/Clients
		[HttpPost]
		public async Task<Client> PostClient(Client entity)
		{
			return await _repo.Add(entity);
		}

		// PUT: api/Clients/5
		[HttpPut("{id}")]
		public async Task<Client> Update(Client entity)
		{
			return await _repo.Update(entity);
		}

		// DELETE: api/Clients/5
		[HttpDelete("{id}")]
		public async Task<Client> Delete(int id)
		{
			return await _repo.Delete(id);
		}

	}
}
