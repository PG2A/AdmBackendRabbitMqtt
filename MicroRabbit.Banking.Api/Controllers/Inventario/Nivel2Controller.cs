using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Domain.Models.Inventario;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Inventario
{
    [Route("api/nivel2")]
    [ApiController]
    public class Nivel2Controller : ControllerBase
    {
        private readonly INivel2Services _services;
        public Nivel2Controller(INivel2Services services)
        {
            _services = services;
        }

        [HttpPost]

        public IActionResult Post([FromBody] Nivel2Model nivel)
        {
            _services.Enviar(nivel);
            return Ok(nivel);

        }
    }
}
