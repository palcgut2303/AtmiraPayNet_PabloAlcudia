using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Models;
using Azure.Identity;
using System.Text.Json;

namespace AtmitaPayNet.API.Mapper
{
    public static class PaymentMapper
    {
        public static PaymentLetterDTO toPaymentLetterDTO(this PaymentLetter model)
        {

            return new PaymentLetterDTO
            {
                Address = new AddressDTO
                {
                    CP = model.Address.CP,
                    NumberStreet = model.Address.NumberStreet,
                    Street = model.Address.Street
                },
                OriginBankIBAN = model.OriginBankIBAN,
                NameBankOrigin = model.NameBankOrigin,
                CountryBankAccountOrigin = model.CountryBankAccountOrigin,
                CurrencyBankAccountOrigin = model.CurrencyBankAccountOrigin,
                DestinationBankIBAN = model.DestinationBankIBAN,
                NameBankDestination = model.NameBankDestination,
                CountryBankAccountDestination = model.CountryBankAccountDestination,
                CurrencyBankAccountDestination = model.CurrencyBankAccountDestination,
                InterBankIBAN = model.InterBankIBAN,
                NameBankInter = model.NameBankInter,

                PaymentAmount = model.PaymentAmount,
                Status = model.Status,
                Date = DateTime.Now,
                PDF = model.PDF
            };
        }
    }
}
