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
            .IsRequired();

        builder.Property(p => p.Address)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.EmergencyContact)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(p => p.BloodGroup)
            .IsRequired();

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

        builder.HasOne(p => p.Hospital)
           .WithMany(h => h.Patients)
           .HasForeignKey(p => p.HospitalId)
           .OnDelete(DeleteBehavior.SetNull); // Hospital o‘chsa Patient HospitalId NULL bo‘ladi

        // Patient → User (One-to-One)
        builder.HasOne(p => p.User)
            .WithOne(u => u.Patient)
            .HasForeignKey<Patient>(p => p.UserId)
            .OnDelete(DeleteBehavior.Cascade); // User o‘chsa Patient ham o‘chadi

        // Patient → Appointments (One-to-Many)
        builder.HasMany(p => p.Appointments)
            .WithOne(a => a.Patient)
            .HasForeignKey(a => a.PatientId)
            .OnDelete(DeleteBehavior.Restrict); // Appointments bo‘lsa Patient o‘chmaydi

        // Patient → MedicalRecords (One-to-Many)
        builder.HasMany(p => p.MedicalRecords)
            .WithOne(mr => mr.Patient)
            .HasForeignKey(mr => mr.PatientId)
            .OnDelete(DeleteBehavior.Restrict);

        // Patient → Admissions (One-to-Many)
        builder.HasMany(p => p.Admissions)
            .WithOne(a => a.Patient)
            .HasForeignKey(a => a.PatientId)
            .OnDelete(DeleteBehavior.Restrict);

        // Patient → Payments (One-to-Many)
        builder.HasMany(p => p.Payments)
            .WithOne(pay => pay.Patient)
            .HasForeignKey(pay => pay.PatientId)
            .OnDelete(DeleteBehavior.Restrict);

        // Patient → Feedbacks (One-to-Many)
        builder.HasMany(p => p.Feedbacks)
            .WithOne(fb => fb.Patient)
            .HasForeignKey(fb => fb.PatientId)
            .OnDelete(DeleteBehavior.Restrict);

        // Patient → LabTests (One-to-Many)
        builder.HasMany(p => p.LabTests)
            .WithOne(lt => lt.Patient)
            .HasForeignKey(lt => lt.PatientId)
            .OnDelete(DeleteBehavior.Restrict);

        // Patient → Prescriptions (One-to-Many)
        builder.HasMany(p => p.Prescriptions)
            .WithOne(pr => pr.Patient)
            .HasForeignKey(pr => pr.PatientId)
            .OnDelete(DeleteBehavior.Restrict);

        // Patient → Surgeries (One-to-Many)
        builder.HasMany(p => p.Surgeries)
            .WithOne(s => s.Patient)
            .HasForeignKey(s => s.PatientId)
            .OnDelete(DeleteBehavior.Restrict);

        // Patient → TreatmentPlans (One-to-Many)
        builder.HasMany(p => p.TreatmentPlans)
            .WithOne(tp => tp.Patient)
            .HasForeignKey(tp => tp.PatientId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
