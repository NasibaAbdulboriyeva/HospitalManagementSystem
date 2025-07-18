using HospitalManagementSystem.Domain.Entities;
using HospitalManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("Payments");

        builder.HasKey(p => p.PaymentId);

        builder.Property(p => p.PaidAmount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(p => p.PaymentStatus)
            .IsRequired();

        builder.Property(p => p.Method)
            .IsRequired();

        builder.Property(p => p.PaidAt)
            .IsRequired();

        builder.Property(p => p.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(p => p.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(p => p.Patient)
            .WithMany(pa => pa.Payments)
            .HasForeignKey(p => p.PatientId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(p => p.User)
            .WithMany(u => u.Payments)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(p => p.Card)
            .WithMany(c => c.Payments)
            .HasForeignKey(p => p.CardId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
