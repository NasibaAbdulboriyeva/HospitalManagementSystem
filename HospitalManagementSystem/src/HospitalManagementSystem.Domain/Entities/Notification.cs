using HospitalManagementSystem.Domain.Enums;


namespace HospitalManagementSystem.Domain.Entities
{
    public class Notification : IAuditEntity
    {
        public long NotificationId { get; set; } 

        public string Title { get; set; } 

        public string Message { get; set; } 

        public bool IsRead { get; set; }

        public DateTime SentDate { get; set; } 

        public NotificationType Type { get; set; }
        public DateTime CreatedAt { get ; set; }
        public DateTime? LastModifiedAt { get; set ; }
    }
}
