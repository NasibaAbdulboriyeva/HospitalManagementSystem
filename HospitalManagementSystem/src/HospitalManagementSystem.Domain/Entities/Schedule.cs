using HospitalManagementSystem.Domain.Enums;
namespace HospitalManagementSystem.Domain.Entities;

public class Schedule
{
    public long ScheduleId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsOnCall { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public long UserId { get; set; }
}

