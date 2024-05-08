using AtmitaPayNet.API.Models;

namespace AtmitaPayNet.API.Interfaces
{
    public interface IPDFRepository
    {
        void CrearPDF(PaymentLetter payment);
    }
}
