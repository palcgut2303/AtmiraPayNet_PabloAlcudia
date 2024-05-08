using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtmiraPayNet.Shared.EntityDTO;

namespace AtmiraPayNet.Shared
{
    public class PaymentLetterListResultDTO
    {
        public bool Successful { get; set; }
        public string Message { get; set; }
        public IEnumerable<PaymentLetterDTO> ListPaymentLetters { get; set; }
    }
}
