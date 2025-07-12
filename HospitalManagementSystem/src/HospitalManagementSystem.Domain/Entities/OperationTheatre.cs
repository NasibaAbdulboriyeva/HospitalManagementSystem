using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Domain.Entities
{
    public class OperationTheatre :IAuditEntity
    {
        public long OperationTheatreId { get; set; }

        public string RoomNumber { get; set; }

        public int Floor { get; set; }

        public string EquipmentDetails { get; set; }

        public bool IsAvailable { get; set; }

        public string? Notes { get; set; }
        public long? DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<OperationTheatreStaff> OperationTheatreStaffs { get; set; }
        public ICollection<Surgery> Surgeries { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
    }
}
