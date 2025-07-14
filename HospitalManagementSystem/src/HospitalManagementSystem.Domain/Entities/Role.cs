namespace HospitalManagementSystem.Domain.Entities;

public class Role : IAuditEntity
{
    public long RoleId { get; set; }
    public string RoleName { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public long HospitalId { get; set; }
    public  Hospital Hospital { get; set; }
    public ICollection<UserRole> UserRoles { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}
