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
                .Select(x => new CreateRequestPaymentLetter
            {
                CP = x.Address.CP,
                DestinationAccountIBAN = x.DestinationBankIBAN,
                InterBankAccountIBAN = x.InterBankIBAN != null ? x.InterBankIBAN : null,
                OriginAccountIBAN = x.OriginBankIBAN,
                DestinationBankName = x.NameBankDestination,
                OriginBankName = x.NameBankOrigin,
                InterBankName = x.NameBankInter != null ? x.NameBankInter : null,
                DestinationCountryBank = x.CountryBankAccountDestination,
                OriginCountryBank = x.CountryBankAccountOrigin,
                OriginCurrencyBank = x.CurrencyBankAccountOrigin,
                DestinationCurrencyBank = x.CurrencyBankAccountDestination,
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
          

            var paymentLetter = new PaymentLetter
            {
                Address = new Address
                {
                    CP = model.CP,
                    NumberStreet = model.NumberStreet,
                    Street = model.Street
                },
                OriginBankIBAN = model.OriginAccountIBAN,
                NameBankOrigin = model.OriginBankName,
                CountryBankAccountOrigin = model.OriginCountryBank,
                CurrencyBankAccountOrigin = model.OriginCurrencyBank,
                DestinationBankIBAN = model.DestinationAccountIBAN,
                NameBankDestination = model.DestinationBankName,
                CountryBankAccountDestination = model.DestinationCountryBank,
                CurrencyBankAccountDestination = model.DestinationCurrencyBank,
                InterBankIBAN = model.InterBankAccountIBAN,
                NameBankInter = model.InterBankName,

                PaymentAmount = model.PayAmount,
                Status = model.Status,
                Date = DateTime.Now
            };

           
            
            if (paymentLetter.Status == "GENERADO")
            {
                
                var pdf = _pdfRepository.GeneratePdf(paymentLetter.toPaymentLetterDTO());

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
            var result = await _contextDb.PaymentLetters.Select(x => new PaymentListAttribute
            {
                Id = x.Id,
                OriginBankName = x.NameBankOrigin,
                currency = x.CurrencyBankAccountOrigin,
                DestinationBankName = x.NameBankDestination,
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


            paymentLetter.Address.CP = model.CP;
            paymentLetter.Address.NumberStreet = model.NumberStreet;
            paymentLetter.Address.Street = model.Street;
            //Destination
            paymentLetter.DestinationBankIBAN = model.DestinationAccountIBAN;
            paymentLetter.CurrencyBankAccountDestination = model.DestinationCurrencyBank;
            paymentLetter.CountryBankAccountDestination = model.DestinationCountryBank;
            paymentLetter.NameBankDestination = model.DestinationBankName;
            //Origin
            paymentLetter.OriginBankIBAN = model.OriginAccountIBAN;
            paymentLetter.CountryBankAccountOrigin = model.OriginCountryBank;
            paymentLetter.CurrencyBankAccountOrigin = model.OriginCurrencyBank;
            paymentLetter.NameBankOrigin = model.OriginBankName;
            //Inter
            paymentLetter.NameBankInter = model.InterBankName != null ? model.InterBankName : null;
            paymentLetter.InterBankIBAN = model.InterBankAccountIBAN != null ? model.InterBankAccountIBAN : null;

            paymentLetter.PaymentAmount = model.PayAmount;
            paymentLetter.Status = model.Status;

           

            if (paymentLetter.Status == "GENERADO")
            {
                var pdf = _pdfRepository.GeneratePdf(paymentLetter.toPaymentLetterDTO());

                paymentLetter.PDF = pdf;
            }
            else
            {
                paymentLetter.PDF = null;
            }

            await _contextDb.SaveChangesAsync();
            return new ResponseAPI<PaymentLetterDTO> { Successful = true, Value = paymentLetter.toPaymentLetterDTO() };
        }

        public async Task<string> GetBankName(string IBAN)
        {
           
            var bankName = await _contextDb.PaymentLetters.Where(x => x.OriginBankIBAN == IBAN).Select(x => x.NameBankOrigin).FirstOrDefaultAsync();

            return bankName;
        }

    }
}
