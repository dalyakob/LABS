using System;
using System.Linq;
using MockAssessment6.Models;

namespace MockAssessment6.Data
{
    public static class DbInitializer
    {
        
        public static void Initialize(EmployeeContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Employees.Any())
            {
                context.Employees.Add(new Employee() { FirstName = "Jimmy", Age = 70, Salary = 90000 });
                context.Employees.Add(new Employee() { FirstName = "Sandy", Age = 50, Salary = 45000 });
                context.Employees.Add(new Employee() { FirstName = "Allen", Age = 25, Salary = 30000 });

                context.SaveChanges();
            }
        }
        
    }
}
