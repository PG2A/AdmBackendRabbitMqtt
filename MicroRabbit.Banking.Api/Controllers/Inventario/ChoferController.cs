using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.Inventario;
using Microsoft.AspNetCore.Cors;
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
        [EnableCors]
        [HttpPost]
        public IActionResult Post([FromBody] ChoferModel chofer)
        {
            chofer.TipoPeticion = "POST";
            _services.Transfer(chofer);
            return Ok(chofer);
        }
        [HttpPost("editar")]
        public IActionResult Put([FromBody] ChoferModel chofer)
        {
            chofer.TipoPeticion = "PUT";
            _services.Editar(chofer);
            return Ok(chofer);
        }
        [HttpPost("eliminar")]
        public IActionResult Delete([FromBody] ChoferModel chofer)
        {
            chofer.TipoPeticion = "DELETE";
            _services.Eliminar(chofer);
            return Ok(chofer);
        }
    }
}
