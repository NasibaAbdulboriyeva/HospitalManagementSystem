using HospitalManagementSystem.Domain.Entities;
using HospitalManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class SalaryConfiguration : IEntityTypeConfiguration<Salary>
{
    public void Configure(EntityTypeBuilder<Salary> builder)
    {
        builder.ToTable("Salaries");

        builder.HasKey(s => s.SalaryId);

        builder.Property(s => s.BaseAmount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(s => s.BonusAmount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(s => s.TotalAmount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(s => s.Month)
            .IsRequired();

        builder.Property(s => s.Year)
            .IsRequired();

        builder.Property(s => s.PaymentDate)
            .IsRequired();

        builder.Property(s => s.Status)
            .IsRequired();

        builder.Property(s => s.Notes)
            .IsRequired(false)
            .HasMaxLength(1000);

        builder.Property(s => s.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(s => s.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(s => s.Staff)
            .WithMany(st => st.Salaries)
            .HasForeignKey(s => s.StaffId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
