using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AtmitaPayNet.API.Models
{
    
    public class PaymentLetter
    {
        public int Id { get; set; }

        //JSON Column Address
        public Address Address { get; set; }

        
        //Bank Origin
        public string OriginBankIBAN { get; set; }

        public string NameBankOrigin { get; set; }
        public string CountryBankAccountOrigin{ get; set; }
        public string CurrencyBankAccountOrigin { get; set; }
        //Bank Destination
        public string DestinationBankIBAN { get; set; }
        public string NameBankDestination { get; set; }
        public string CountryBankAccountDestination { get; set; }
        public string CurrencyBankAccountDestination { get; set; }

        //Bank Inter
        public string? InterBankIBAN { get; set; }
        public string? NameBankInter { get; set; }

        public int PaymentAmount { get; set; }
        public string? PDF { get; set; }
        public string? Status { get; set; }

        public DateTime Date { get; set; }
    }
}
