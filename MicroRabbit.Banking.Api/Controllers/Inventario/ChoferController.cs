using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Application.Models.Inventario;
using MicroRabbit.Banking.Domain.Models.Parametros;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Inventario
{
    [Route("api/chofer")]
    [ApiController]
    public class ChoferController : ControllerBase
    {
        private readonly IChoferServices _services;

        public ChoferController(IChoferServices services)
        {
            _services = services;
        }
        [HttpPost]
        public IActionResult Post([FromBody] ChoferModel chofer)
        {
            _services.Transfer(chofer);
            return Ok(chofer);
        }
        [HttpPut("editar")]
        public IActionResult Put([FromBody] ChoferModel chofer)
        {
            _services.Editar(chofer);
            return Ok(chofer);
        }
        [HttpDelete("eliminar")]
        public IActionResult Delete([FromBody] ChoferModel chofer)
        {
            _services.Eliminar(chofer);
            return Ok(chofer);
        }
    }
}
