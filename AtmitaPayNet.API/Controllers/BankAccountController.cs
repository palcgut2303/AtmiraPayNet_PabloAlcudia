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
    public class BankAccountController : ControllerBase
    {

        private readonly IBankAccountRepository _bankAccountRepository;

        public BankAccountController(IBankAccountRepository bankAccountRepository)
        {
            _bankAccountRepository = bankAccountRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var bankAccounts = _bankAccountRepository.GetAll();

            if (bankAccounts == null || bankAccounts.Count() == 0)
            {
                return Ok(new ResponseAPI<List<BankAccountDTO>> { Successful = false, Menssage = "No hay cuentas bancarias disponibles" });
            }

            return Ok(new ResponseAPI<List<BankAccountDTO>> { Successful = true, Value = bankAccounts.ToList() });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var bankAccount = _bankAccountRepository.GetById(id);

            if (bankAccount == null)
            {
                return Ok(new ResponseAPI<BankAccountDTO> { Successful = false, Menssage = "No se encontró la cuenta bancaria" });
            }

            return Ok(new ResponseAPI<BankAccountDTO> { Successful = true, Value = bankAccount });
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRequestBankAccount bankAccountDTO)
        {
            var result = await _bankAccountRepository.Create(bankAccountDTO);

            if (result == null)
            {
                return Ok(new ResponseAPI<BankAccountDTO> { Successful = false, Menssage = "No se pudo crear la cuenta bancaria" });
            }

            return Ok(new ResponseAPI<BankAccountDTO> { Successful = true, Value = result.Value });
        }

    }
}
