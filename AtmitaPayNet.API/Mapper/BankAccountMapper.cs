using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Models;

namespace AtmitaPayNet.API.Mapper
{
    public static class BankAccountMapper
    {
        public static BankAccountDTO toBankAccountDTO(this BankAccount model)
        {

            return new BankAccountDTO
            {
               Id = model.Id,
               BankId = model.BankId,
               CountryBankAccount = model.CountryBankAccount,
               CurrencyBankAccount = model.CurrencyBankAccount,
               IBANBankAccount = new IBAN_DTO(model.IBANBankAccount.IBANBankAccount)
            };
        }

        public static BankAccount toBankAccount(this BankAccountDTO model)
        {

            return new BankAccount
            {
                BankId = model.BankId,
                CountryBankAccount = model.CountryBankAccount,
                CurrencyBankAccount = model.CurrencyBankAccount,
                IBANBankAccount = new IBAN(model.IBANBankAccount.IBANBankAccount)
            };
        }
    }
}
