namespace HospitalManagementSystem.Domain.Entities;

public class Schedule : IAuditEntity
{
    public long ScheduleId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsOnCall { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public long UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}

