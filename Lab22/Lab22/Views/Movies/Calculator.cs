using System;
using System.ComponentModel.DataAnnotations;

namespace MockAssessment5.Models
{
    public class Calculator
    {
        public Calculator()
        {
            
        }
        [Required]
        public int Num1 { get; set; }

        [Required]
        public int Num2 { get; set; }

        public OperationType Operation { get; set; }
    }
}
