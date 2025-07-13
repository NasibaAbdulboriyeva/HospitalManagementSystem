namespace HospitalManagementSystem.Domain.Entities;

public class Department : IAuditEntity
{
    public long DepartmentId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
    public ICollection<Room> Rooms { get; set; }
    public ICollection<Staff> Staffs { get; set; }
    public ICollection<Doctor> Doctors { get; set; }
    public ICollection<Nurse> Nurses { get; set; }
}