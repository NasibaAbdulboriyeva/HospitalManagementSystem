namespace HospitalManagementSystem.Domain.Entities;

public class Staff : IAuditEntity
{
    public long StaffId { get; set; }
    public string Position { get; set; }
    public DateTime EmploymentDate { get; set; }
    public bool IsActive { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }

    public long DepartmentId { get; set; }
    public Department Department { get; set; }
    public Doctor Doctor { get; set; }
    public Nurse Nurse{ get; set; }
    public ICollection<Schedule> Schedules { get; set; }
    public ICollection<Salary> Salaries { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }

}
