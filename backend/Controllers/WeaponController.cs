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
    public class WeaponController : ControllerBase
    {
        private readonly FantasyDBContext _context;

        public WeaponController(FantasyDBContext context)
        {
            _context = context;
        }

        // GET: api/Weapon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weapon>>> GetWeapon()
        {
          if (_context.Weapon == null)
          {
              return NotFound();
          }
            return await _context.Weapon.ToListAsync();
        }

        // GET: api/Weapon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Weapon>> GetWeapon(int id)
        {
          if (_context.Weapon == null)
          {
              return NotFound();
          }
            var weapon = await _context.Weapon.FindAsync(id);

            if (weapon == null)
            {
                return NotFound();
            }

            return weapon;
        }

        // PUT: api/Weapon/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWeapon(int id, Weapon weapon)
        {
            if (id != weapon.weaponId)
            {
                return BadRequest();
            }

            _context.Entry(weapon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeaponExists(id))
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

        // POST: api/Weapon
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Weapon>> PostWeapon(Weapon weapon)
        {
          if (_context.Weapon == null)
          {
              return Problem("Entity set 'FantasyDBContext.Weapon'  is null.");
          }
            _context.Weapon.Add(weapon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWeapon", new { id = weapon.weaponId }, weapon);
        }

        // DELETE: api/Weapon/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWeapon(int id)
        {
            if (_context.Weapon == null)
            {
                return NotFound();
            }
            var weapon = await _context.Weapon.FindAsync(id);
            if (weapon == null)
            {
                return NotFound();
            }

            _context.Weapon.Remove(weapon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WeaponExists(int id)
        {
            return (_context.Weapon?.Any(e => e.weaponId == id)).GetValueOrDefault();
        }
    }
}
