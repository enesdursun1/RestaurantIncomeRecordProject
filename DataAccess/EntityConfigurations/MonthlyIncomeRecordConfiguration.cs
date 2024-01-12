using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations;

public class MonthlyIncomeRecordConfiguration : IEntityTypeConfiguration<MonthlyIncomeRecord>
{
    public void Configure(EntityTypeBuilder<MonthlyIncomeRecord> builder)
    {
        builder.ToTable("MonthlyIncomeRecords").HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Date).HasColumnName("Date").IsRequired();
        builder.Property(p => p.Price).HasColumnName("Price").IsRequired();
      



    }
}
