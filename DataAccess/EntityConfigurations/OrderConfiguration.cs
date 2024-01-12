using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders").HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ProductId).HasColumnName("ProductId").IsRequired();
        builder.Property(p => p.TableId).HasColumnName("TableId").IsRequired();
        builder.Property(p => p.Quantity).HasColumnName("Quantity").IsRequired();
      


        builder.HasOne(p => p.Product);
        builder.HasOne(p => p.Table);
      


    }
}
