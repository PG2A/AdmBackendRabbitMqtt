using MicroRabbit.Banking.Application.Interfaces.CuentasPorPagar;
using MicroRabbit.Banking.Application.Models.CuentasPorPagar;
using Microsoft.AspNetCore.Mvc;
using System;

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
            proveedor.TipoPeticion = "POST";
            _services.Enviar(proveedor);
            return Ok(proveedor);
        }
        [HttpPut("editar")]
        public IActionResult Put([FromBody] ProveedorFarmaciaModel proveedor)
        {
            proveedor.TipoPeticion = "PUT";
            _services.Editar(proveedor);
            return Ok(proveedor);
        }
        [HttpDelete("eliminar")]
        public IActionResult Delete([FromBody] ProveedorFarmaciaModel proveedor)
        {
            proveedor.TipoPeticion = "DELETE";
            _services.Eliminar(proveedor);
            return Ok(proveedor);
        }
    }
}
