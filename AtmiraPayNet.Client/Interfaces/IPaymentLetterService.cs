using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;

namespace AtmiraPayNet.Client.Interfaces
{
    public interface IPaymentLetterService
    {
        Task<ResponseAPI<List<PaymentLetterDTO>>> GetPaymentLetters();
        Task<ResponseAPI<PaymentLetterDTO>> PostPaymentLetter(CreateRequestPaymentLetter model);
    }
}
