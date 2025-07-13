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



}