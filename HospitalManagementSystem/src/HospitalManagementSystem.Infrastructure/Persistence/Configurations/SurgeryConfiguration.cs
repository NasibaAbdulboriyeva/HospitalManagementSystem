using HospitalManagementSystem.Domain.Entities;
using HospitalManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class SurgeryConfiguration : IEntityTypeConfiguration<Surgery>
{
    public void Configure(EntityTypeBuilder<Surgery> builder)
    {
        builder.ToTable("Surgeries");

        builder.HasKey(s => s.SurgeryId);

        builder.Property(s => s.SurgeryName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(s => s.Description)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(s => s.ScheduledDateTime)
            .IsRequired();

        builder.Property(s => s.DurationInMinutes)
            .IsRequired();

        builder.Property(s => s.Status)
            .IsRequired();

        builder.Property(s => s.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(s => s.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(s => s.Patient)
            .WithMany(p => p.Surgeries)
            .HasForeignKey(s => s.PatientId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(s => s.Doctor)
            .WithMany(d => d.Surgeries)
            .HasForeignKey(s => s.DoctorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(s => s.TreatmentPlan)
            .WithMany(tp => tp.Surgeries)
            .HasForeignKey(s => s.TreatmentPlanId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(s => s.OperationTheatre)
            .WithMany(ot => ot.Surgeries)
            .HasForeignKey(s => s.OperationTheatreId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(s => s.OperationSchedule)
            .WithMany(os => os.Surgeries)
            .HasForeignKey(s => s.OperationScheduleId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
