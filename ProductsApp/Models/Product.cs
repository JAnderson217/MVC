using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string productName { get; set; }
        public decimal price { get; set; }
        public string description { get; set; } 
    }
}