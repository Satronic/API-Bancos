using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Banco.Data;
using API_Banco.Models;

namespace API_Banco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetirosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RetirosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Retiros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Retiro>>> GetRetiro()
        {
            return await _context.Retiro.ToListAsync();
        }

        // GET: api/Retiros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Retiro>> GetRetiro(int id)
        {
            var retiro = await _context.Retiro.FindAsync(id);

            if (retiro == null)
            {
                return NotFound();
            }

            return retiro;
        }

        // PUT: api/Retiros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRetiro(int id, Retiro retiro)
        {
            if (id != retiro.Id)
            {
                return BadRequest();
            }

            _context.Entry(retiro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RetiroExists(id))
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

        // POST: api/Retiros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Retiro>> PostRetiro(Retiro retiro)
        {
            //_context.Cuenta. = _context.Cuenta.Saldo - retiro.Valor;

            _context.Retiro.Add(retiro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRetiro", new { id = retiro.Id }, retiro);
        }

        // DELETE: api/Retiros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRetiro(int id)
        {
            var retiro = await _context.Retiro.FindAsync(id);
            if (retiro == null)
            {
                return NotFound();
            }

            _context.Retiro.Remove(retiro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RetiroExists(int id)
        {
            return _context.Retiro.Any(e => e.Id == id);
        }
    }
}
