using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;

public class Appointment : IAuditEntity
{
    public long AppointmentId { get; set; }

    public DateTime ScheduledDate { get; set; }

    public string Reason { get; set; }

    public AppointmentStatus AppointmentStatus { get; set; }
    public long PatientId { get; set; }
    public Patient Patient { get; set; }

    public long DoctorId { get; set; }
    public Doctor Doctor { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}
