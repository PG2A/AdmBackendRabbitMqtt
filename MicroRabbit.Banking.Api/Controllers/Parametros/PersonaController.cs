using MicroRabbit.Banking.Application.Interfaces.Parametros;
using MicroRabbit.Banking.Application.Models.Parametros;
using Microsoft.AspNetCore.Cors;
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
        [EnableCors]
        [HttpPost]
        public IActionResult Post([FromBody] PersonaModel persona)
        {
            persona.TipoPeticion = "POST";
            _personaServices.Enviar(persona);
            return Ok(persona);
        }
        [HttpPost("editar")]
        public IActionResult Put([FromBody] PersonaModel persona)
        {
            persona.TipoPeticion = "PUT";
            _personaServices.Editar(persona);
            return Ok(persona);
        }
        [HttpDelete("eliminar")]
        public IActionResult Delete([FromBody] PersonaModel persona)
        {
            persona.TipoPeticion = "DELETE";
            _personaServices.Eliminar(persona);
            return Ok(persona);
        }
    }
}
