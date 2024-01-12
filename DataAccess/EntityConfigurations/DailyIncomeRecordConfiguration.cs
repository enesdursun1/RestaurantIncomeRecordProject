using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class DailyIncomeRecordConfiguration : IEntityTypeConfiguration<DailyIncomeRecord>
{
    public void Configure(EntityTypeBuilder<DailyIncomeRecord> builder)
    {
        builder.ToTable("DailyIncomeRecords").HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.ProductName).HasColumnName("ProductName").IsRequired();
        builder.Property(p => p.Quantity).HasColumnName("Quantity").IsRequired();
 




    }
}