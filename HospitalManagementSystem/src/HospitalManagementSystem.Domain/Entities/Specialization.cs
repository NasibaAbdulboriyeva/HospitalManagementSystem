using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Domain.Entities;

public class Specialization
{
    public long SpecializationId { get; set; }
    public string Name { get; set; } 
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; } 
    public DateTime LastModifiedAt { get; set; }
}
