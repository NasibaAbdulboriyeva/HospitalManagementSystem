namespace HospitalManagementSystem.Domain.Entities;

public class DoctorSpecialization : IAuditEntity
{
    public Specialization Specialization { get; set; }
    public long SpecializationId { get; set; }
    public Specialization Specialization { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }

    public Doctor Doctor { get; set; }
    public long DoctorId { get; set; }
}
