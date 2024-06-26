﻿using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtmitaPayNet.API.Interfaces
{
    public interface IPDFRepository
    {
        string GeneratePdf(PaymentLetterDTO paymentLetter);
        byte[] GetPdf(int idPayment);
    }
}
