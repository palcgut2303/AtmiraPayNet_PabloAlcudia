using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Contexto;
using AtmitaPayNet.API.Interfaces;
using AtmitaPayNet.API.Mapper;
using AtmitaPayNet.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AtmitaPayNet.API.Repositories
{
    public class PaymentLetterRepository : IPaymentLetterRepository
    {

        private readonly ApplicationDbContext _contextDb;
        private readonly IPDFRepository _pdfRepository;

        public PaymentLetterRepository(ApplicationDbContext contextDb,IPDFRepository pdfRepository)
        {
            _contextDb = contextDb;
            this._pdfRepository = pdfRepository;
        }

        public IEnumerable<PaymentLetterDTO> GetAll()
        {
            var result = _contextDb.PaymentLetters.Select(x => x.toPaymentLetterDTO()).ToList();

            return result;
        }



        public async Task<ResponseAPI<PaymentLetterDTO>> Create(CreateRequestPaymentLetter model)
        {
            var IBANDestination = new IBAN(model.DestinationAccountIBAN);
            var IBANInter = new IBAN(model.InterBankAccountIBAN);
            var IBANOrigin = new IBAN(model.OriginAccountIBAN);

            var idDestinationBank = await _contextDb.BankAccounts.Where(x => x.IBANBankAccount == IBANDestination).Select(x => x.Id).FirstOrDefaultAsync();
            var idOriginBank = await _contextDb.BankAccounts.Where(x => x.IBANBankAccount == IBANOrigin).Select(x => x.Id).FirstOrDefaultAsync();
            var idInterBank = await _contextDb.BankAccounts.Where(x => x.IBANBankAccount == IBANInter).Select(x => x.Id).FirstOrDefaultAsync();

            var paymentLetter = new PaymentLetter
            {
                Address = new Address
                {
                    CP = model.CP,
                    NumberStreet = model.NumberStreet,
                    Street = model.Street
                },
                DestinationBankId = idDestinationBank,
                OriginBankId = idOriginBank,
                InterBankId = idInterBank != 0 ? idInterBank : null,
                PaymentAmount = model.PayAmount,
                Status = model.Status
            };


            _contextDb.PaymentLetters.Add(paymentLetter);
            await _contextDb.SaveChangesAsync();

            return new ResponseAPI<PaymentLetterDTO> { EsCorrecto = true, Valor = paymentLetter.toPaymentLetterDTO() };
        }
    }
}
