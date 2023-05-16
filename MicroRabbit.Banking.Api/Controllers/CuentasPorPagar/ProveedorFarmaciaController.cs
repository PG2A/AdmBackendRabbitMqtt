using MicroRabbit.Banking.Application.Interfaces.CuentasPorPagar;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.CuentasPorPagar;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.CuentasPorPagar
{
    [Route("api/proveedorfarmacia")]
    [ApiController]
    public class ProveedorFarmaciaController : ControllerBase
    {
        private readonly IProveedorServices _services;

        public ProveedorFarmaciaController(IProveedorServices services)
        {
            _services = services;
        }
        [HttpPost]
        public IActionResult Post([FromBody] ProveedorFarmaciaModel Proveedor)
        {

            _services.Enviar(Proveedor);
            return Ok(Proveedor);
        }
    }
}
