using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Domain.Models.Inventario;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Inventario
{
    [Route("api/ajusteingreso")]
    [ApiController]
    public class AjusteIngresoController : ControllerBase
    {
        private readonly IAjusteIngresoServices _services;

        public AjusteIngresoController(IAjusteIngresoServices services)
        {
            _services = services;
        }

        [EnableCors]
        [HttpPost]
        public IActionResult Post([FromBody] AjusteIngresoModel model)
        {
            _services.Enviar(model);
            return Ok(model);
        }
    }
}
