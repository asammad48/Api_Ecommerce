using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_Website.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductImage { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        [Display(Name = "Category")]
        public virtual int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Product_Category { get; set; }
    }
}
