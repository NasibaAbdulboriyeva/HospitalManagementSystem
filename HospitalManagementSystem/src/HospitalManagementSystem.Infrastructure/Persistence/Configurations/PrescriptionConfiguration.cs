using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class PrescriptionConfiguration : IEntityTypeConfiguration<Prescription>
{
    public void Configure(EntityTypeBuilder<Prescription> builder)
    {
        builder.ToTable("Prescriptions");

        builder.HasKey(p => p.PrescriptionId);

        builder.Property(p => p.DatePrescribed)
            .IsRequired();

        builder.Property(p => p.MedicineName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.Dosage)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.DurationDays)
            .IsRequired();

        builder.Property(p => p.Instructions)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(p => p.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(p => p.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(p => p.TreatmentPlan)
            .WithMany(tp => tp.Prescriptions)
            .HasForeignKey(p => p.TreatmentPlanId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(p => p.Patient)
            .WithMany(pa => pa.Prescriptions)
            .HasForeignKey(p => p.PatientId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(p => p.Doctor)
            .WithMany(d => d.Prescriptions)
            .HasForeignKey(p => p.DoctorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(p => p.PrescriptionMedicines)
            .WithOne(pm => pm.Prescription)
            .HasForeignKey(pm => pm.PrescriptionId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
