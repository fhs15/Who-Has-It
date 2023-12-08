using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhoHasItAPI.DBModels;
using WhoHasItAPI.Manager;

namespace WhoHasItAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemManager _manager;

        public ItemsController(ItemManager itemManager)
        {
            _manager = itemManager;
        }

        // GET: api/Items
        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetItems()
        {
            return Ok(_manager.GetItems());
        }

        // GET: api/Items/5
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(int id)
        {
            var item = _manager.GetItemByID(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        //// PUT: api/Items/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutItem(int id, Item item)
        //{
        //    if (id != item.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(item).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ItemExists(id))
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

        //// POST: api/Items
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Item>> PostItem(Item item)
        //{
        //    _context.Items.Add(item);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetItem", new { id = item.Id }, item);
        //}

        //// DELETE: api/Items/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteItem(int id)
        //{
        //    var item = await _context.Items.FindAsync(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Items.Remove(item);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ItemExists(int id)
        //{
        //    return _context.Items.Any(e => e.Id == id);
        //}
    }
}
