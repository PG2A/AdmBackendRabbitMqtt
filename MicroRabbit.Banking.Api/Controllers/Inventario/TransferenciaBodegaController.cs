﻿using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models.Inventario;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Inventario
{
    [Route("api/TranferenciaBodega")]
    [ApiController]
    public class TransferenciaBodegaController : ControllerBase
    {
        
        private readonly ITransferenciaBodegaServices _transferenciaServices;

        public TransferenciaBodegaController(ITransferenciaBodegaServices transferenciaServices)
        {
            _transferenciaServices = transferenciaServices;
        }

        [HttpPost]
        public IActionResult Post([FromBody] TransferenciaBodegaCabModel cabecera)
        {
            _transferenciaServices.EnviarCab(cabecera);
            return Ok(cabecera);
        }
    }
}
