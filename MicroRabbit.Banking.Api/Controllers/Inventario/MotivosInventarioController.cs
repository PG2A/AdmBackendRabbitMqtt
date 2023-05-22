using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.Inventario;
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
        [HttpPost]
        public IActionResult Post([FromBody] MotivosInventarioModel motivosinv)
        {

            _motivosinv.Grabar(motivosinv);
            return Ok(motivosinv);
        }
        [HttpPut("editar")]
        public IActionResult Put([FromBody] MotivosInventarioModel motivosinv)
        {
            _motivosinv.Grabar(motivosinv);
            return Ok(motivosinv);
        }
        [HttpDelete("eliminar")]
        public IActionResult Delete([FromBody] MotivosInventarioModel motivosinv)
        {
            _motivosinv.Grabar(motivosinv);
            return Ok(motivosinv);
        }
    }
}
