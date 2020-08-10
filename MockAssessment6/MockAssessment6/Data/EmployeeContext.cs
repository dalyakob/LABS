using System;
using Microsoft.EntityFrameworkCore;
using MockAssessment6.Models;

namespace MockAssessment6.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
