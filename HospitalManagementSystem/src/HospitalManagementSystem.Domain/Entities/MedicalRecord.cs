namespace HospitalManagementSystem.Domain.Entities;

public class MedicalRecord : IAuditEntity
{
    public long MedicalRecordId { get; set; }
    public string Diagnosis { get; set; } 
    public string TreatmentSummary { get; set; } 
    public string Notes { get; set; }
    public long PatientId { get; set; }
    public Patient Patient { get; set; }
    public ICollection<TreatmentPlan> TreatmentPlans { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}
