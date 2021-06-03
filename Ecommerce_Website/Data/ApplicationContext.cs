using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce_Website.Models;
namespace Ecommerce_Website.Data
{
    public class ApplicationContext: DbContext
    {
          public ApplicationContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<SubSubCategory> subSubCategories { get; set; }
        public DbSet<SubCategory> subCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Variants> variants { get; set; }
        public DbSet<Product_Variants>  product_Variants { get; set; }
         //DbSet<Product_Category>  product_Categories { get; set; }
        public DbSet<Product>  products { get; set; }
        public DbSet<Ecommerce_Website.Models.Category_subCategory> Category_subCategory { get; set; }
        public DbSet<Ecommerce_Website.Models.SubCategory_SubSubcategory> SubCategory_SubSubcategory { get; set; }
        public DbSet<Specification> specifications { get; set; }
        public DbSet<Product_Images> images { get; set; }
    }
}
