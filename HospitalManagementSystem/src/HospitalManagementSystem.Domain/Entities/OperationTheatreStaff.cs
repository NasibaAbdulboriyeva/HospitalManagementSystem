using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Domain.Entities
{
    public class OperationTheatreStaff
    {
        public long OperationTheatreId { get; set; }
        public OperationTheatre OperationTheatre { get; set; }

        public long StaffId { get; set; }
        public Staff Staff { get; set; }
    }
    }
