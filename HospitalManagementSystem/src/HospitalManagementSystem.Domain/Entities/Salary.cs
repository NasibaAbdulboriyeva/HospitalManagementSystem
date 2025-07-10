using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;
public class Salary
{
    public long SalaryId { get; set; }
    public decimal BaseAmount { get; set; }
    public decimal BonusAmount { get; set; }
    public decimal TotalAmount { get; set; }
    public Month Month { get; set; }
    public int Year { get; set; }
    public DateTime PaymentDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public Status Status { get; set; }
    public string Notes { get; set; } 

    public long UserId { get; set; }
    public User User { get; set; }
}
