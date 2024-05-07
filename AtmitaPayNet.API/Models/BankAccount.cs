namespace AtmitaPayNet.API.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int BankId { get; set; }
        public Bank? Bank { get; set; }
        public string CountryBankAccount { get; set; }
        public string CurrencyBankAccount { get; set; }


        //List of the Payment Letters
        public List<PaymentLetter> OriginPayment { get; set; }
        public List<PaymentLetter> DestinationPayment { get; set; }
        public List<PaymentLetter> InterPayment { get; set; }

        //IBAN Account
        public IBAN IBANBankAccount { get; set; }

    }
}
