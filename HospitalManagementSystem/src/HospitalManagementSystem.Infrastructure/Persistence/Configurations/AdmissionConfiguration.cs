using HospitalManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Infrastructure.Persistence.Configurations
{
    public class AdmissionConfiguration : IEntityTypeConfiguration<Admission>
    {
        public void Configure(EntityTypeBuilder<Admission> builder)
        {
            builder.ToTable("Admissions");

            builder.HasKey(a => a.AdmissionId);

            builder.Property(a => a.AdmissionDate)
                .IsRequired();

            builder.Property(a => a.DischargeDate)
                .IsRequired(false);

            builder.Property(a => a.Diagnosis)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(a => a.IsDischarged)
                .IsRequired();

            builder.Property(a => a.CreatedAt)
                .IsRequired();

            builder.Property(a => a.LastModifiedAt)
                .IsRequired(false);

            builder.HasOne(a => a.Patient)
                .WithMany(p => p.Admissions) 
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.HasOne(a => a.Bed)
                .WithMany(b => b.Admissions) 
                .HasForeignKey(a => a.BedId)
                .OnDelete(DeleteBehavior.SetNull); 
        }
    }
}
