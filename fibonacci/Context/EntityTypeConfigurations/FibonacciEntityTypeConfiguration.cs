using Fibonacci.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fibonacci.Context
{
    public class FibonacciEntityTypeConfiguration : IEntityTypeConfiguration<FibonacciNumber>
    {
        public void Configure(EntityTypeBuilder<FibonacciNumber> builder)
        {
            builder.HasKey(fn => fn.Id);

            builder.HasIndex(fn => fn.Value)
                .IsUnique();

            builder.Property(fn => fn.Value)
                .IsRequired();

            builder.Property(fn => fn.Next)
                .IsRequired();

            builder.Property(fn => fn.Previous)
                .IsRequired();
        }
    }
}
