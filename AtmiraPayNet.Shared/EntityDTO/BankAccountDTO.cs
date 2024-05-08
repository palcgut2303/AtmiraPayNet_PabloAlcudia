using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmiraPayNet.Shared.EntityDTO
{
    public class BankAccountDTO
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public BankDTO? Bank { get; set; }
        public string CountryBankAccount { get; set; }
        public string CurrencyBankAccount { get; set; }


        //List of the Payment Letters DTO
        public List<PaymentLetterDTO>? OriginPayment { get; set; }
        public List<PaymentLetterDTO>? DestinationPayment { get; set; }
        public List<PaymentLetterDTO>? InterPayment { get; set; }

        //IBAN Account DTO
        public IBAN_DTO IBANBankAccount { get; set; }
    }
}
