using MicroRabbit.Banking.Application.Interfaces.Contabilidad;
using MicroRabbit.Banking.Application.Models.Contabilidad;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Contabilidad
{
    [Route("api/bancocia")]
    [ApiController]
    public class BancoCiaController : ControllerBase
    {
        private readonly IBancoCiaServices _bancociaServices;

        public BancoCiaController(IBancoCiaServices bancociaServices)
        {
            _bancociaServices = bancociaServices;
        }
        [HttpPost]
        public IActionResult Post([FromBody] BancoCiaModel cliente)
        {
            _bancociaServices.Enviar(cliente);
            return Ok(cliente);
        }
    }
}
