using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Contexto;
using AtmitaPayNet.API.Interfaces;
using AtmitaPayNet.API.Models;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.AspNetCore.Mvc;

namespace AtmitaPayNet.API.Repositories
{
    public class PdfRepository : IPDFRepository
    {
        private readonly ApplicationDbContext _contextDb;

        public PdfRepository(ApplicationDbContext contextDb)
        {
            _contextDb = contextDb;
        }

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
                                document.Add(new Paragraph("Payment Letter Details"));
                                document.Add(new Paragraph($"Origin Bank Name: {paymentLetter.NameBankOrigin}"));
                                document.Add(new Paragraph($"Destination Bank Name: {paymentLetter.NameBankDestination}"));
                                document.Add(new Paragraph($"Inter Bank Name: {paymentLetter.NameBankInter ?? "No hay"}"));
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


        public byte[] GetPdf(int idPayment)
        {
            var pdf = _contextDb.PaymentLetters.Where(x => x.Id == idPayment).Select(x => x.PDF).FirstOrDefault();

            byte[] pdfBytes = Convert.FromBase64String(pdf);

            return pdfBytes;
        }

       


    }
}
