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
    public class ArtikelsController : ControllerBase
    {
        private readonly bioobstContext _context;

        public ArtikelsController(bioobstContext context)
        {
            _context = context;
        }

        // GET: api/Artikels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artikel>>> GetArtikel()
        {
            return await _context.Artikel.ToListAsync();
        }

        // GET: api/Artikels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Artikel>> GetArtikel(int id)
        {
            var artikel = await _context.Artikel.FindAsync(id);

            if (artikel == null)
            {
                return NotFound();
            }

            return artikel;
        }

        // PUT: api/Artikels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtikel(int id, Artikel artikel)
        {
            if (id != artikel.Idartikel)
            {
                return BadRequest();
            }

            _context.Entry(artikel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtikelExists(id))
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

        // POST: api/Artikels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Artikel>> PostArtikel(Artikel artikel)
        {
            _context.Artikel.Add(artikel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArtikel", new { id = artikel.Idartikel }, artikel);
        }

        // DELETE: api/Artikels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Artikel>> DeleteArtikel(int id)
        {
            var artikel = await _context.Artikel.FindAsync(id);
            if (artikel == null)
            {
                return NotFound();
            }

            _context.Artikel.Remove(artikel);
            await _context.SaveChangesAsync();

            return artikel;
        }

        private bool ArtikelExists(int id)
        {
            return _context.Artikel.Any(e => e.Idartikel == id);
        }
    }
}
