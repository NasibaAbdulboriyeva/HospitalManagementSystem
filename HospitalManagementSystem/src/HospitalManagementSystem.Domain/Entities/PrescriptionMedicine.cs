using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Domain.Entities;

public class PrescriptionMedicine
{
    public long PrescriptionId { get; set; }
    public Prescription Prescription { get; set; }
    public long MedicineId { get; set; }
    public Medicine Medicine { get; set; }
}
