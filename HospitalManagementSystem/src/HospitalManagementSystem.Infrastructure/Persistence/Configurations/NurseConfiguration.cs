using HospitalManagementSystem.Domain.Entities;
using HospitalManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class NurseConfiguration : IEntityTypeConfiguration<Nurse>
{
    public void Configure(EntityTypeBuilder<Nurse> builder)
    {
        builder.ToTable("Nurses");

        builder.HasKey(n => n.NurseId);

        builder.Property(n => n.Biography)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(n => n.Gender)
            .IsRequired()
            .HasConversion<Gender>();

        builder.Property(n => n.DateOfBirth)
            .IsRequired();

        builder.Property(n => n.ExperienceYears)
            .IsRequired();

        builder.Property(n => n.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(n => n.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(n => n.User)
            .WithMany(u => u.Nurses)
            .HasForeignKey(n => n.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(n => n.Staff)
            .WithMany(s => s.Nurses)
            .HasForeignKey(n => n.StaffId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(n => n.Department)
            .WithMany(d => d.Nurses)
            .HasForeignKey(n => n.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(n => n.OperationSchedule)
            .WithMany(o => o.Nurses)
            .HasForeignKey(n => n.OperationScheduleId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
