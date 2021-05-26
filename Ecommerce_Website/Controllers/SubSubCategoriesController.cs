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
    public class SubSubCategoriesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SubSubCategoriesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/SubSubCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubSubCategory>>> GetsubSubCategories()
        {
            return await _context.subSubCategories.ToListAsync();
        }

        // GET: api/SubSubCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubSubCategory>> GetSubSubCategory(int id)
        {
            var subSubCategory = await _context.subSubCategories.FindAsync(id);

            if (subSubCategory == null)
            {
                return NotFound();
            }

            return subSubCategory;
        }

        // PUT: api/SubSubCategories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubSubCategory(int id, SubSubCategory subSubCategory)
        {
            if (id != subSubCategory.SubSubCategoryID)
            {
                return BadRequest();
            }

            _context.Entry(subSubCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubSubCategoryExists(id))
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

        // POST: api/SubSubCategories
        [HttpPost]
        public async Task<ActionResult<SubSubCategory>> PostSubSubCategory(SubSubCategory subSubCategory)
        {
            _context.subSubCategories.Add(subSubCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubSubCategory", new { id = subSubCategory.SubSubCategoryID }, subSubCategory);
        }

        // DELETE: api/SubSubCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SubSubCategory>> DeleteSubSubCategory(int id)
        {
            var subSubCategory = await _context.subSubCategories.FindAsync(id);
            if (subSubCategory == null)
            {
                return NotFound();
            }

            _context.subSubCategories.Remove(subSubCategory);
            await _context.SaveChangesAsync();

            return subSubCategory;
        }

        private bool SubSubCategoryExists(int id)
        {
            return _context.subSubCategories.Any(e => e.SubSubCategoryID == id);
        }
    }
}
