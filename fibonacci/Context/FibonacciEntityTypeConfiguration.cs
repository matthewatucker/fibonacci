using fibonacci.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fibonacci.Context
{
    public class FibonacciEntityTypeConfiguration : IEntityTypeConfiguration<FibonacciNumber>
    {
        public void Configure(EntityTypeBuilder<FibonacciNumber> builder)
        {
            builder.HasIndex(fn => fn.Value);

            builder.Property(fn => fn.Value)
                .IsRequired();

            builder.Property(fn => fn.Next)
                .IsRequired();

            builder.Property(fn => fn.Previous)
                .IsRequired();
        }
    }
}
