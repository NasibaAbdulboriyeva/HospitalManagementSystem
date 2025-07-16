namespace HospitalManagementSystem.Domain.Entities;

public class Hospital : IAuditEntity
{
    public long HospitalId { get; set; }
    public string Name { get; set; }
    public string Code { get; set; } 
    public string Type { get; set; } 
    public string Address { get; set; }
    public string Region { get; set; }
    public string District { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
    public string LicenseNumber { get; set; }
    public DateTime LicenseExpiryDate { get; set; }
    public bool IsGovernmentOwned { get; set; }
    public int TotalBeds { get; set; }
    public int ICUCapacity { get; set; }
    public int OperatingRooms { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
    public ICollection<Department> Departments { get; set; }
    public ICollection<Ambulance> Ambulances { get; set; }
    public ICollection<Staff> StaffMembers { get; set; }
    public ICollection<Patient> Patients { get; set; }
}