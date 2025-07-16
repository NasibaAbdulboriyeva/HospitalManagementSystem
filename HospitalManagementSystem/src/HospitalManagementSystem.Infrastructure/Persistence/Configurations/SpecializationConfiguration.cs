using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class SpecializationConfiguration : IEntityTypeConfiguration<Specialization>
{
    public void Configure(EntityTypeBuilder<Specialization> builder)
    {
        builder.ToTable("Specializations");

        builder.HasKey(s => s.SpecializationId);

        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(s => s.Description)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(s => s.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(s => s.LastModifiedAt)
            .IsRequired(false);

        builder.HasMany(s => s.DoctorSpecializations)
            .WithOne(ds => ds.Specialization)
            .HasForeignKey(ds => ds.SpecializationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
