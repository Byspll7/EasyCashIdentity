using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentity.EntityLayer.Concrete
{
    public class ElectricBill
    {
        public int ElectricBillId { get; set; }
        public string ContractNumber { get; set; }
        public string CustomerName { get; set; }
        public string PaymentPeriod { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public decimal Amount { get; set; }
        public bool PaymentStatus { get; set; }
    }
}
