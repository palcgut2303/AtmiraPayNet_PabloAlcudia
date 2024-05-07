using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace AtmiraPayNet.Shared
{
    public class PaymentLetterDTO
    {
        public int Id { get; set; }
        public string Address { get; set; }

        //Relationship with OriginBank
        public int OriginBankId { get; set; }

        //Relationship with DestinationBank
        public int DestinationBankId { get; set; }

        //Relationship with DestinationBank
        public int? InterBankId { get; set; }

        //Data of the Payment Letter
        public int PaymentAmount { get; set; }
        public string? PaymentCurrency { get; set; }

    }
}
