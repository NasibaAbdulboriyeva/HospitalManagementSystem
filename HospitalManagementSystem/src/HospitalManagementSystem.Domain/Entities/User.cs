namespace HospitalManagementSystem.Domain.Entities;

public class User : IAuditEntity
{
    public long UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }

    public ICollection<UserRole> UserRoles { get; set; }
    public ICollection<Notification> Notifications { get; set; }
    public ICollection<Payment> Payments { get; set; }
    public ICollection<Card> Cards { get; set; }
    public ICollection<Patient> Patients { get; set; }
    public ICollection<Doctor> Doctors { get; set; }
    public ICollection<Nurse> Nurses { get; set; }
    public ICollection<Staff> Staffs { get; set; }
}