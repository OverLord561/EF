using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameworkHW.Models
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        [Display(Name = "Type")]
        public string Name { get; set; }

      
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}