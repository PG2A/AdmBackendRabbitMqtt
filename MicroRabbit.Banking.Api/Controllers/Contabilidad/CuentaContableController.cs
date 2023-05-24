using MicroRabbit.Banking.Application.Interfaces.Contabilidad;
using MicroRabbit.Banking.Application.Models.Contabilidad;
using MicroRabbit.Banking.Application.Services.Contabilidad;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Contabilidad
{
    [Route("api/cuentacontable")]
    [ApiController]
    public class CuentaContableController : ControllerBase
    {
        private readonly ICuentaContableServices _cuentacontableServices;

        public CuentaContableController(ICuentaContableServices cuentacontableServices)
        {
            _cuentacontableServices = cuentacontableServices;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CuentaContableModel bancocia)
        {
            bancocia.TipoPeticion = "POST";
            _cuentacontableServices.Enviar(bancocia);
            return Ok(bancocia);
        }
        [HttpPost("editar")]
        public IActionResult Put([FromBody] CuentaContableModel bancocia)
        {
            bancocia.TipoPeticion = "PUT";
            _cuentacontableServices.Enviar(bancocia);
            return Ok(bancocia);
        }
        [HttpPost("eliminar")]
        public IActionResult Delete([FromBody] CuentaContableModel bancocia)
        {
            bancocia.TipoPeticion = "DELETE";
            _cuentacontableServices.Enviar(bancocia);
            return Ok(bancocia);
        }
    }
}
