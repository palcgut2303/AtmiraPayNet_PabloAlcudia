using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtmitaPayNet.API.Interfaces
{
    public interface IPDFRepository
    {
        string GeneratePdf(PaymentLetterDTO paymentLetter, string bankAccountNameDestination, string bankAccountNameOrigin, string bankAccountNameInter);
        byte[] GetPdf(int idPayment);
    }
}
