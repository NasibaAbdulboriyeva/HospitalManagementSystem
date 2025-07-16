using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;
public class BedConfiguration : IEntityTypeConfiguration<Bed>
{
    public void Configure(EntityTypeBuilder<Bed> builder)
    {
        builder.ToTable("Beds");

        builder.HasKey(b => b.BedId);

        builder.Property(b => b.BedNumber)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(b => b.IsOccupied)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(b => b.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(b => b.LastModifiedAt)
            .IsRequired(false);

        builder.HasOne(b => b.Room)
            .WithMany(r => r.Beds)
            .HasForeignKey(b => b.RoomId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(b => b.BedNumber)
            .IsUnique()
            .HasDatabaseName("IX_Beds_BedNumber");

        builder.HasOne(b => b.Admissions)
             .WithOne(a => a.Bed)
             .HasForeignKey<Admission>(a => a.BedId)
             .OnDelete(DeleteBehavior.SetNull);
    }
}
