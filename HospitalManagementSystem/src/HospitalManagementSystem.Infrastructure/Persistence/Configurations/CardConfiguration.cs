using HospitalManagementSystem.Domain.Entities;
using HospitalManagementSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;
public class CardConfiguration : IEntityTypeConfiguration<Card>
{
    public void Configure(EntityTypeBuilder<Card> builder)
    {
        builder.ToTable("Cards");

        builder.HasKey(c => c.CardId);

        builder.Property(c => c.CardNumberMasked)
                  .IsRequired()
                  .HasMaxLength(16);

        builder.Property(c => c.CardHolderName)
                  .IsRequired()
                  .HasMaxLength(100);

        builder.Property(c => c.ExpiryMonth)
                .IsRequired();

        builder.Property(c => c.ExpiryYear)
                  .IsRequired();

        builder.Property(c => c.CardType)
                  .IsRequired();

        builder.Property(c => c.SelectedForPayment)
                    .IsRequired()
                    .HasDefaultValue(false);

        builder.Property(c => c.CreatedAt)
                  .IsRequired()
                  .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(c => c.LastModifiedAt)
                    .IsRequired(false);

        builder.HasOne(c => c.User)
                     .WithMany(u => u.Cards)
                     .HasForeignKey(c => c.UserId)
                     .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.Payments)
                     .WithOne(p => p.Card)
                     .HasForeignKey(p => p.CardId)
                     .OnDelete(DeleteBehavior.Restrict);
    }
}
