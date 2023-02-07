using DAL.DataContext;
using Invoices.BL;
using Invoices.DAL.Interfaces;
using Invoices.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using static iText.IO.Util.IntHashtable;


namespace Invoices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
		private readonly IRepositoryAsync<Invoice> _repo;

		public InvoiceController(IRepositoryAsync<Invoice> repository)
        {
			_repo = repository;
		}

        // GET: api/Invoices
        [HttpGet]
        public async Task<IEnumerable<Invoice>> GetInvoices()
        {
            return await _repo.GetAll();
        }

        // GET: api/Invoices/5
        [HttpGet("{id}")]
        public async Task<Invoice> GetInvoice(int id)
		{
			return await _repo.GetbyId(id);
		}

        // POST: api/Invoices
        [HttpPost]
        public async Task<Invoice> PostInvoice(Invoice entity)
		{
			return await _repo.Add(entity);
		}

		// PUT: api/Invoices/5
		[HttpPut("{id}")]
        public async Task<Invoice> UpdateInvoice(Invoice entity)
		{
			return await _repo.Update(entity);
		}

		// DELETE: api/Invoices/5
		[HttpDelete("{id}")]
		public async Task<Invoice> Delete(int id)
		{
			return await _repo.Delete(id);
		}

	}
}