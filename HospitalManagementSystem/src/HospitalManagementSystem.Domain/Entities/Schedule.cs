namespace HospitalManagementSystem.Domain.Entities;

public class Schedule
{
    public long ScheduleId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsOnCall { get; set; }
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public long UserId { get; set; }
}
