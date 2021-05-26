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
    public class SubCategory_SubSubcategoryController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SubCategory_SubSubcategoryController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/SubCategory_SubSubcategory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubCategory_SubSubcategory>>> GetSubCategory_SubSubcategory()
        {
            return await _context.SubCategory_SubSubcategory.ToListAsync();
        }

        // GET: api/SubCategory_SubSubcategory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubCategory_SubSubcategory>> GetSubCategory_SubSubcategory(int id)
        {
            var subCategory_SubSubcategory = await _context.SubCategory_SubSubcategory.FindAsync(id);

            if (subCategory_SubSubcategory == null)
            {
                return NotFound();
            }

            return subCategory_SubSubcategory;
        }

        // PUT: api/SubCategory_SubSubcategory/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubCategory_SubSubcategory(int id, SubCategory_SubSubcategory subCategory_SubSubcategory)
        {
            if (id != subCategory_SubSubcategory.SubCategory_SubSubcategoryID)
            {
                return BadRequest();
            }

            _context.Entry(subCategory_SubSubcategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubCategory_SubSubcategoryExists(id))
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

        // POST: api/SubCategory_SubSubcategory
        [HttpPost]
        public async Task<ActionResult<SubCategory_SubSubcategory>> PostSubCategory_SubSubcategory(SubCategory_SubSubcategory subCategory_SubSubcategory)
        {
            _context.SubCategory_SubSubcategory.Add(subCategory_SubSubcategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubCategory_SubSubcategory", new { id = subCategory_SubSubcategory.SubCategory_SubSubcategoryID }, subCategory_SubSubcategory);
        }

        // DELETE: api/SubCategory_SubSubcategory/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SubCategory_SubSubcategory>> DeleteSubCategory_SubSubcategory(int id)
        {
            var subCategory_SubSubcategory = await _context.SubCategory_SubSubcategory.FindAsync(id);
            if (subCategory_SubSubcategory == null)
            {
                return NotFound();
            }
            _context.SubCategory_SubSubcategory.Remove(subCategory_SubSubcategory);
            await _context.SaveChangesAsync();

            return subCategory_SubSubcategory;
        }

        private bool SubCategory_SubSubcategoryExists(int id)
        {
            return _context.SubCategory_SubSubcategory.Any(e => e.SubCategory_SubSubcategoryID == id);
        }
    }
}
