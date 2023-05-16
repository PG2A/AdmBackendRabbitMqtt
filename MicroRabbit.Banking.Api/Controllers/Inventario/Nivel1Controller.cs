using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [Route("api/nivel1")]
    [ApiController]
    public class Nivel1Controller : ControllerBase
    {
        private readonly INivel1Services _services;

        public Nivel1Controller(INivel1Services services)
        {
            _services = services;
        }
        [HttpPost]
        public IActionResult Post([FromBody] Nivel1Transfer nivel1)
        {

            _services.Tranfer(nivel1);
            return Ok(nivel1);
        }
    }
}
