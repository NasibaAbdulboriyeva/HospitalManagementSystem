using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class OperationTheatreConfiguration : IEntityTypeConfiguration<OperationTheatre>
{
    public void Configure(EntityTypeBuilder<OperationTheatre> builder)
    {
        builder.ToTable("OperationTheatres");

        builder.HasKey(ot => ot.OperationTheatreId);

        builder.Property(ot => ot.RoomNumber)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(ot => ot.Floor)
            .IsRequired();

        builder.Property(ot => ot.EquipmentDetails)
            .IsRequired()
            .HasMaxLength(2000);

        builder.Property(ot => ot.IsAvailable)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(ot => ot.Notes)
            .IsRequired(false)
            .HasMaxLength(1000);

        builder.Property(ot => ot.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(ot => ot.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(ot => ot.Department)
            .WithMany(d => d.OperationTheatres)
            .HasForeignKey(ot => ot.DepartmentId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(ot => ot.OperationSchedules)
            .WithOne(os => os.OperationTheatre)
            .HasForeignKey(os => os.OperationTheatreId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(ot => ot.Surgeries)
            .WithOne(s => s.OperationTheatre)
            .HasForeignKey(s => s.OperationTheatreId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
