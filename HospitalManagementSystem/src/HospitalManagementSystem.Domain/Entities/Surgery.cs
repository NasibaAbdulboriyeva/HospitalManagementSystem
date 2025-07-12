using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;

public class Surgery : IAuditEntity
{
    public long SurgeryId { get; set; }

    public long PatientId { get; set; }
    public Patient Patient { get; set; }

    public long DoctorId { get; set; }
    public Doctor Doctor { get; set; }
    public string SurgeryName { get; set; }

    public string Description { get; set; }

    public DateTime ScheduledDateTime { get; set; }

    public int DurationInMinutes { get; set; }

    public SurgeryStatus Status { get; set; }
    public long? TreatmentPlanId { get; set; }
    public TreatmentPlan TreatmentPlan { get; set; }
    public long? OperationTheatreId { get; set; }
    public OperationTheatre OperationTheatre { get; set; }
    public long? OperationScheduleId { get; set; }
    public OperationSchedule OperationSchedule { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? LastModifiedAt { get; set; }
}
