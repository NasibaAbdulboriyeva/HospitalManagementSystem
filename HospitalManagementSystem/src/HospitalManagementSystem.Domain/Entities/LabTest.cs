using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;

public class LabTest : IAuditEntity
{
    public long LabTestId { get; set; }
    public string TestName { get; set; }
    public string Description { get; set; }
    public DateTime TestDate { get; set; }
    public string Result { get; set; }
    public LabTestStatus Status { get; set; }
    public decimal Cost { get; set; }
    public long? PatientId { get; set; }
    public Patient Patient { get; set; }
    public long? DoctorId { get; set; }
    public Doctor Doctor { get; set; }
    public long? TreatmentPlanId { get; set; }
    public TreatmentPlan TreatmentPlan { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}
