using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Domain.Entities
{
    public class Medicine : IAuditEntity
    {
        public long MedicineId { get; set; }
        public string Name { get; set; }
        public string? GenericName { get; set; }
        public string DosageForm { get; set; }
        public string Strength { get; set; }
        public int Quantity { get; set; }
        public DateTime ReceivedDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public long PrescriptionId { get; set; }
        public Prescription Prescription { get; set; }
        public string? Notes { get; set; }
    }

}
