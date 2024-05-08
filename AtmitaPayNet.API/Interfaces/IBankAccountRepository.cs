using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;

namespace AtmitaPayNet.API.Interfaces
{
    public interface IBankAccountRepository
    {
        Task<ResponseAPI<BankAccountDTO>> Create(CreateRequestBankAccount bankAccountRequestDTO);
        IEnumerable<BankAccountDTO> GetAll();
        BankAccountDTO GetById(int id);
    }
}
