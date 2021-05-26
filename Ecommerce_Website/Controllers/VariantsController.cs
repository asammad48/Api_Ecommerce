using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerce_Website.Data;
using Ecommerce_Website.Models;

namespace Ecommerce_Website.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VariantsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public VariantsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Variants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Variants>>> Getvariants()
        {
            return await _context.variants.ToListAsync();
        }

        // GET: api/Variants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Variants>> GetVariants(int id)
        {
            var variants = await _context.variants.FindAsync(id);

            if (variants == null)
            {
                return NotFound();
            }

            return variants;
        }

        // PUT: api/Variants/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVariants(int id, Variants variants)
        {
            if (id != variants.VariantID)
            {
                return BadRequest();
            }

            _context.Entry(variants).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VariantsExists(id))
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

        // POST: api/Variants
        [HttpPost]
        public async Task<ActionResult<Variants>> PostVariants(Variants variants)
        {
            _context.variants.Add(variants);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVariants", new { id = variants.VariantID }, variants);
        }

        // DELETE: api/Variants/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Variants>> DeleteVariants(int id)
        {
            var variants = await _context.variants.FindAsync(id);
            if (variants == null)
            {
                return NotFound();
            }

            _context.variants.Remove(variants);
            await _context.SaveChangesAsync();

            return variants;
        }

        private bool VariantsExists(int id)
        {
            return _context.variants.Any(e => e.VariantID == id);
        }
    }
}
