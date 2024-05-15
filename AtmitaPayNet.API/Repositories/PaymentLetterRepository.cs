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

        public List<PaymentLetterDTO> GetAll()
        {
            var result = _contextDb.PaymentLetters.Select(x => x.toPaymentLetterDTO()).ToList();

            return result;
        }

        public async Task<CreateRequestPaymentLetter> GetById(int id)
        {
            var paymentLetter = await _contextDb.PaymentLetters.Where(x => x.Id == id)
                .Include(x => x.OriginBank)
                .Include(x => x.DestinationBank)
                .Include(x => x.InterBank)
                .Include(x => x.Address).Select(x => new CreateRequestPaymentLetter
            {
                CP = x.Address.CP,
                DestinationAccountIBAN = x.DestinationBank.IBANBankAccount.IBANBankAccount,
                InterBankAccountIBAN = x.InterBankId != null ? x.InterBank.IBANBankAccount.IBANBankAccount : null,
                OriginAccountIBAN = x.OriginBank.IBANBankAccount.IBANBankAccount,
                DestinationBankName = x.DestinationBank.Bank.Name,
                OriginBankName = x.OriginBank.Bank.Name,
                InterBankName = x.InterBankId != null ? x.InterBank.Bank.Name : null,
                DestinationCountryBank = x.DestinationBank.CountryBankAccount,
                OriginCountryBank = x.OriginBank.CountryBankAccount,
                OriginCurrencyBank = x.OriginBank.CurrencyBankAccount,
                DestinationCurrencyBank = x.DestinationBank.CurrencyBankAccount,
                NumberStreet = x.Address.NumberStreet,
                Street = x.Address.Street,
                PayAmount = x.PaymentAmount,
                Status = x.Status,
                PDF = x.PDF
            }).FirstOrDefaultAsync();

            return paymentLetter;
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
                return new ResponseAPI<PaymentLetterDTO> { Successful = false, Message ="La cuenta de banco origen o de destino no existe" };
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

            var bankAccountNameDestination = await _contextDb.BankAccounts.Where(x => x.Id == idDestinationBankAccount).Include(x => x.Bank).Select(x => x.Bank.Name).FirstOrDefaultAsync();
            var bankAccountNameOrigin = await _contextDb.BankAccounts.Where(x => x.Id == idOriginBankAccount).Include(x => x.Bank).Select(x => x.Bank.Name).FirstOrDefaultAsync();
            var bankAccountNameInter = idInterBankAccount != 0 ? await _contextDb.BankAccounts.Where(x => x.Id == idInterBankAccount).Include(x => x.Bank).Select(x => x.Bank.Name).FirstOrDefaultAsync() : null;

            if (bankAccountNameDestination == null || bankAccountNameOrigin == null)
            {
                return new ResponseAPI<PaymentLetterDTO> { Successful = false, Message = "El Banco de origen o de destino no existe" };
            }
            else if (idInterBankAccount != 0 && bankAccountNameInter == null)
            {
                return new ResponseAPI<PaymentLetterDTO> { Successful = false, Message = "El Banco inter no existe" };
            }
            
            
            if (paymentLetter.Status == "GENERADO")
            {
                
                var pdf = _pdfRepository.GeneratePdf(paymentLetter.toPaymentLetterDTO(), bankAccountNameDestination, bankAccountNameOrigin, bankAccountNameInter);

                paymentLetter.PDF = pdf;
            }
            else
            {
                paymentLetter.PDF = null;
            }

            _contextDb.PaymentLetters.Add(paymentLetter);
            await _contextDb.SaveChangesAsync();

            return new ResponseAPI<PaymentLetterDTO> { Successful = true, Value = paymentLetter.toPaymentLetterDTO() };
        }

        public async Task<List<PaymentListAttribute>> GetAttributePayment()
        {
            var result = await _contextDb.PaymentLetters.Include(x => x.OriginBank).Include(x => x.DestinationBank).Select(x => new PaymentListAttribute
            {
                Id = x.Id,
                OriginBankName = x.OriginBank.Bank.Name,
                currency = x.OriginBank.CurrencyBankAccount,
                DestinationBankName = x.DestinationBank.Bank.Name,
                status = x.Status!,
                PayAmount = x.PaymentAmount
            }).ToListAsync();


            return result;

        }

        public async Task<ResponseAPI<PaymentLetterDTO>> Update(int id, CreateRequestPaymentLetter model)
        {
            var paymentLetter = await _contextDb.PaymentLetters.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (paymentLetter == null)
            {
                return new ResponseAPI<PaymentLetterDTO> { Successful = false, Message = "No se ha encontrado la carta de pago" };
            }

            var IBANDestination = new IBAN(model.DestinationAccountIBAN);
            var IBANInter = new IBAN(model.InterBankAccountIBAN);
            var IBANOrigin = new IBAN(model.OriginAccountIBAN);

            var idDestinationBankAccount = await _contextDb.BankAccounts.Where(x => x.IBANBankAccount == IBANDestination).Select(x => x.Id).FirstOrDefaultAsync();
            var idOriginBankAccount = await _contextDb.BankAccounts.Where(x => x.IBANBankAccount == IBANOrigin).Select(x => x.Id).FirstOrDefaultAsync();
            var idInterBankAccount = await _contextDb.BankAccounts.Where(x => x.IBANBankAccount == IBANInter).Select(x => x.Id).FirstOrDefaultAsync();

            if (idDestinationBankAccount == 0 || idOriginBankAccount == 0)
            {
                return new ResponseAPI<PaymentLetterDTO> { Successful = false, Message = "El Banco de origen o de destino no existe" };
            }

            paymentLetter.Address.CP = model.CP;
            paymentLetter.Address.NumberStreet = model.NumberStreet;
            paymentLetter.Address.Street = model.Street;
            paymentLetter.DestinationBankId = idDestinationBankAccount;
            paymentLetter.OriginBankId = idOriginBankAccount;
            paymentLetter.InterBankId = idInterBankAccount != 0 ? idInterBankAccount : null;
            paymentLetter.PaymentAmount = model.PayAmount;
            paymentLetter.Status = model.Status;

            var bankAccountNameDestination = await _contextDb.BankAccounts.Where(x => x.Id == idDestinationBankAccount).Include(x => x.Bank).Select(x => x.Bank.Name).FirstOrDefaultAsync();
            var bankAccountNameOrigin = await _contextDb.BankAccounts.Where(x => x.Id == idOriginBankAccount).Include(x => x.Bank).Select(x => x.Bank.Name).FirstOrDefaultAsync();
            var bankAccountNameInter = idInterBankAccount != 0 ? await _contextDb.BankAccounts.Where(x => x.Id == idInterBankAccount).Include(x => x.Bank).Select(x => x.Bank.Name).FirstOrDefaultAsync() : null;

            if (bankAccountNameDestination == null || bankAccountNameOrigin == null)
            {
                return new ResponseAPI<PaymentLetterDTO> { Successful = false, Message = "El Banco de origen o de destino no existe" };
            }
            else if (idInterBankAccount != 0 && bankAccountNameInter == null)
            {
                return new ResponseAPI<PaymentLetterDTO> { Successful = false, Message = "El Banco inter no existe" };
            }

            if (paymentLetter.Status == "GENERADO")
            {
                var pdf = _pdfRepository.GeneratePdf(paymentLetter.toPaymentLetterDTO(), bankAccountNameDestination, bankAccountNameOrigin, bankAccountNameInter);

                paymentLetter.PDF = pdf;
            }
            else
            {
                paymentLetter.PDF = null;
            }

            await _contextDb.SaveChangesAsync();
            return new ResponseAPI<PaymentLetterDTO> { Successful = true, Value = paymentLetter.toPaymentLetterDTO() };
        }

    }
}
