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
                Id = model.Id,
                Address = new AddressDTO
                {
                    CP = model.Address.CP,
                    NumberStreet = model.Address.NumberStreet,
                    Street = model.Address.Street
                },
                DestinationBankId = model.DestinationBankId,
                OriginBankId = model.OriginBankId,
                InterBankId = model.InterBankId,
                PaymentAmount = model.PaymentAmount,
                PDF = model.PDF,
                Date = model.Date,
                Status = model.Status
            };
        }
    }
}
