namespace HospitalManagementSystem.Domain.Entities;

public class Staff : IAuditEntity
{
    public long StaffId { get; set; }
    public string Position { get; set; }
    public DateTime EmploymentDate { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }

    public Hospital Hospital { get; set; }
    public long? HospitalId { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }

    public Department Department { get; set; }
    public long DepartmentId { get; set; }

    public ICollection<Schedule> Schedules { get; set; }
    public ICollection<Salary> Salaries { get; set; }
    public ICollection<Doctor> Doctors { get; set; }
    public ICollection<Nurse> Nurses { get; set; }
}
