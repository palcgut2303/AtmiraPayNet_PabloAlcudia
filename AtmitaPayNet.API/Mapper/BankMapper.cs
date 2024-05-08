using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Models;

namespace AtmitaPayNet.API.Mapper
{
    public static class BankMapper
    {
        public static BankDTO toBankDTO(this Bank model)
        {

            return new BankDTO
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public static Bank toBanK(this BankDTO model)
        {

            return new Bank
            {
                Name = model.Name
                //BankAccounts = model.BankAccountsDTO.Select(x => x.toBankAccount()).ToList()
            };
        }
    }
}
