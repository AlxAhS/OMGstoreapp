using DAL.DataContext;
using Invoices.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

//                                              !!!!!!!!
// This controller collect data from <client> <invoice> <product> and <storeinfo> tables, therefore data is available for generate the invoice document or any other document. 


namespace Invoices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentGeneratorController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public DocumentGeneratorController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Invoices/5
        [HttpGet("Client{id}")]
        public async Task<ActionResult<Client>> GetClient(int id)
        {
            var clientInfo = await _context.Clients.FindAsync(id);

            return clientInfo;
        }

        [HttpGet("Invoice{id}")]
        public async Task<ActionResult<Invoice>> GetInvoice(int id)
        {
            var invoiceInfo = await _context.Invoices.FindAsync(id);

            return invoiceInfo;
        }

        [HttpGet("Product{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var productInfo = await _context.Products.FindAsync(id);

            return productInfo;
        }

        [HttpGet("StoreInfo{id}")]

        public async Task<ActionResult<StoreInfo>> GetStoreInfo(int id)
        {
            var storeInfo= await _context.StoreInfo.FindAsync(id);

            return storeInfo;
        }


    }
}