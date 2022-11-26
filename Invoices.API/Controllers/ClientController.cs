using Invoices.API.Data;
using Invoices.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Invoices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ClientRepository _repo;

        public ClientController(ClientRepository repo) 
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clients = await _repo.GetClientsAsync();
            return Ok(clients);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Client client) 
        {
            
            _repo.Add(client);
            if (await _repo.SaveAll());
                return Ok(client);
            return BadRequest();
        }


    }
}
