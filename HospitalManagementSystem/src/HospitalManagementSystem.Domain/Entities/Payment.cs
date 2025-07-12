using HospitalManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Domain.Entities
{
    public class Payment : IAuditEntity
    {
        public long PaymentId { get; set; } 

        public decimal PaidAmount { get; set; } 

        public PaymentStatus PaymentStatus { get; set; } 

        public PaymentMethod Method { get; set; }

        public DateTime PaidAt { get; set; }

        public long PatientId { get; set; }
        public Patient Patient { get; set; }
        public long CardId { get; set; }
        public Card Card { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
    }
}
