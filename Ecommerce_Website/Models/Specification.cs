﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_Website.Models
{
    public class Specification
    {
        [Key]
        public int SpecID { get; set; }
        [Display(Name = "Product")]
        public virtual int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Products { get; set; }
        public string SpecName { get; set; }
        public string SpecValue { get; set; }
    }
}