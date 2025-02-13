using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class SaleItemConfiguration : IEntityTypeConfiguration<SaleItem>
{
    public void Configure(EntityTypeBuilder<SaleItem> builder)
    {
        builder.ToTable("SaleItems");

        builder.HasKey(si => si.Id);
        builder.Property(si => si.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.Property(si => si.SaleId)
            .IsRequired();

        builder.Property(si => si.ProductId)
            .IsRequired();

        builder.Property(si => si.Quantity)
            .IsRequired()
            .HasDefaultValue(1);

        builder.Property(si => si.UnitPrice)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(si => si.Discount)
            .IsRequired()
            .HasColumnType("decimal(18,2)")
            .HasDefaultValue(0);

        builder.Property(si => si.TotalItemAmount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(si => si.IsCancelled)
            .IsRequired()
            .HasDefaultValue(false);

        builder.HasOne(si => si.Sale)
            .WithMany(s => (IEnumerable<SaleItem>)s.SaleItems)
            .HasForeignKey(si => si.SaleId);

        builder.HasOne(si => si.Product)
            .WithMany()
            .HasForeignKey(si => si.ProductId);
    }
}
