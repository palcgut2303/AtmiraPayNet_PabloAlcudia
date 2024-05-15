using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmiraPayNet.Shared
{
    public class PaymentAttributeListDTO
    {
        public bool Successful { get; set; }
        public string Message { get; set; }
        public IEnumerable<PaymentListAttribute> ListPaymentAttributes { get; set; }
    }
}
