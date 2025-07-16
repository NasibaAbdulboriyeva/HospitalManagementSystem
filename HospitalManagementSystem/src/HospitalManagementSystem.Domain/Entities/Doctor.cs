using HospitalManagementSystem.Domain.Enums;
namespace HospitalManagementSystem.Domain.Entities;

public class Doctor : IAuditEntity
{
    public long DoctorId { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string LicenseNumber { get; set; }
    public int ExperienceYears { get; set; }
    public Gender Gender { get; set; }
    public string Biography { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public long DepartmentId { get; set; }
    public Department Department { get; set; }
    public long StaffId { get; set; } 
    public Staff Staff { get; set; }
    public long OperationScheduleId { get; set; }
    public OperationSchedule OperationSchedule { get; set; }
    public ICollection<DoctorSpecialization> DoctorSpecializations { get; set; }
    public ICollection<LabTest> LabTests { get; set; }
    public ICollection<Surgery> Surgeries { get; set; }
    public ICollection<TreatmentPlan> TreatmentPlans { get; set; }
    public ICollection<Prescription> Prescriptions { get; set; }
    public ICollection<Appointment> Appointments { get; set; }
    public ICollection<Feedback> Feedbacks { get; set; }
}

