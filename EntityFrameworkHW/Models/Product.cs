using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameworkHW.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Display(Name = "Name")]
        public string ProductName { get; set; }
        [Display(Name = "Price")]
        public int ProductPrice { get; set; }

        public List<ProductType> ProductTypes { get; set; }

    }
}