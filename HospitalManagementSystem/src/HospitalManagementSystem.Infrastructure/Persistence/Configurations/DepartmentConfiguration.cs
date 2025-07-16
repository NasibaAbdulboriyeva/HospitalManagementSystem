using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;
public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("Departments");

        builder.HasKey(d => d.DepartmentId);

        builder.Property(d => d.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(d => d.Description)
            .HasMaxLength(500);

        builder.Property(d => d.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(d => d.LastModifiedAt)
            .IsRequired(false);

        builder.HasMany(d => d.Rooms)
            .WithOne(r => r.Department)
            .HasForeignKey(r => r.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(d => d.Staffs)
            .WithOne(s => s.Department)
            .HasForeignKey(s => s.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(d => d.Doctors)
            .WithOne(doc => doc.Department)
            .HasForeignKey(doc => doc.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(d => d.Nurses)
            .WithOne(n => n.Department)
            .HasForeignKey(n => n.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
