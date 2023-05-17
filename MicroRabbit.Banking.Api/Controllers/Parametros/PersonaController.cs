using MicroRabbit.Banking.Application.Interfaces.Parametros;
using MicroRabbit.Banking.Domain.Models.Parametros;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers.Parametros
{
    [Route("api/persona")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaServices _personaServices;

        public PersonaController(IPersonaServices personaServices)
        {
            _personaServices = personaServices;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PersonaModel cliente)
        {

            _personaServices.Enviar(cliente);
            return Ok(cliente);
        }
    }
}
