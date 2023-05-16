using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Domain.Models.Inventario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Inventario
{
    [Route("api/nivel3")]
    [ApiController]
    public class Nivel3Controller : ControllerBase
    {
        private readonly INivel3Services _services;

        public Nivel3Controller(INivel3Services services)
        {
            _services = services;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Nivel3Model nivel)
        {
            _services.Enviar(nivel);
            return Ok(nivel);
        }
    }
}
