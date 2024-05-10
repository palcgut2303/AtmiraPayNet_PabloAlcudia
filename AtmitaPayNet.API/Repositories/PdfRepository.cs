using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Interfaces;
using AtmitaPayNet.API.Models;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.AspNetCore.Mvc;

namespace AtmitaPayNet.API.Repositories
{
    public class PdfRepository : IPDFRepository
    {
        public string GeneratePdf(PaymentLetterDTO paymentLetter)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (PdfWriter writer = new PdfWriter(ms))
                    {
                        using (PdfDocument pdfDocument = new PdfDocument(writer))
                        {
                            using (Document document = new Document(pdfDocument))
                            {
                                document.Add(new Paragraph("Payment Letter Details:"));
                                document.Add(new Paragraph($"Origin Bank ID: {paymentLetter.OriginBankId}"));
                                document.Add(new Paragraph($"Destination Bank ID: {paymentLetter.DestinationBankId}"));
                                document.Add(new Paragraph($"Inter Bank ID: {paymentLetter.InterBankId ?? 0}"));
                                document.Add(new Paragraph($"Payment Amount: {paymentLetter.PaymentAmount}"));
                                document.Add(new Paragraph($"Status: {paymentLetter.Status ?? "N/A"}"));
                                document.Add(new Paragraph($"Date: {paymentLetter.Date}"));
                                document.Add(new Paragraph("Address Details:"));
                                document.Add(new Paragraph($"CP: {paymentLetter.Address.CP}"));
                                document.Add(new Paragraph($"Street: {paymentLetter.Address.Street}"));
                                document.Add(new Paragraph($"Number: {paymentLetter.Address.NumberStreet}"));
                            }
                        }
                    }

                    //// Convertir el PDF a base64
                    string pdfBase64 = Convert.ToBase64String(ms.ToArray());

                    return pdfBase64;
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


    }
}
