using AtmiraPayNet.Shared;
using AtmitaPayNet.API.Models;
using Azure.Identity;

namespace AtmitaPayNet.API.Mapper
{
    public static class PaymentMapper
    {
        public static PaymentLetterDTO toPaymentLetterDTO(this PaymentLetter model)
        {


            return new PaymentLetterDTO
            {
                Id = model.Id,
                //Hacer que la direccion sea el json que se pase al DTO
                Address = model.Address.ToString(),
                DestinationBankId = model.DestinationBankId,
                OriginBankId = model.OriginBankId,
                InterBankId = model.InterBankId,
                PaymentAmount = model.PaymentAmount,
                PaymentCurrency = model.PaymentCurrency
            };
        }
    }
}
