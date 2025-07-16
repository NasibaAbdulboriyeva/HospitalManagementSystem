using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder.HasKey(r => r.RoleId);

        builder.Property(r => r.RoleName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(r => r.Description)
            .IsRequired()
                .HasMaxLength(500);

        builder.Property(r => r.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(r => r.LastModifiedAt)
            .IsRequired(false);

        builder.HasMany(r => r.UserRoles)
            .WithOne(ur => ur.Role)
            .HasForeignKey(ur => ur.RoleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
