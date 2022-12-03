using DAL.DataContext;
using Invoices.API.Data;
using Invoices.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Invoices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly DatabaseContext _contextCli;

        public ClientController(DatabaseContext clientContext) 
        {
            _contextCli = clientContext;
        }

        // GET: api/Clients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            if (_contextCli.Clients == null)
            {
                return NotFound();
            }
            return await _contextCli.Clients.ToListAsync();
        }

        // GET: api/Clients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClient(int id)
        {
            if (_contextCli.Clients == null)
            {
                return NotFound();
            }
            var clientInfo = await _contextCli.Clients.FindAsync(id);

            if (clientInfo == null)
            {
                return NotFound();
            }

            return clientInfo;
        }

        // PUT: api/Clients/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(int id, Client clientInfo)
        {
            if (id != clientInfo.ClientID)
            {
                return BadRequest();
            }

            _contextCli.Entry(clientInfo).State = EntityState.Modified;

            try
            {
                await _contextCli.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
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

        //enum SelectDocument
        //{ CC, CE, TI, RC, Passport, NIT, Other, };

        // POST: api/Clients
        [HttpPost]
        public async Task<ActionResult<Client>> PostClient(Client clientInfo)
        {
            if (_contextCli.Clients == null)
            {
                return Problem("Entity set 'DatabaseContext.Clients'  is null.");
            }
            _contextCli.Clients.Add(clientInfo);
            await _contextCli.SaveChangesAsync();

            //clientInfo.DocumentType = SelectDocument();

            return CreatedAtAction("GetClients", new { id = clientInfo.ClientID, /*document = clientInfo.DocumentType*/ }, clientInfo);
        }


        // DELETE: api/Clients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            if (_contextCli.Clients == null)
            {
                return NotFound();
            }
            var client = await _contextCli.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            _contextCli.Clients.Remove(client);
            await _contextCli.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientExists(int id)
        {
            return (_contextCli.Clients?.Any(e => e.ClientID == id)).GetValueOrDefault();
        }

    }
}
