using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.UserId);

            builder.Property(u => u.FirstName)
                   .IsRequired()
                   .HasMaxLength(70);

            builder.Property(u => u.LastName)
                   .IsRequired()
                   .HasMaxLength(70);

            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.PhoneNumber)
                   .HasMaxLength(20);

            builder.Property(u => u.Username)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(u => u.PasswordHash)
                   .IsRequired();

            builder.Property(u => u.Salt)
                   .IsRequired();

            builder.Property(u => u.CreatedAt)
                   .HasDefaultValue(DateTime.UtcNow);

            builder.Property(u => u.LastModifiedAt)
                   .IsRequired(false);


            builder.HasMany(u => u.UserRoles)
                   .WithOne(ur => ur.User)
                   .HasForeignKey(ur => ur.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Notifications)
                   .WithOne(n => n.User)
                   .HasForeignKey(n => n.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Payments)
                   .WithOne(p => p.User)
                   .HasForeignKey(p => p.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }


    }

}

