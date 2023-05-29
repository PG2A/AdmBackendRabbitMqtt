using MicroRabbit.Banking.Application.Interfaces.Parametros;
using MicroRabbit.Banking.Application.Models.Parametros;
using MicroRabbit.Banking.Application.Services.Parametros;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Parametros
{
    [Route("api/precio")]
    [ApiController]
    public class PrecioController : ControllerBase
    {
        private readonly IPrecioServices _precioServices;

        public PrecioController(IPrecioServices precioServices)
        {
            _precioServices = precioServices;
        }
        [EnableCors]
        [HttpPost]
        public IActionResult Post([FromBody] List<PrecioModel> precios)
        {
            foreach (var precio in precios)
            {
                precio.TipoPeticion = "POST";
                _precioServices.Enviar(precio);
            }
            return Ok(precios);
        }
        [HttpPost("editar")]
        public IActionResult Put([FromBody] PrecioModel precio)
        {
            precio.TipoPeticion = "PUT";
            _precioServices.Enviar(precio);
            return Ok(precio);
        }
    }
}
