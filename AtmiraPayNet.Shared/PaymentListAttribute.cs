using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmiraPayNet.Shared
{
    public class PaymentListAttribute
    {

        public int Id { get; set; }
        public string OriginBankName { get; set; }
        public string DestinationBankName { get; set; }

        public int PayAmount { get; set; }

        public string? currency { get; set; }

        public string status { get; set; }

    }
}
