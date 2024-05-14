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
        private readonly IPDFRepository _pdfrepository;

        public PaymentLetterController(IPaymentLetterRepository paymentLetterRepository,IPDFRepository pDFRepository)
        {
            _paymentLetterRepository = paymentLetterRepository;
            this._pdfrepository = pDFRepository;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var paymentLetter = await _paymentLetterRepository.GetById(id);

            if (paymentLetter == null)
            {
                return Ok(new ResponseAPI<CreateRequestPaymentLetter> { Successful = false, Message = "No se ha encontrado la carta de pago" });
            }

            return Ok(new ResponseAPI<CreateRequestPaymentLetter> { Successful = true, Value = paymentLetter });
        }

        [HttpGet("GetAttributePaymentLetter")]
        public async Task<IActionResult> GetAttributePaymentLetter()
        {
            var paymentLetter = await _paymentLetterRepository.GetAttributePayment();

            if(paymentLetter == null || paymentLetter.Count() == 0)
            {
                return Ok(new PaymentLetterListResultDTO { Successful = false, Message = "No hay cartas de pago disponibles" });
            }

            return Ok(paymentLetter);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CreateRequestPaymentLetter paymentLetterDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseAPI<PaymentLetterDTO> { Successful = false, Message = "Datos incorrectos" });
            }

            var result = await _paymentLetterRepository.Update(id, paymentLetterDTO);

            if (result == null)
            {
                return Ok(new ResponseAPI<PaymentLetterDTO> { Successful = false, Message = "No se pudo actualizar la carta de pago" });
            }

            return Ok(new ResponseAPI<PaymentLetterDTO> { Successful = true, Value = result.Value });
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRequestPaymentLetter paymentLetterDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(new ResponseAPI<PaymentLetterDTO> { Successful = false, Message = "Datos incorrectos" });
            }

            var result = await _paymentLetterRepository.Create(paymentLetterDTO);

            if (result == null)
            {
                return Ok(new ResponseAPI<PaymentLetterDTO> { Successful = false, Message = "No se pudo crear la carta de pago" });
            }

            return Ok(new ResponseAPI<PaymentLetterDTO> { Successful = true, Value = result.Value });
        }

        [HttpGet("GetPdf/{id}")]
        public  IActionResult GetPdf(int id)
        {
            var pdf =  _pdfrepository.GetPdf(id);

            if (pdf == null)
            {
                return Ok(new ResponseAPI<PaymentLetterDTO> { Successful = false, Message = "No se ha podido obtener el archivo PDF" });
            }

            return File(pdf, "application/pdf", "CartaDePago.pdf");
        }


    }
}
