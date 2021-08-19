using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bioapi;

namespace bioapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtikelgruppesController : ControllerBase
    {
        private readonly bioobstContext _context;

        public ArtikelgruppesController(bioobstContext context)
        {
            _context = context;
        }

        // GET: api/Artikelgruppes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artikelgruppe>>> GetArtikelgruppe()
        {
            return await _context.Artikelgruppe.ToListAsync();
        }

        // GET: api/Artikelgruppes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Artikelgruppe>> GetArtikelgruppe(uint id)
        {
            var artikelgruppe = await _context.Artikelgruppe.FindAsync(id);

            if (artikelgruppe == null)
            {
                return NotFound();
            }

            return artikelgruppe;
        }

        // PUT: api/Artikelgruppes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtikelgruppe(uint id, Artikelgruppe artikelgruppe)
        {
            if (id != artikelgruppe.Idartikelgruppe)
            {
                return BadRequest();
            }

            _context.Entry(artikelgruppe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtikelgruppeExists(id))
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

        // POST: api/Artikelgruppes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Artikelgruppe>> PostArtikelgruppe(Artikelgruppe artikelgruppe)
        {
            _context.Artikelgruppe.Add(artikelgruppe);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArtikelgruppe", new { id = artikelgruppe.Idartikelgruppe }, artikelgruppe);
        }

        // DELETE: api/Artikelgruppes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Artikelgruppe>> DeleteArtikelgruppe(uint id)
        {
            var artikelgruppe = await _context.Artikelgruppe.FindAsync(id);
            if (artikelgruppe == null)
            {
                return NotFound();
            }

            _context.Artikelgruppe.Remove(artikelgruppe);
            await _context.SaveChangesAsync();

            return artikelgruppe;
        }

        private bool ArtikelgruppeExists(uint id)
        {
            return _context.Artikelgruppe.Any(e => e.Idartikelgruppe == id);
        }
    }
}
