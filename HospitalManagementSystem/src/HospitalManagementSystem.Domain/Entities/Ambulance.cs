using HospitalManagementSystem.Domain.Enums;
namespace HospitalManagementSystem.Domain.Entities;

public class Ambulance : IAuditEntity
{
    public long AmbulanceId { get; set; }
    public string VehicleNumber { get; set; }
    public string DriverName { get; set; }
    public string PhoneNumber { get; set; }
    public AmbulanceStatus AmbulanceStatus { get; set; }
    public string Location { get; set; }
    public DateTime LastServiceDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
    public long? HospitalId { get; set; }
    public Hospital Hospital { get; set; }
}