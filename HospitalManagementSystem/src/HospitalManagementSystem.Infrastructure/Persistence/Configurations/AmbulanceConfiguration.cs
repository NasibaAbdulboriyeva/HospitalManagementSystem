using HospitalManagementSystem.Domain.Entities;
using HospitalManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class AmbulanceConfiguration : IEntityTypeConfiguration<Ambulance>
{
    public void Configure(EntityTypeBuilder<Ambulance> builder)
    {
        builder.ToTable("Ambulances");

        builder.HasKey(a => a.AmbulanceId);

        builder.Property(a => a.VehicleNumber)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(a => a.DriverName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.PhoneNumber)
            .IsRequired()
            .HasMaxLength(15);

        builder.Property(a => a.AmbulanceStatus)
            .IsRequired();

        builder.Property(a => a.Location)
            .HasMaxLength(200);

        builder.Property(a => a.LastServiceDate)
            .IsRequired();

        builder.Property(a => a.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(a => a.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(a => a.Hospital)
            .WithMany(h => h.Ambulances)
            .HasForeignKey(a => a.HospitalId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
