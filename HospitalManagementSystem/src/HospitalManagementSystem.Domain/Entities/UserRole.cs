namespace HospitalManagementSystem.Domain.Entities;

public class UserRole : IAuditEntity
{
    public long UserId { get; set; }
    public User User { get; set; }
    public long RoleId { get; set; }
    public Role Role { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}