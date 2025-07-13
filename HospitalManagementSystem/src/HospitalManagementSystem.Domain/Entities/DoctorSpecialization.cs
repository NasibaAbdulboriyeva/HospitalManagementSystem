namespace HospitalManagementSystem.Domain.Entities;

public class DoctorSpecialization : IAuditEntity
{
    public long DoctorId { get; set; }
    public long SpecializationId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}
