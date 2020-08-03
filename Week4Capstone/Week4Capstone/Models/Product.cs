using System;
using System.ComponentModel.DataAnnotations;

namespace Week4Capstone.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public double Price { get; set; }

        public string URL { get; set; }
    }
}
