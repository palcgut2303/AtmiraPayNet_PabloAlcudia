using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Contexto;
using AtmitaPayNet.API.Interfaces;
using AtmitaPayNet.API.Mapper;

namespace AtmitaPayNet.API.Repositories
{
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly ApplicationDbContext _contextDb;

        public BankAccountRepository(ApplicationDbContext contextDb)
        {
            _contextDb = contextDb;
        }

        public IEnumerable<BankAccountDTO> GetAll()
        {
            var result = _contextDb.BankAccounts.Select(x => x.toBankAccountDTO()).ToList();

            return result;
        }

        public BankAccountDTO GetById(int id)
        {
            var result = _contextDb.BankAccounts.Where(x => x.Id == id).Select(x => x.toBankAccountDTO()).FirstOrDefault();

            return result;
        }

        public async Task<ResponseAPI<BankAccountDTO>> Create(CreateRequestBankAccount bankAccountRequestDTO)
        {
            var bankAccountDTO = new BankAccountDTO
            {
                BankId = bankAccountRequestDTO.BankId,
                CountryBankAccount = bankAccountRequestDTO.CountryBankAccount,
                CurrencyBankAccount = bankAccountRequestDTO.CurrencyBankAccount,
                IBANBankAccount = new IBAN_DTO(bankAccountRequestDTO.IBANBankAccount)
            };

            var bankAccount = bankAccountDTO.toBankAccount();
            _contextDb.BankAccounts.Add(bankAccount);
           await _contextDb.SaveChangesAsync();

            return new ResponseAPI<BankAccountDTO> { EsCorrecto = true, Valor = bankAccount.toBankAccountDTO() };
        } 
        
    }
}
