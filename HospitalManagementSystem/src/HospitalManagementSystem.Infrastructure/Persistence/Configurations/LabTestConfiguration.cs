using HospitalManagementSystem.Domain.Entities;
using HospitalManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class LabTestConfiguration : IEntityTypeConfiguration<LabTest>
{
    public void Configure(EntityTypeBuilder<LabTest> builder)
    {
        builder.ToTable("LabTests");

        builder.HasKey(t => t.LabTestId);

        builder.Property(t => t.TestName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(t => t.Description)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(t => t.Result)
            .IsRequired(false)
            .HasMaxLength(2000);

        builder.Property(t => t.TestDate)
            .IsRequired();

        builder.Property(t => t.Status)
            .IsRequired()
            .HasConversion<Status>();

        builder.Property(t => t.Cost)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(t => t.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(t => t.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(t => t.Patient)
            .WithMany(p => p.LabTests)
            .HasForeignKey(t => t.PatientId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(t => t.Doctor)
            .WithMany(d => d.LabTests)
            .HasForeignKey(t => t.DoctorId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(t => t.TreatmentPlan)
            .WithMany(tp => tp.LabTests)
            .HasForeignKey(t => t.TreatmentPlanId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
