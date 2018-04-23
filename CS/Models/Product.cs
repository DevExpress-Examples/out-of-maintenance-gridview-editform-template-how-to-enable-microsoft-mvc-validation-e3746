using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Example.Models
{
    public class Product
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Name { get; set; }
    }
}