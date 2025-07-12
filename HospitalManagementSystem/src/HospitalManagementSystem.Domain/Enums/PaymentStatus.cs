using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Domain.Enums
{
    public enum PaymentStatus
    {
        Pending,    // To‘lov kutilmoqda
        Paid,       // To‘lov amalga oshirilgan
        Failed,     // To‘lov muvaffaqiyatsiz tugagan
        Refunded    // To‘lov qaytarilgan
    }

}
