using AtmiraPayNet.Shared;
using AtmiraPayNet.Shared.CreateRequest;
using AtmiraPayNet.Shared.EntityDTO;
using AtmitaPayNet.API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtmitaPayNet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BankController : ControllerBase
    {
        private readonly IBankRepository _bankRepository;

        public BankController(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var banks = _bankRepository.GetAll();

            if (banks == null || banks.Count() == 0)
            {
                return Ok(new ResponseAPI<List<BankDTO>> { EsCorrecto = false, Mensaje = "No hay bancos disponibles" });
            }

            return Ok(new ResponseAPI<List<BankDTO>> { EsCorrecto = true, Valor = banks.ToList() });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var bank = _bankRepository.GetById(id);

            if (bank == null)
            {
                return Ok(new ResponseAPI<BankDTO> { EsCorrecto = false, Mensaje = "No se encontró el banco" });
            }

            return Ok(new ResponseAPI<BankDTO> { EsCorrecto = true, Valor = bank });
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRequestBank bankDTO)
        {
            var result = await _bankRepository.Create(bankDTO);

            if (!result.EsCorrecto)
            {
                return Ok(new ResponseAPI<BankDTO> { EsCorrecto = false, Mensaje = "No se pudo crear el banco" });
            }

            return Ok(new ResponseAPI<BankDTO> { EsCorrecto = true, Valor = result.Valor });
        }
    }
}
