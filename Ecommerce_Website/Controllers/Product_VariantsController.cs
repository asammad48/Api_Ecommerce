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
    public class Product_VariantsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public Product_VariantsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Product_Variants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product_Variants>>> Getproduct_Variants()
        {
            return await _context.product_Variants.ToListAsync();
        }

        // GET: api/Product_Variants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product_Variants>> GetProduct_Variants(int id)
        {
            var product_Variants = await _context.product_Variants.FindAsync(id);

            if (product_Variants == null)
            {
                return NotFound();
            }

            return product_Variants;
        }

        // PUT: api/Product_Variants/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct_Variants(int id, Product_Variants product_Variants)
        {
            if (id != product_Variants.product_variant_ID)
            {
                return BadRequest();
            }

            _context.Entry(product_Variants).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_VariantsExists(id))
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

        // POST: api/Product_Variants
        [HttpPost]
        public async Task<ActionResult<Product_Variants>> PostProduct_Variants(Product_Variants product_Variants)
        {
            _context.product_Variants.Add(product_Variants);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct_Variants", new { id = product_Variants.product_variant_ID }, product_Variants);
        }

        // DELETE: api/Product_Variants/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product_Variants>> DeleteProduct_Variants(int id)
        {
            var product_Variants = await _context.product_Variants.FindAsync(id);
            if (product_Variants == null)
            {
                return NotFound();
            }

            _context.product_Variants.Remove(product_Variants);
            await _context.SaveChangesAsync();

            return product_Variants;
        }

        private bool Product_VariantsExists(int id)
        {
            return _context.product_Variants.Any(e => e.product_variant_ID == id);
        }
    }
}
