using AtmiraPayNet.Shared;
using AtmitaPayNet.API.Contexto;
using AtmitaPayNet.API.Interfaces;
using AtmitaPayNet.API.Mapper;

namespace AtmitaPayNet.API.Repositories
{
    public class PaymentLetterRepository : IPaymentLetterRepository
    {

        private readonly ApplicationDbContext _contextDb;

        public PaymentLetterRepository(ApplicationDbContext contextDb)
        {
            _contextDb = contextDb;
        }

        public IEnumerable<PaymentLetterDTO> GetAll()
        {
            var result = _contextDb.PaymentLetters.Select(x => x.toPaymentLetterDTO()).ToList();

            return result;
        }
    }
}
