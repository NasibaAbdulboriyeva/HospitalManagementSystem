using HospitalManagementSystem.Domain.Entities;
using HospitalManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        builder.ToTable("Appointments");

        builder.HasKey(a => a.AppointmentId);

        builder.Property(a => a.ScheduledDate)
            .IsRequired();

        builder.Property(a => a.Reason)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(a => a.AppointmentStatus)
            .IsRequired()
            .HasConversion<AppointmentStatus>();

        builder.Property(a => a.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(a => a.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(a => a.Patient)
            .WithMany(p => p.Appointments)
            .HasForeignKey(a => a.PatientId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(a => a.Doctor)
            .WithMany(d => d.Appointments)
            .HasForeignKey(a => a.DoctorId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
