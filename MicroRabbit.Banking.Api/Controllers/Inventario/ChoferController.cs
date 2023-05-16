using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Interfaces.Inventario;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Application.Models.Inventario;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Inventario
{
    [Route("api/chofer")]
    [ApiController]
    public class ChoferController : ControllerBase
    {
        private readonly IChoferServices _services;

        public ChoferController(IChoferServices services)
        {
            _services = services;
        }
        [HttpPost]
        public IActionResult Post([FromBody] ChoferModel chofer)
        {

            _services.Transfer(chofer);
            return Ok(chofer);
        }
    }
}
