using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Protoshop.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Du måste fylla i namn")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Håll dig mellan 10 och 500 karaktärer")]
        [StringLength(500, MinimumLength = 10)]
        public string Description { get; set; }
        [Required(ErrorMessage ="Priset måste vara mellan 0 och 10000")]
        [Range(0,10000)]
        public double Price { get; set; }
        [Required]
        public string ImageFile { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}