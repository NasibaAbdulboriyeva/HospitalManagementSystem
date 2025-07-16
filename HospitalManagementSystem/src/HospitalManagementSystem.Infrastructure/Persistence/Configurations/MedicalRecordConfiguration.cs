using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class MedicalRecordConfiguration : IEntityTypeConfiguration<MedicalRecord>
{
    public void Configure(EntityTypeBuilder<MedicalRecord> builder)
    {
        builder.ToTable("MedicalRecords");

        builder.HasKey(m => m.MedicalRecordId);

        builder.Property(m => m.Diagnosis)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(m => m.TreatmentSummary)
            .IsRequired()
            .HasMaxLength(2000);

        builder.Property(m => m.Notes)
            .IsRequired(false)
            .HasMaxLength(3000);

        builder.Property(m => m.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(m => m.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(m => m.Patient)
            .WithMany(p => p.MedicalRecords)
            .HasForeignKey(m => m.PatientId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(m => m.TreatmentPlans)
            .WithOne(tp => tp.MedicalRecord)
            .HasForeignKey(tp => tp.MedicalRecordId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
