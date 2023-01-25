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
    public class ProductController : ControllerBase
    {

        private readonly IRepositoryAsync<Product> _repo;

        public ProductController(IRepositoryAsync<Product> repository)
        {
            _repo = repository;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _repo.GetAll();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<Product> GetProduct(int id)
        {
            return await _repo.GetbyId(id);
        }

        // POST: api/Products
        [HttpPost]
        public async Task<Product> Insert(Product entity)
        {
            return await _repo.Add(entity);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<Product> Update(Product entity)
        {
            return await _repo.Update(entity);
        }


        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<Product> Delete(int id)
        {
            return await _repo.Delete(id); 
        }

    }
}
