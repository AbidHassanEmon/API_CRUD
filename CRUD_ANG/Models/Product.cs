using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_ANG.Models
{
    public class Product
    {
        public int ID { get; set; }
    [Required]
        public string Name { get; set; }
    [Required]
        public int Price { get; set; }
        public string Description { get; set; }
    [Required]
        public int Quantity { get; set; }
    }
}
