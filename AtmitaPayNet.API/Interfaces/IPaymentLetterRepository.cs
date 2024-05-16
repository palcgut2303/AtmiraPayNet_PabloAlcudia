using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;

namespace AtmitaPayNet.API.Interfaces
{
    public interface IPaymentLetterRepository
    {
        Task<ResponseAPI<PaymentLetterDTO>> Create(CreateRequestPaymentLetter model);
        List<PaymentLetterDTO> GetAll();
        Task<List<PaymentListAttribute>> GetAttributePayment();
        Task<string> GetBankName(string IBAN);
        Task<CreateRequestPaymentLetter> GetById(int id);
        Task<ResponseAPI<PaymentLetterDTO>> Update(int id, CreateRequestPaymentLetter model);
    }
}
