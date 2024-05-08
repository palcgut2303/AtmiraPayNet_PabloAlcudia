namespace AtmitaPayNet.API.Models
{
    public class IBAN
    {

        public IBAN(string value)
        {
            IBANBankAccount = value;
        }

        public string IBANBankAccount { get; set; }

    }
}
