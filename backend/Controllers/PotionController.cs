using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotionController : ControllerBase
    {
        private readonly FantasyDBContext _context;

        public PotionController(FantasyDBContext context)
        {
            _context = context;
        }

        // GET: api/Potion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Potion>>> GetPotion()
        {
          if (_context.Potion == null)
          {
              return NotFound();
          }
            return await _context.Potion.ToListAsync();
        }

        // GET: api/Potion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Potion>> GetPotion(int id)
        {
          if (_context.Potion == null)
          {
              return NotFound();
          }
            var potion = await _context.Potion.FindAsync(id);

            if (potion == null)
            {
                return NotFound();
            }

            return potion;
        }

        // PUT: api/Potion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPotion(int id, Potion potion)
        {
            if (id != potion.potionId)
            {
                return BadRequest();
            }

            _context.Entry(potion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PotionExists(id))
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

        // POST: api/Potion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Potion>> PostPotion(Potion potion)
        {
          if (_context.Potion == null)
          {
              return Problem("Entity set 'FantasyDBContext.Potion'  is null.");
          }
            _context.Potion.Add(potion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPotion", new { id = potion.potionId }, potion);
        }

        // DELETE: api/Potion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePotion(int id)
        {
            if (_context.Potion == null)
            {
                return NotFound();
            }
            var potion = await _context.Potion.FindAsync(id);
            if (potion == null)
            {
                return NotFound();
            }

            _context.Potion.Remove(potion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PotionExists(int id)
        {
            return (_context.Potion?.Any(e => e.potionId == id)).GetValueOrDefault();
        }
    }
}
