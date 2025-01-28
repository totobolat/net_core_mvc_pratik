using System;
using Pratik.Models;
using Microsoft.EntityFrameworkCore;

namespace Pratik.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
    }
}
