namespace HospitalManagementSystem.Domain.Entities;

public class Admission : IAuditEntity
{
    public long AdmissionId { get; set; }
    public DateTime AdmissionDate { get; set; }
    public DateTime? DischargeDate { get; set; }
    public string Diagnosis { get; set; }
    public bool IsDischarged { get; set; }
    public long? PatientId { get; set; }
    public Patient Patient { get; set; }
    public long? BedId { get; set; }
    public Bed Bed { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}