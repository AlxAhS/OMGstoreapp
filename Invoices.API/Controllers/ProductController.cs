using DAL.DataContext;
using Invoices.BL;
using Invoices.DAL.Interfaces;
using Invoices.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Invoices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IRepository<Product> _repository;

        public ProductController(IRepository<Product> repository)
        {
            _repository = repository;
        }

        //Old dbcontext code
        //private readonly DatabaseContext _contextPro;

        //public ProductController(DatabaseContext context)
        //{
        //    _contextPro = context;
        //}

        // GET: api/Products
        //[HttpGet]
        //public async Task<IEnumerable<Product>> GetProducts()
        //{
        //    try
        //    {
        //        return await _repository.GetbyId(1);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var productInfo = await _repository.GetbyId(id);

            return productInfo;
        }

        //// PUT: api/Products/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPaymentDetail(int id, Product productInfo)
        //{
        //    if (id != productInfo.ID)
        //    {
        //        return BadRequest();
        //    }

        //    _contextPro.Entry(productInfo).State = EntityState.Modified;

        //    try
        //    {
        //        await _contextPro.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProductExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //    return NoContent();
        //}


        //// POST: api/Products
        //[HttpPost]
        //public async Task<ActionResult<Product>> PostClient(Product productInfo)
        //{
        //    if (_contextPro.Products == null)
        //    {
        //        return Problem("Entity set 'DatabaseContext.Products'  is null.");
        //    }
        //    _contextPro.Products.Add(productInfo);
        //    await _contextPro.SaveChangesAsync();

        //    return CreatedAtAction("GetProducts", new { id = productInfo.ID}, productInfo);
        //}


        //// DELETE: api/Products/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteClient(int id)
        //{
        //    if (_contextPro.Products == null)
        //    {
        //        return NotFound();
        //    }
        //    var product = await _contextPro.Products.FindAsync(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    _contextPro.Products.Remove(product);
        //    await _contextPro.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ProductExists(int id)
        //{
        //    return (_contextPro.Products?.Any(e => e.ID == id)).GetValueOrDefault();
        //}

    }
}
