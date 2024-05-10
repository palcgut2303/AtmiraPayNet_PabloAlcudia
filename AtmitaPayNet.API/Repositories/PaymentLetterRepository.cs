using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Contexto;
using AtmitaPayNet.API.Interfaces;
using AtmitaPayNet.API.Mapper;
using AtmitaPayNet.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AtmitaPayNet.API.Repositories
{
    public class PaymentLetterRepository : IPaymentLetterRepository
    {

        private readonly ApplicationDbContext _contextDb;
        private readonly IPDFRepository _pdfRepository;

        public PaymentLetterRepository(ApplicationDbContext contextDb, IPDFRepository pdfRepository)
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

            var idDestinationBankAccount = await _contextDb.BankAccounts.Where(x => x.IBANBankAccount == IBANDestination).Select(x => x.Id).FirstOrDefaultAsync();
            var idOriginBankAccount = await _contextDb.BankAccounts.Where(x => x.IBANBankAccount == IBANOrigin).Select(x => x.Id).FirstOrDefaultAsync();
            var idInterBankAccount = await _contextDb.BankAccounts.Where(x => x.IBANBankAccount == IBANInter).Select(x => x.Id).FirstOrDefaultAsync();

            if (idDestinationBankAccount == 0 || idOriginBankAccount == 0)
            {
                return new ResponseAPI<PaymentLetterDTO> { Successful = false, Menssage = "El Banco de origen o de destino no existe" };
            }

            var paymentLetter = new PaymentLetter
            {
                Address = new Address
                {
                    CP = model.CP,
                    NumberStreet = model.NumberStreet,
                    Street = model.Street
                },
                DestinationBankId = idDestinationBankAccount,
                OriginBankId = idOriginBankAccount,
                InterBankId = idInterBankAccount != 0 ? idInterBankAccount : null,
                PaymentAmount = model.PayAmount,
                Status = model.Status,
                Date = DateTime.Now
            };


            //Generar PDF
            var pdf = _pdfRepository.GeneratePdf(paymentLetter.toPaymentLetterDTO());

            paymentLetter.PDF = pdf;

            _contextDb.PaymentLetters.Add(paymentLetter);
            await _contextDb.SaveChangesAsync();

            return new ResponseAPI<PaymentLetterDTO> { Successful = true, Value = paymentLetter.toPaymentLetterDTO() };
        }
    }
}
