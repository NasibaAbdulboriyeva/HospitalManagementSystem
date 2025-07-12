namespace HospitalManagementSystem.Domain.Entities;

public class Schedule : IAuditEntity
{
    public long ScheduleId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsOnCall { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
    public long StaffId { get; set; }
    public Staff Staff { get; set; }
   

}

