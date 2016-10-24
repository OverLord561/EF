using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameworkHW.Models
{
    public class ProductInfo
    {
        public int prId { get; set; }

        [Display(Name = "Name")]
        public string prName { get; set; }
        [Display(Name = "Price")]
        public int prPrice { get; set; }
        [Display(Name = "Type")]
        public string prType { get; set; }
    }
}