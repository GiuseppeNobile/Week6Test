using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week6Test.Core.Models;
using Week6Test.EF;

namespace Week6Test.EF.Configurations
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.OrderID);

            builder.Property(o => o.OrderDate)
                .IsRequired();

            builder.Property(o => o.OrderCode)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(o => o.ProductCode)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(o => o.Price)
                .IsRequired();

            builder.HasOne(o => o.Client)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.Client);
        }
    }
}
