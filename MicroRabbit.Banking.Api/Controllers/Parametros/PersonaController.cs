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
        public IActionResult Post([FromBody] PersonaModel persona)
        {

            _personaServices.Enviar(persona);
            return Ok(persona);
        }

        [HttpPut("editar")]
        public IActionResult Put([FromBody] PersonaModel persona)
        {
            _personaServices.Editar(persona);
            return Ok(persona);
        }
        [HttpDelete("eliminar")]
        public IActionResult Delete([FromBody] PersonaModel persona)
        {
            _personaServices.Eliminar(persona);
            return Ok(persona);
        }
    }
}
