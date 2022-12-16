using DAL.DataContext;
using DAL.Models;
using Invoices.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Invoices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly DatabaseContext _contextInv;

        public InvoiceController(DatabaseContext context)
        {
            _contextInv = context;
        }

        // GET: api/Invoices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Invoice>>> GetInvoices()
        {
            if (_contextInv.Invoices == null)
            {
                return NotFound();
            }
            return await _contextInv.Invoices.ToListAsync();
        }

        // GET: api/Invoices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Invoice>> GetInvoice(int id)
        {
            if (_contextInv.Invoices == null)
            {
                return NotFound();
            }
            var invoiceInfo = await _contextInv.Invoices.FindAsync(id);

            if (invoiceInfo == null)
            {
                return NotFound();
            }

            return invoiceInfo;
        }

        // PUT: api/Invoices/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoice(int id, Invoice invoiceInfo)
        {
            if (id != invoiceInfo.ID)
            {
                return BadRequest();
            }

            _contextInv.Entry(invoiceInfo).State = EntityState.Modified;

            try
            {
                await _contextInv.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }


        // POST: api/Invoices
        [HttpPost]
        public async Task<ActionResult<Invoice>> PostInvoice(Invoice invoiceInfo)
        {
            if (_contextInv.Invoices == null)
            {
                return Problem("Entity set 'DatabaseContext.Invoices'  is null.");
            }
             
            invoiceInfo.Date = DateTime.Now;

            _contextInv.Invoices.Add(invoiceInfo);
            await _contextInv.SaveChangesAsync();

            return CreatedAtAction(
                "GetInvoices", 
                new { id = invoiceInfo.ID, datetime = invoiceInfo.Date},
                invoiceInfo);
        }


        // DELETE: api/Invoices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            if (_contextInv.Invoices == null)
            {
                return NotFound();
            }
            var invoices = await _contextInv.Invoices.FindAsync(id);
            if (invoices == null)
            {
                return NotFound();
            }

            _contextInv.Invoices.Remove(invoices);
            await _contextInv.SaveChangesAsync();

            return NoContent();
        }

        private bool InvoiceExists(int id)
        {
            return (_contextInv.Invoices?.Any(e => e.ID== id)).GetValueOrDefault();
        }

    }
}