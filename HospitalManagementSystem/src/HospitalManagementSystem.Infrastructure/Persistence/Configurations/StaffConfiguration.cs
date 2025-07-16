using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class StaffConfiguration : IEntityTypeConfiguration<Staff>
{
    public void Configure(EntityTypeBuilder<Staff> builder)
    {
        builder.ToTable("Staff");

        builder.HasKey(s => s.StaffId);

        builder.Property(s => s.Position)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(s => s.EmploymentDate)
            .IsRequired();

        builder.Property(s => s.IsActive)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(s => s.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(s => s.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(s => s.User)
            .WithMany(u => u.Staffs)
            .HasForeignKey(s => s.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(s => s.Hospital)
            .WithMany(h => h.StaffMembers)
            .HasForeignKey(s => s.HospitalId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(s => s.Department)
            .WithMany(d => d.Staffs)
            .HasForeignKey(s => s.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Salaries)
            .WithOne(sl => sl.Staff)
            .HasForeignKey(sl => sl.StaffId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(s => s.Schedules)
            .WithOne(sc => sc.Staff)
            .HasForeignKey(sc => sc.StaffId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(s => s.Doctors)
            .WithOne(d => d.Staff)
            .HasForeignKey(d => d.StaffId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(s => s.Nurses)
            .WithOne(n => n.Staff)
            .HasForeignKey(n => n.StaffId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
