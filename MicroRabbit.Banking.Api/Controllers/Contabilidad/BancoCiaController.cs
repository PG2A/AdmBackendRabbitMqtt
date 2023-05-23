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
        public IActionResult Post([FromBody] BancoCiaModel bancocia)
        {
            bancocia.TipoPeticion = "POST";
            _bancociaServices.Enviar(bancocia);
            return Ok(bancocia);
        }
        [HttpPut("editar")]
        public IActionResult Put([FromBody] BancoCiaModel bancocia)
        {
            bancocia.TipoPeticion = "PUT";
            _bancociaServices.Editar(bancocia);
            return Ok(bancocia);
        }
        [HttpDelete("eliminar")]
        public IActionResult Delete([FromBody] BancoCiaModel bancocia)
        {
            bancocia.TipoPeticion = "DELETE";
            _bancociaServices.Eliminar(bancocia);
            return Ok(bancocia);
        }
    }
}
