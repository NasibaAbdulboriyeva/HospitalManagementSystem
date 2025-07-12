using HospitalManagementSystem.Domain.Enums;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Domain.Entities
{
    public class OperationSchedule :IAuditEntity
    {
        public long OperationScheduleId { get; set; } 

        public DateTime ScheduledStartTime { get; set; }

        public DateTime ScheduledEndTime { get; set; }

        public OperationScheduleStatus Status { get; set; }
        public long? OperationTheatreId { get; set; } 
        public OperationTheatre OperationTheatre { get; set; }
        public ICollection<Surgery> Surgeries { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
    }
}
