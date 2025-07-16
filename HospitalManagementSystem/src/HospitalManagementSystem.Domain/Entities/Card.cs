using HospitalManagementSystem.Domain.Enums;

namespace HospitalManagementSystem.Domain.Entities;

public class Card : IAuditEntity
{
    public long CardId { get; set; }
    public string CardNumberMasked { get; set; }
    public string CardHolderName { get; set; }
    public int ExpiryMonth { get; set; }
    public int ExpiryYear { get; set; }
    public CardType CardType { get; set; }
    public bool SelectedForPayment { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }

    public ICollection<Payment> Payments { get; set; }
}
