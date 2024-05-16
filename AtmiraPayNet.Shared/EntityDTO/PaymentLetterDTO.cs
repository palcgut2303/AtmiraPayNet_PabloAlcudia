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

        //JSON Column Address
        public AddressDTO Address { get; set; }


        //Bank Origin
        public string OriginBankIBAN { get; set; }

        public string NameBankOrigin { get; set; }
        public string CountryBankAccountOrigin { get; set; }
        public string CurrencyBankAccountOrigin { get; set; }
        //Bank Destination
        public string DestinationBankIBAN { get; set; }
        public string NameBankDestination { get; set; }
        public string CountryBankAccountDestination { get; set; }
        public string CurrencyBankAccountDestination { get; set; }

        //Bank Inter
        public string? InterBankIBAN { get; set; }
        public string NameBankInter { get; set; }

        public int PaymentAmount { get; set; }
        public string? PDF { get; set; }
        public string? Status { get; set; }

        public DateTime? Date { get; set; }


    }
}
