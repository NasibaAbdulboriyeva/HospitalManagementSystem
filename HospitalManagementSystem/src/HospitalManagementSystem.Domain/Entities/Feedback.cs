namespace HospitalManagementSystem.Domain.Entities
{
    public class Feedback : IAuditEntity
    {
        public long FeedbackId { get; set; }

        public long PatientId { get; set; }

        public string Message { get; set; }

        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
    }
}
