using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class MedicineConfiguration : IEntityTypeConfiguration<Medicine>
{
    public void Configure(EntityTypeBuilder<Medicine> builder)
    {
        builder.ToTable("Medicines");

        builder.HasKey(m => m.MedicineId);

        builder.Property(m => m.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(m => m.GenericName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(m => m.DosageForm)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(m => m.Strength)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(m => m.Quantity)
            .IsRequired();

        builder.Property(m => m.Notes)
            .IsRequired(false)
            .HasMaxLength(1000);

        builder.Property(m => m.ReceivedDate)
            .IsRequired();

        builder.Property(m => m.ExpiryDate)
            .IsRequired(false);

        builder.Property(m => m.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(m => m.LastModifiedAt)
            .IsRequired(false);

        builder.HasMany(m => m.PrescriptionMedicines)
            .WithOne(pm => pm.Medicine)
            .HasForeignKey(pm => pm.MedicineId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
