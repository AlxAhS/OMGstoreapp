using DAL.DataContext;
using Invoices.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Invoices.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreInfoController : ControllerBase
    {
        private readonly DatabaseContext _contextStore;

        public StoreInfoController(DatabaseContext storecontext) 
        {
            _contextStore = storecontext;
        }

        // GET: api/StoreInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoreInfo>>> GetAllStoreInfo()
        {
            if (_contextStore.StoreInfo == null)
            {
                return NotFound();
            }
            return await _contextStore.StoreInfo.ToListAsync();
        }

        // GET: api/StoreInfo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoreInfo>> GetStoreInfo(int id)
        {
            if (_contextStore.StoreInfo== null)
            {
                return NotFound();
            }
            var storeInfo = await _contextStore.StoreInfo.FindAsync(id);

            if (storeInfo == null)
            {
                return NotFound();
            }

            return storeInfo;
        }

        // PUT: api/StoreInfo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoreInfo(int id, StoreInfo storeInfo)
        {
            if (id != storeInfo.ID)
            {
                return BadRequest();
            }

            _contextStore.Entry(storeInfo).State = EntityState.Modified;

            try
            {
                await _contextStore.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoreInfoExists(id))
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

        // POST: api/StoreInfo
        [HttpPost]
        public async Task<ActionResult<StoreInfo>> PostStoreInfo(StoreInfo storeInfo)
        {
            if (_contextStore.StoreInfo == null)
            {
                return Problem("Entity set 'DatabaseContext.StoreInfo'  is null.");
            }
            _contextStore.StoreInfo.Add(storeInfo);
            await _contextStore.SaveChangesAsync();

            return CreatedAtAction("GetStoreInfo", new { id = storeInfo.ID}, storeInfo);
        }


        // DELETE: api/StoreInfo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoreInfo(int id)
        {
            if (_contextStore.StoreInfo == null)
            {
                return NotFound();
            }
            var storeInfo = await _contextStore.StoreInfo.FindAsync(id);
            if (storeInfo == null)
            {
                return NotFound();
            }

            _contextStore.StoreInfo.Remove(storeInfo);
            await _contextStore.SaveChangesAsync();

            return NoContent();
        }

        private bool StoreInfoExists(int id)
        {
            return (_contextStore.StoreInfo?.Any(e => e.ID == id)).GetValueOrDefault();
        }

    }
}
