using HospitalManagementSystem.Domain.Entities;
using HospitalManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class TreatmentPlanConfiguration : IEntityTypeConfiguration<TreatmentPlan>
{
    public void Configure(EntityTypeBuilder<TreatmentPlan> builder)
    {
        builder.ToTable("TreatmentPlans");

        builder.HasKey(tp => tp.TreatmentPlanId);

        builder.Property(tp => tp.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(tp => tp.Description)
            .IsRequired()
            .HasMaxLength(2000);

        builder.Property(tp => tp.StartDate)
            .IsRequired();

        builder.Property(tp => tp.EndDate)
            .IsRequired(false);

        builder.Property(tp => tp.TreatmentPlanStatus)
            .IsRequired();

        builder.Property(tp => tp.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(tp => tp.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(tp => tp.Doctor)
            .WithMany(d => d.TreatmentPlans)
            .HasForeignKey(tp => tp.DoctorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(tp => tp.Patient)
            .WithMany(p => p.TreatmentPlans)
            .HasForeignKey(tp => tp.PatientId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(tp => tp.MedicalRecord)
            .WithMany(mr => mr.TreatmentPlans)
            .HasForeignKey(tp => tp.MedicalRecordId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(tp => tp.Prescriptions)
            .WithOne(p => p.TreatmentPlan)
            .HasForeignKey(p => p.TreatmentPlanId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(tp => tp.LabTests)
            .WithOne(lt => lt.TreatmentPlan)
            .HasForeignKey(lt => lt.TreatmentPlanId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(tp => tp.Surgeries)
            .WithOne(s => s.TreatmentPlan)
            .HasForeignKey(s => s.TreatmentPlanId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
