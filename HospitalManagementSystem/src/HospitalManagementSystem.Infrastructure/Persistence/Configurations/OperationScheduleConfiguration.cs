using HospitalManagementSystem.Domain.Entities;
using HospitalManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class OperationScheduleConfiguration : IEntityTypeConfiguration<OperationSchedule>
{
    public void Configure(EntityTypeBuilder<OperationSchedule> builder)
    {
        builder.ToTable("OperationSchedules");

        builder.HasKey(os => os.OperationScheduleId);

        builder.Property(os => os.ScheduledStartTime)
            .IsRequired();

        builder.Property(os => os.ScheduledEndTime)
            .IsRequired();

        builder.Property(os => os.Status)
            .IsRequired()
            .HasConversion<Status>();

        builder.Property(os => os.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(os => os.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(os => os.OperationTheatre)
            .WithMany(ot => ot.OperationSchedules)
            .HasForeignKey(os => os.OperationTheatreId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(os => os.Doctors)
            .WithOne(d => d.OperationSchedule)
            .HasForeignKey(d => d.OperationScheduleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(os => os.Nurses)
            .WithOne(n => n.OperationSchedule)
            .HasForeignKey(n => n.OperationScheduleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(os => os.Surgeries)
            .WithOne(s => s.OperationSchedule)
            .HasForeignKey(s => s.OperationScheduleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
