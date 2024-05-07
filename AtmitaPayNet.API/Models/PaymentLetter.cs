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

        //Relationship with OriginBank
        public int OriginBankId { get; set; }
        public BankAccount? OriginBank { get; set; }

        //Relationship with DestinationBank
        public int DestinationBankId { get; set; }
        public BankAccount? DestinationBank { get; set; }

        //Relationship with DestinationBank
        public int? InterBankId { get; set; }
        public BankAccount? InterBank { get; set; }

        //Data of the Payment Letter
        public int PaymentAmount { get; set; }
        public string? PaymentCurrency { get; set; }
       
       
    }
}
