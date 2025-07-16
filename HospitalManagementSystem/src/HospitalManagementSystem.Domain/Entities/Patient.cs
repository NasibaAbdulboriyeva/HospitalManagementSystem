using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;

public class Patient : IAuditEntity
{
    public long PatientId { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string Address { get; set; }
    public string EmergencyContact { get; set; }
    public BloodGroup BloodGroup { get; set; }
    public int HeightCm { get; set; }
    public int WeightKg { get; set; }
    public bool IsAdmitted { get; set; }
    public string? ProfileImageUrl { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }

    public Hospital Hospital { get; set; }
    public long HospitalId { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }

    public ICollection<Appointment> Appointments { get; set; }
    public ICollection<MedicalRecord> MedicalRecords { get; set; }
    public ICollection<Admission> Admissions { get; set; }
    public ICollection<Payment> Payments { get; set; }
    public ICollection<Feedback> Feedbacks { get; set; }
    public ICollection<LabTest> LabTests { get; set; }
    public ICollection<Prescription> Prescriptions { get; set; }
    public ICollection<Surgery> Surgeries { get; set; }
    public ICollection<TreatmentPlan> TreatmentPlans { get; set; }
}
