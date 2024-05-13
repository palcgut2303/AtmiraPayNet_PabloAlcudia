using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;

namespace AtmiraPayNet.Client.Interfaces
{
    public interface IPaymentLetterService
    {
        Task<ResponseAPI<List<PaymentListAttribute>>> GetAttributePayment();
        Task<ResponseAPI<CreateRequestPaymentLetter>> GetPaymentLetterById(int id);
        Task<ResponseAPI<PaymentLetterDTO>> PostPaymentLetter(CreateRequestPaymentLetter model);
        Task<ResponseAPI<PaymentLetterDTO>> PutPaymentLetter(CreateRequestPaymentLetter model, int id);
    }
}
