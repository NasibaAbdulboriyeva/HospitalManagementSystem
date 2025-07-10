using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;

public class Patient : IAuditEntity
{
    public long PatientId { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string Address { get; set; } 
    public string EmergencyContact { get; set; } 
    public string BloodGroup { get; set; } 
    public int HeightCm { get; set; }
    public int WeightKg { get; set; }
    public bool IsAdmitted { get; set; }

    public DateTime CreatedAt { get; set; } 
    public DateTime? LastModifiedAt { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }
}
