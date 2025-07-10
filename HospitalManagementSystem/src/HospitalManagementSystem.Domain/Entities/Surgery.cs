using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;

public class Surgery : IAuditEntity
{
    public long SurgeryId { get; set; }

    public long PatientId { get; set; }
    public Patient Patient { get; set; } = default!;

    public long DoctorId { get; set; }
    public Doctor Doctor { get; set; } = default!;

    public string SurgeryName { get; set; } = default!;

    public string Description { get; set; } = default!;

    public DateTime ScheduledDateTime { get; set; }

    public int DurationInMinutes { get; set; }

    public SurgeryStatus Status { get; set; } = SurgeryStatus.Scheduled;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastModifiedAt { get; set; }
}
