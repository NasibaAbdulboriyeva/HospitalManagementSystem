using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;
public class Nurse : IAuditEntity
{
    public long NurseId { get; set; }
    public string Biography { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int ExperienceYears { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public long OperationScheduleId { get; set; }
    public OperationSchedule OperationSchedule { get; set; }
    public long StaffId { get; set; } // 👈 FK to Staff
    public Staff Staff { get; set; }
    public long DepartmentId { get; set; }
    public Department Department { get; set; }





}



