using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmiraPayNet.Shared.CreateRequest
{
    public class CreateRequestBankAccount
    {
        public int BankId { get; set; }
        public string CountryBankAccount { get; set; }
        public string CurrencyBankAccount { get; set; }


        //IBAN Account DTO
        public string IBANBankAccount { get; set; }
    }
}
