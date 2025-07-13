using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Domain.Entities
{
    public class Bed : IAuditEntity
    {
        public long BedId { get; set; } 
        public string BedNumber { get; set; }
        public bool IsOccupied { get; set; }
        public long RoomId { get; set; }
        public Room Room { get; set; }
        public ICollection<Admission> Admissions { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
    }

}
