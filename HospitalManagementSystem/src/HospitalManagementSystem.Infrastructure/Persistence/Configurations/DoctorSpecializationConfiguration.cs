using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class DoctorSpecializationConfiguration : IEntityTypeConfiguration<DoctorSpecialization>
{
    public void Configure(EntityTypeBuilder<DoctorSpecialization> builder)
    {
        builder.ToTable("DoctorSpecializations");

        builder.HasKey(ds => new { ds.DoctorId, ds.SpecializationId });

        builder.Property(ds => ds.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(ds => ds.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(ds => ds.Doctor)
            .WithMany(d => d.DoctorSpecializations)
            .HasForeignKey(ds => ds.DoctorId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ds => ds.Specialization)
            .WithMany(s => s.DoctorSpecializations)
            .HasForeignKey(ds => ds.SpecializationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
