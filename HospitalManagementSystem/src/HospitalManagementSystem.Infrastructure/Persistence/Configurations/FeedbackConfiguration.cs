using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
{
    public void Configure(EntityTypeBuilder<Feedback> builder)
    {
        builder.ToTable("Feedbacks");

        builder.HasKey(f => f.FeedbackId);

        builder.Property(f => f.Message)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(f => f.Rating)
            .IsRequired();

        builder.Property(f => f.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(f => f.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(f => f.Patient)
            .WithMany(p => p.Feedbacks)
            .HasForeignKey(f => f.PatientId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(f => f.Doctor)
            .WithMany(d => d.Feedbacks)
            .HasForeignKey(f => f.DoctorId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
