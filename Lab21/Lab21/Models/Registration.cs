using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Lab21.Services;

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
