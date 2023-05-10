using MicroRabbit.Banking.Application.Interfaces.CuentasPorCobrar;
using MicroRabbit.Banking.Application.Models.CuentasPorCobrar;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.CuentasPorCobrar
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteContoller : ControllerBase
    {
        private readonly IClienteServices _clienteServices;

        public ClienteContoller(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ClienteModel cliente)
        {

            _clienteServices.Enviar(cliente);
            return Ok(cliente);
        }
    }
}
