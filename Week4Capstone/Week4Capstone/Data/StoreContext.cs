using System;
using Microsoft.EntityFrameworkCore;
using Week4Capstone.Models;

namespace Week4Capstone.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
