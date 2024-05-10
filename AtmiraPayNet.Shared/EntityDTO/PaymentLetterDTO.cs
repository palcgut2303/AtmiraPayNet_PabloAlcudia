using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace AtmiraPayNet.Shared.EntityDTO
{
    public class PaymentLetterDTO
    {
        public int Id { get; set; }
        public AddressDTO Address { get; set; }

        //Relationship with OriginBank
        public int OriginBankId { get; set; }
        public BankAccountDTO? OriginBank { get; set; }

        //Relationship with DestinationBank
        public int DestinationBankId { get; set; }
        public BankAccountDTO? DestinationBank { get; set; }

        //Relationship with DestinationBank
        public int? InterBankId { get; set; }
        public BankAccountDTO? InterBank { get; set; }

        //Data of the Payment Letter
        public int PaymentAmount { get; set; }

        public string? Status { get; set; }

        public DateTime? Date { get; set; }

        public string? PDF { get; set; }
    }
}
