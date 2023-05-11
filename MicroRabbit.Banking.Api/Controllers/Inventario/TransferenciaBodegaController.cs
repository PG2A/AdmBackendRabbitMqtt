using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.Inventario;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Inventario
{
    public class TransferenciaBodegaController : ControllerBase
    {
        private readonly ITransferenciaBodegaServices _transferenciaServices;

        public TransferenciaBodegaController(ITransferenciaBodegaServices transferenciaServices)
        {
            _transferenciaServices = transferenciaServices;
        }

        [HttpPost]
        public IActionResult PostCab([FromBody] TransferenciaBodegaCabModel cabecera)
        {
            _transferenciaServices.EnviarCab(cabecera);
            return Ok(cabecera);
        }
    }
}
