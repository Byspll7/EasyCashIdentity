using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentity.Dto.Dtos.CustomerAccountProcessDtos
{
    public class SendMoneyForCustomerAccountProcessDto
    {
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }
        public string Description { get; set; }
        public int SenderId { get; set; }
        public string ReceiverAccountNumber { get; set; }
        public int ReceiverId { get; set; }

    }
}
