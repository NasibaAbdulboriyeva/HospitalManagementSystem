using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations
{
    public class BedConfiguration : IEntityTypeConfiguration<Bed>
    {
        public void Configure(EntityTypeBuilder<Bed> builder)
        {
            builder.ToTable("Beds");

            builder.HasKey(b => b.BedId);

            builder.Property(b => b.BedNumber)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(b => b.IsOccupied)
                   .IsRequired();

            builder.Property(b => b.CreatedAt)
                   .IsRequired()
                   .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(b => b.LastModifiedAt)
                   .IsRequired(false);

            builder.HasOne(b => b.Room)
                   .WithMany(r => r.Beds)
                   .HasForeignKey(b => b.RoomId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(b => b.Admissions)
                   .WithOne(a => a.Bed)
                   .HasForeignKey(a => a.BedId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
