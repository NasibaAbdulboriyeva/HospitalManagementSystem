using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class HospitalConfiguration : IEntityTypeConfiguration<Hospital>
{
    public void Configure(EntityTypeBuilder<Hospital> builder)
    {
        builder.ToTable("Hospitals");

        builder.HasKey(h => h.HospitalId);

        builder.Property(h => h.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(h => h.Code)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(h => h.Type)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(h => h.Address)
            .IsRequired()
            .HasMaxLength(300);

        builder.Property(h => h.Region)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(h => h.District)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(h => h.PhoneNumber)
            .IsRequired()
            .HasMaxLength(15);

        builder.Property(h => h.Email)
            .IsRequired(false)
            .HasMaxLength(100);

        builder.Property(h => h.Website)
            .IsRequired(false)
            .HasMaxLength(200);

        builder.Property(h => h.LicenseNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(h => h.LicenseExpiryDate)
            .IsRequired();

        builder.Property(h => h.IsGovernmentOwned)
            .IsRequired();

        builder.Property(h => h.TotalBeds)
            .IsRequired();

        builder.Property(h => h.ICUCapacity)
            .IsRequired();

        builder.Property(h => h.OperatingRooms)
            .IsRequired();

        builder.Property(h => h.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(h => h.LastModifiedAt)
            .IsRequired(false);

        builder.HasMany(h => h.Departments)
            .WithOne(d => d.Hospital)
            .HasForeignKey(d => d.HospitalId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(h => h.Ambulances)
            .WithOne(a => a.Hospital)
            .HasForeignKey(a => a.HospitalId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(h => h.StaffMembers)
            .WithOne(s => s.Hospital)
            .HasForeignKey(s => s.HospitalId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(h => h.Patients)
            .WithOne(p => p.Hospital)
            .HasForeignKey(p => p.HospitalId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
