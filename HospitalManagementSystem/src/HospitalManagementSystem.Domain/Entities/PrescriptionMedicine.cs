using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Domain.Entities;

public class PrescriptionMedicine : IAuditEntity
{
    public long PrescriptionId { get; set; }
    public Prescription Prescription { get; set; }
    public long MedicineId { get; set; }
    public Medicine Medicine { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
}
