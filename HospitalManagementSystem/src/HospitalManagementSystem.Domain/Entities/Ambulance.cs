using HospitalManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Domain.Entities
{
    public class Ambulance : IAuditEntity
    {
        public long AmbulanceId { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string PhoneNumber { get; set; }
        public AmbulanceStatus Status { get; set; }
        public string Location { get; set; }
        public DateTime LastServiceDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
    }



}
