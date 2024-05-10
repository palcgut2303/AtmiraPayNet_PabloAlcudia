using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Contexto;
using AtmitaPayNet.API.Interfaces;
using AtmitaPayNet.API.Mapper;
using Microsoft.AspNetCore.Mvc;

namespace AtmitaPayNet.API.Repositories
{
    public class BankRepository : IBankRepository
    {
        private readonly ApplicationDbContext _contextDb;

        public BankRepository(ApplicationDbContext contextDb)
        {
            _contextDb = contextDb;
        }

        public IEnumerable<BankDTO> GetAll()
        {
            var result = _contextDb.Banks.Select(x => x.toBankDTO()).ToList();

            return result;
        }
        
        public BankDTO GetById(int id)
        {
            var result = _contextDb.Banks.Where(x => x.Id == id).Select(x => x.toBankDTO()).FirstOrDefault();

            return result;
        }
       
        public async Task<ResponseAPI<BankDTO>>Create(CreateRequestBank bankRequestDTO)
        {
            var bankDTO = new BankDTO
            {
                Name = bankRequestDTO.Name
            };

            var bank = bankDTO.toBanK();
            _contextDb.Banks.Add(bank);
            await _contextDb.SaveChangesAsync();

            return new ResponseAPI<BankDTO> { Successful = true, Value = bank.toBankDTO() };
        }
    }
}
