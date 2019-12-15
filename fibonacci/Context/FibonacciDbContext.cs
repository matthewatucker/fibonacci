using fibonacci.Models;

using Microsoft.EntityFrameworkCore;

namespace fibonacci.Context
{
    public class FibonacciDbContext : DbContext
    {
        public DbSet<FibonacciNumber> FibonacciNumbers { get; set; }

        public FibonacciDbContext(DbContextOptions<FibonacciDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FibonacciEntityTypeConfiguration());
        }
    }
}
