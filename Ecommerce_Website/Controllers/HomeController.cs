using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ecommerce_Website.Models;
using Ecommerce_Website.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Website.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        
        private readonly ApplicationContext _context;

        public HomeController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Home
        [HttpGet]
        public async Task<ActionResult<Products_With_Categories>> Home()
        {
            Products_With_Categories p = new Products_With_Categories();
            p.products = await _context.products.ToListAsync();
            p.variants = await _context.variants.ToListAsync();
            p.product_variants = await _context.product_Variants.ToListAsync();
            p.categories = await _context.Categories.ToListAsync();
            p.subCategories = await _context.subCategories.ToListAsync();
            p.subSubCategories = await _context.subSubCategories.ToListAsync();
            p.category_Subs = await _context.Category_subCategory.ToListAsync();
            p.subCategory_Subs = await _context.SubCategory_SubSubcategory.ToListAsync();
            p.specifications = await _context.specifications.ToListAsync();
            return p;
        }

    }
}
