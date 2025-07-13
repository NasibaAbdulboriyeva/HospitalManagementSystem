using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;
public class Salary : IAuditEntity
{
    public long SalaryId { get; set; }
    public decimal BaseAmount { get; set; }
    public decimal BonusAmount { get; set; }
    public decimal TotalAmount { get; set; }
    public Month Month { get; set; }
    public int Year { get; set; }
    public DateTime PaymentDate { get; set; }
    public Status Status { get; set; }
    public string Notes { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
    public long StaffId { get; set; }
    public Staff Staff { get; set; }
}
