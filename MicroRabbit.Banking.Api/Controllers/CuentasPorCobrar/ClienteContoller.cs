using MicroRabbit.Banking.Application.Interfaces.CuentasPorCobrar;
using MicroRabbit.Banking.Application.Models.CuentasPorCobrar;
using Microsoft.AspNetCore.Cors;
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
        [EnableCors]
        [HttpPost]
        public IActionResult Post([FromBody] ClienteModel cliente)
        {
            cliente.TipoPeticion = "POST";
            _clienteServices.Enviar(cliente);
            return Ok(cliente);
        }
        [EnableCors]
        [HttpPut("editar")]
        public IActionResult Put([FromBody] ClienteModel cliente)
        {
            cliente.TipoPeticion = "PUT";
            _clienteServices.Enviar(cliente);
            return Ok(cliente);
        }
    }
}
