namespace HospitalManagementSystem.Domain.Entities;

public class Bed : IAuditEntity
{
    public long BedId { get; set; }
    public string BedNumber { get; set; }
    public bool IsOccupied { get; set; }
    public long RoomId { get; set; }
    public Room Room { get; set; }
    public Admission Admissions { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}
