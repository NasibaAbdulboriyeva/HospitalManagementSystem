namespace HospitalManagementSystem.Domain.Entities;

public class Room : IAuditEntity
{
    public long RoomId { get; set; }

    public string RoomNumber { get; set; } 

    public int FloorNumber { get; set; }

    public int Capacity { get; set; }

    public bool IsAvailable { get; set; }
    public long AdmissionId { get; set; }
    public Admission Admission { get; set; }
    public long DepartmentId { get; set; }
    public Department Department { get; set; }
    public ICollection<Bed> Beds { get; set; }
    public DateTime CreatedAt { get; set; } 
    public DateTime? LastModifiedAt { get; set; }
}
