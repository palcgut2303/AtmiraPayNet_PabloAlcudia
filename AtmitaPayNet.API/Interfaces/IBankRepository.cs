using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;

namespace AtmitaPayNet.API.Interfaces
{
    public interface IBankRepository
    {
        Task<ResponseAPI<BankDTO>> Create(CreateRequestBank bankRequestDTO);
        IEnumerable<BankDTO> GetAll();
        BankDTO GetById(int id);
    }
}
