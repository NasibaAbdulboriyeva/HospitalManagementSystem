using HospitalManagementSystem.Domain.Entities;
using HospitalManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.ToTable("Patients");

        builder.HasKey(p => p.PatientId);

        builder.Property(p => p.DateOfBirth)
            .IsRequired();

        builder.Property(p => p.Gender)
            .IsRequired()
            .HasConversion<Gender>();

        builder.Property(p => p.Address)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.EmergencyContact)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(p => p.BloodGroup)
            .IsRequired()
            .HasConversion<BloodGroup>();

        builder.Property(p => p.HeightCm)
            .IsRequired();

        builder.Property(p => p.WeightKg)
            .IsRequired();

        builder.Property(p => p.IsAdmitted)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(p => p.ProfileImageUrl)
            .IsRequired(false)
            .HasMaxLength(300);

        builder.Property(p => p.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(p => p.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(p => p.User)
            .WithMany(u => u.Patients)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(p => p.Admissions)
            .WithOne(a => a.Patient)
            .HasForeignKey(a => a.PatientId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.Appointments)
            .WithOne(a => a.Patient)
            .HasForeignKey(a => a.PatientId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.MedicalRecords)
            .WithOne(m => m.Patient)
            .HasForeignKey(m => m.PatientId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.Payments)
            .WithOne(pmt => pmt.Patient)
            .HasForeignKey(pmt => pmt.PatientId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.Feedbacks)
            .WithOne(f => f.Patient)
            .HasForeignKey(f => f.PatientId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
