using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmiraPayNet.Shared.CreateRequest
{
    public class CreateRequestPaymentLetter
    {
        public string OriginAccountIBAN { get; set; }
        public string OriginBankName { get; set; }

        public string OriginCountryBank { get; set; }
        public string OriginCurrencyBank { get; set; }
        public string CP { get; set; }
        public string Street { get; set; }
        public int NumberStreet { get; set; }
        public int PayAmount { get; set; }

        public string? DestinationAccountIBAN { get; set; }

        public string? DestinationBankName { get; set; }

        public string? DestinationCountryBank { get; set; }
        public string? DestinationCurrencyBank { get; set; }

        public string? InterBankAccountIBAN { get; set; }

        public string? InterBankName { get; set; }

        //public string Pdf { get; set; }
        public string? Status { get; set; }


    }
}