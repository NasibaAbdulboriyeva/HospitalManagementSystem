namespace HospitalManagementSystem.Domain;

public interface IAuditEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}
