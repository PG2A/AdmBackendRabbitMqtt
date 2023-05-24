using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.Inventario;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Inventario
{
    [Route("api/motivosinv")]
    [ApiController]
    public class MotivosInventarioController : ControllerBase
    {
        private readonly IMotivosInventarioServices _motivosinv;

        public MotivosInventarioController(IMotivosInventarioServices motivosinv)
        {
            _motivosinv = motivosinv;
        }
        [EnableCors]
        [HttpPost]
        public IActionResult Post([FromBody] MotivosInventarioModel motivosinv)
        {
            motivosinv.TipoPeticion = "POST";
            _motivosinv.Grabar(motivosinv);
            return Ok(motivosinv);
        }
        [HttpPost("editar")]
        public IActionResult Put([FromBody] MotivosInventarioModel motivosinv)
        {
            motivosinv.TipoPeticion = "PUT";
            _motivosinv.Grabar(motivosinv);
            return Ok(motivosinv);
        }
        [HttpPost("eliminar")]
        public IActionResult Delete([FromBody] MotivosInventarioModel motivosinv)
        {
            motivosinv.TipoPeticion = "DELETE";
            _motivosinv.Grabar(motivosinv);
            return Ok(motivosinv);
        }
    }
}
