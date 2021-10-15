using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Week6Test.Core.Models;
using Week6Test.EF;

namespace Week6Test.EF.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.ClientID);

            builder.Property(c => c.ClientCode)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(c => c.Nome)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.Cognome)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .HasMany(o => o.Orders)
                .WithOne(c => c.Client);
        }
    }
}
