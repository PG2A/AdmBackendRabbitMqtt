using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.Inventario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Inventario
{
    [Route("api/producto")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoServices _services;

        public ProductoController(IProductoServices services)
        {
            _services = services;
        }

        [HttpPost]

        public IActionResult Post([FromBody] ProductoModel model)
        {
            _services.Enviar(model);
            return Ok(model);
        }

    }
}
