using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;
public class Nurse
{
    public long NurseId { get; set; }
    public string Biography { get; set; }
    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int ExperienceYears { get; set; }
    public DateTime CreatedAt { get; set; }

    public long DepartmentId { get; set; }
    public Department Department { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }
}



