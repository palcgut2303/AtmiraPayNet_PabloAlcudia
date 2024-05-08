using AtmitaPayNet.API.Interfaces;
using AtmitaPayNet.API.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AtmitaPayNet.API.Repositories
{
    public class PdfRepository : IPDFRepository
    {
        public void CrearPDF(PaymentLetter payment)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc,new FileStream("archivo.pdf",FileMode.Create));
            doc.Open();
            doc.Add(new Paragraph("Hola Mundo"));
            doc.Close();
        }

        
    }
}
