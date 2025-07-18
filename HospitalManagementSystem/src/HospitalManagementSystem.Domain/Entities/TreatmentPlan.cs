using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;

public class TreatmentPlan : IAuditEntity
{
    public long TreatmentPlanId { get; set; }

    public string Title { get; set; } 

    public string Description { get; set; } 

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public TreatmentPlanStatus TreatmentPlanStatus { get; set; }
    public long DoctorId { get; set; }
    public Doctor Doctor { get; set; }
    public long? PatientId { get; set; }
    public Patient Patient { get; set; }

    public long? MedicalRecordId { get; set; }
    public MedicalRecord MedicalRecord { get; set; }
    public ICollection<Prescription> Prescriptions { get; set; }
    public ICollection<LabTest> LabTests { get; set; }
    public ICollection<Surgery> Surgeries { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}
