using MicroRabbit.Banking.Application.Interfaces.CuentasPorPagar;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.CuentasPorPagar;
using MicroRabbit.Banking.Domain.Models.Parametros;
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
        public IActionResult Post([FromBody] ProveedorFarmaciaModel proveedor)
        {

            _services.Enviar(proveedor);
            return Ok(proveedor);
        }
        [HttpPut("editar")]
        public IActionResult Put([FromBody] ProveedorFarmaciaModel proveedor)
        {
            _services.Editar(proveedor);
            return Ok(proveedor);
        }
        [HttpDelete("eliminar")]
        public IActionResult Delete([FromBody] ProveedorFarmaciaModel proveedor)
        {
            _services.Eliminar(proveedor);
            return Ok(proveedor);
        }
    }
}
