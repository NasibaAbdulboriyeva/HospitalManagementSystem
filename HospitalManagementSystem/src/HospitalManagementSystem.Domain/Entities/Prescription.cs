namespace HospitalManagementSystem.Domain.Entities;

public class Prescription : IAuditEntity
{
    public long PrescriptionId { get; set; }

    public long PatientId { get; set; }
    public Patient Patient { get; set; } 

    public long DoctorId { get; set; }
    public Doctor Doctor { get; set; } 

    public DateTime DatePrescribed { get; set; }

    public string MedicineName { get; set; } 

    public string Dosage { get; set; } 

    public int DurationDays { get; set; }

    public string Instructions { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}
