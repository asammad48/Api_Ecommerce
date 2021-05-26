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
    public class Category_subCategoryController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public Category_subCategoryController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Category_subCategory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category_subCategory>>> GetCategory_subCategory()
        {
            return await _context.Category_subCategory.ToListAsync();
        }

        // GET: api/Category_subCategory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category_subCategory>> GetCategory_subCategory(int id)
        {
            var category_subCategory = await _context.Category_subCategory.FindAsync(id);

            if (category_subCategory == null)
            {
                return NotFound();
            }

            return category_subCategory;
        }

        // PUT: api/Category_subCategory/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory_subCategory(int id, Category_subCategory category_subCategory)
        {
            if (id != category_subCategory.SubCategory_SubSubcategoryID)
            {
                return BadRequest();
            }

            _context.Entry(category_subCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Category_subCategoryExists(id))
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

        // POST: api/Category_subCategory
        [HttpPost]
        public async Task<ActionResult<Category_subCategory>> PostCategory_subCategory(Category_subCategory category_subCategory)
        {
            _context.Category_subCategory.Add(category_subCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory_subCategory", new { id = category_subCategory.SubCategory_SubSubcategoryID }, category_subCategory);
        }

        // DELETE: api/Category_subCategory/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Category_subCategory>> DeleteCategory_subCategory(int id)
        {
            var category_subCategory = await _context.Category_subCategory.FindAsync(id);
            if (category_subCategory == null)
            {
                return NotFound();
            }

            _context.Category_subCategory.Remove(category_subCategory);
            await _context.SaveChangesAsync();

            return category_subCategory;
        }

        private bool Category_subCategoryExists(int id)
        {
            return _context.Category_subCategory.Any(e => e.SubCategory_SubSubcategoryID == id);
        }
    }
}
