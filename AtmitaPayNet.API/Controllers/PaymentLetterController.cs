using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtmitaPayNet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentLetterController : ControllerBase
    {
        private readonly IPaymentLetterRepository _paymentLetterRepository;

        public PaymentLetterController(IPaymentLetterRepository paymentLetterRepository)
        {
            _paymentLetterRepository = paymentLetterRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var paymentLetter = _paymentLetterRepository.GetAll();

            if (paymentLetter == null || paymentLetter.Count() == 0)
            {
                return Ok(new PaymentLetterListResultDTO { Successful = false, Message = "No hay cartas de pago disponibles" });
            }

            return Ok(new PaymentLetterListResultDTO { Successful = true, ListPaymentLetters = paymentLetter });
        }

       

        [HttpPost]
        public async Task<IActionResult> Create(CreateRequestPaymentLetter paymentLetterDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(new ResponseAPI<PaymentLetterDTO> { Successful = false, Menssage = "Datos incorrectos" });
            }

            var result = await _paymentLetterRepository.Create(paymentLetterDTO);

            if (result == null)
            {
                return Ok(new ResponseAPI<PaymentLetterDTO> { Successful = false, Menssage = "No se pudo crear la carta de pago" });
            }

            return Ok(new ResponseAPI<PaymentLetterDTO> { Successful = true, Value = result.Value });
        }


    }
}
