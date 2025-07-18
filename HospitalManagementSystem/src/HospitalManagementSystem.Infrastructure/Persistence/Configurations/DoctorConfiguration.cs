using HospitalManagementSystem.Domain.Entities;
using HospitalManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.ToTable("Doctors");

        builder.HasKey(d => d.DoctorId);

        builder.Property(d => d.DateOfBirth)
            .IsRequired();

        builder.Property(d => d.LicenseNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(d => d.ExperienceYears)
            .IsRequired();

        builder.Property(d => d.Gender)
            .IsRequired();

        builder.Property(d => d.Biography)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(d => d.IsActive)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(d => d.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(d => d.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(d => d.User)
            .WithOne(u => u.Doctor)
            .HasForeignKey<User>(d => d.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.Department)
            .WithMany(dep => dep.Doctors)
            .HasForeignKey(d => d.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.Staff)
            .WithMany(s => s.Doctors)
            .HasForeignKey(d => d.StaffId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.OperationSchedule)
            .WithMany(o => o.Doctors)
            .HasForeignKey(d => d.OperationScheduleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(d => d.Appointments)
            .WithOne(a => a.Doctor)
            .HasForeignKey(a => a.DoctorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(d => d.LabTests)
            .WithOne(lt => lt.Doctor)
            .HasForeignKey(lt => lt.DoctorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(d => d.Surgeries)
            .WithOne(s => s.Doctor)
            .HasForeignKey(s => s.DoctorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(d => d.TreatmentPlans)
            .WithOne(tp => tp.Doctor)
            .HasForeignKey(tp => tp.DoctorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(d => d.Prescriptions)
            .WithOne(p => p.Doctor)
            .HasForeignKey(p => p.DoctorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(d => d.DoctorSpecializations)
            .WithOne(ds => ds.Doctor)
            .HasForeignKey(ds => ds.DoctorId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
