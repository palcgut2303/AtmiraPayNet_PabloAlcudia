using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;

namespace AtmitaPayNet.API.Interfaces
{
    public interface IPaymentLetterRepository
    {
        Task<ResponseAPI<PaymentLetterDTO>> Create(CreateRequestPaymentLetter model);
        IEnumerable<PaymentLetterDTO> GetAll();
    }
}
