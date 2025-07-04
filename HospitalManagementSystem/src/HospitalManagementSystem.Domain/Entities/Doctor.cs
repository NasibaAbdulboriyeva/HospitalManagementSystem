using HospitalManagementSystem.Domain.Enums;
namespace HospitalManagementSystem.Domain.Entities;

public class Doctor
{
    public long DoctorId { get; set; }
    public string Specialization { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string LicenseNumber { get; set; }
    public int ExperienceYears { get; set; }
    public Gender Gender { get; set; }
    public string? Biography { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }

    public long DepartmentId { get; set; }
    public Department Department { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }
}
