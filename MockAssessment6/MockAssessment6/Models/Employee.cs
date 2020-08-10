using System;
using System.ComponentModel.DataAnnotations;

namespace MockAssessment6.Models
{
    public class Employee
    {
        public Employee()
        {
        }
        public int EmployeeID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        public int Age { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public double Salary { get; set; }
    }
}
