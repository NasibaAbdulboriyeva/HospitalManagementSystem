using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;
public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.ToTable("Rooms");

        builder.HasKey(r => r.RoomId);

        builder.Property(r => r.RoomNumber)
                   .IsRequired()
                   .HasMaxLength(10);

        builder.Property(r => r.FloorNumber)
                    .IsRequired();

        builder.Property(r => r.Capacity)
                    .IsRequired();

        builder.Property(r => r.IsAvailable)
                    .IsRequired();

        builder.Property(r => r.CreatedAt)
                    .IsRequired()
                    .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(r => r.LastModifiedAt)
                    .IsRequired(false);

        builder.HasOne(r => r.Department)
                    .WithMany(d => d.Rooms)
                    .HasForeignKey(r => r.DepartmentId)
                    .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(r => r.Beds)
                    .WithOne(b => b.Room)
                    .HasForeignKey(b => b.RoomId)
                    .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(r => r.RoomNumber)
                    .IsUnique()
                    .HasDatabaseName("IX_Rooms_RoomNumber");

        builder.HasIndex(r => r.DepartmentId)
                    .HasDatabaseName("IX_Rooms_DepartmentId");
    }
}
