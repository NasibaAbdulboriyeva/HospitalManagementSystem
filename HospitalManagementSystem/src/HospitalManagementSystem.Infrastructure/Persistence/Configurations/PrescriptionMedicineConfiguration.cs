using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations;

public class PrescriptionMedicineConfiguration : IEntityTypeConfiguration<PrescriptionMedicine>
{
    public void Configure(EntityTypeBuilder<PrescriptionMedicine> builder)
    {
        builder.ToTable("PrescriptionMedicines");

        builder.HasKey(pm => new { pm.PrescriptionId, pm.MedicineId });

        builder.HasOne(pm => pm.Prescription)
            .WithMany(p => p.PrescriptionMedicines)
            .HasForeignKey(pm => pm.PrescriptionId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(pm => pm.Medicine)
            .WithMany(m => m.PrescriptionMedicines)
            .HasForeignKey(pm => pm.MedicineId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
