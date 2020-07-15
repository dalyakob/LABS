using System;
using System.ComponentModel.DataAnnotations;

namespace Lab20.Models
{
    public class Registration
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
