using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.ToTable("Schedules");

        builder.HasKey(s => s.ScheduleId);

        builder.Property(s => s.StartTime)
            .IsRequired();

        builder.Property(s => s.EndTime)
            .IsRequired();

        builder.Property(s => s.IsOnCall)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(s => s.DayOfWeek)
            .IsRequired();

        builder.Property(s => s.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(s => s.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(s => s.Staff)
            .WithMany(st => st.Schedules)
            .HasForeignKey(s => s.StaffId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
