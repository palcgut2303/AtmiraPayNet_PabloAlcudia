using AtmiraPayNet.Shared;
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
                                Paragraph title = new Paragraph("PAYMENT DETAILS");
                                title.SetBold();
                                title.SetFontSize(20);
                                title.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);

                                document.Add(title);

                                Paragraph bancoOrigen = new Paragraph("BANCO ORIGEN");
                                bancoOrigen.SetBold();
                                bancoOrigen.SetFontSize(15);
                                bancoOrigen.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                                document.Add(bancoOrigen);

                                Paragraph nombreOrigen = new Paragraph($"Nombre: {paymentLetter.NameBankOrigin}");
                                document.Add(nombreOrigen);

                                Paragraph ibanOrigen = new Paragraph($"IBAN: {paymentLetter.OriginBankIBAN}");
                                document.Add(ibanOrigen);

                                Paragraph paisOrigen = new Paragraph($"País: {paymentLetter.CountryBankAccountOrigin}");
                                document.Add(paisOrigen);

                                Paragraph bancoDestino = new Paragraph("BANCO DESTINO");
                                bancoDestino.SetBold();
                                bancoDestino.SetFontSize(15);
                                bancoDestino.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                                document.Add(bancoDestino);

                                Paragraph nombreDestino = new Paragraph($"Nombre: {paymentLetter.NameBankDestination}");
                                document.Add(nombreDestino);

                                Paragraph IbanDestino = new Paragraph($"IBAN: {paymentLetter.DestinationBankIBAN}");
                                document.Add(IbanDestino);

                                Paragraph PaisDestino = new Paragraph($"País: {paymentLetter.CountryBankAccountDestination}");
                                document.Add(PaisDestino);

                                if (paymentLetter.InterBankIBAN != null)
                                {
                                    Paragraph bancoInter = new Paragraph("BANCO INTERMEDIARIO");
                                    bancoInter.SetBold();
                                    bancoInter.SetFontSize(15);
                                    bancoInter.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                                    document.Add(bancoInter);

                                    Paragraph nombreInter = new Paragraph($"Nombre: {paymentLetter.NameBankInter}");
                                    document.Add(nombreInter);

                                    Paragraph IbanInter = new Paragraph($"IBAN: {paymentLetter.InterBankIBAN}");
                                    document.Add(IbanInter);
                                }


                                Paragraph details = new Paragraph("DETAILS");
                                details.SetBold();
                                details.SetFontSize(15);
                                details.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                                document.Add(details);


                                document.Add(new Paragraph($"Payment Amount: {paymentLetter.PaymentAmount}"));
                                document.Add(new Paragraph($"Status: {paymentLetter.Status ?? "N/A"}"));
                                document.Add(new Paragraph($"Date: {paymentLetter.Date}"));

                                Paragraph AddresDetails = new Paragraph("ADDRESS DETAILS");
                                AddresDetails.SetBold();
                                AddresDetails.SetFontSize(15);
                                AddresDetails.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                                document.Add(AddresDetails);

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
