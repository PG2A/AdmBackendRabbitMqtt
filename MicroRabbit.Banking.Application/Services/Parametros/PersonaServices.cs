using MediatR;
using MicroRabbit.Banking.Application.Interfaces.Parametros;
using MicroRabbit.Banking.Domain.Commands.Contabilidad.BancoCia;
using MicroRabbit.Banking.Domain.Commands.Parametros.Persona;
using MicroRabbit.Banking.Application.Models.Parametros;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Application.Services.Parametros
{
    public class PersonaServices : IPersonaServices
    {
        private readonly IEventBus _eventBus;

        public PersonaServices(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public void Enviar(PersonaModel persona)
        {
            var createPersonaCommand = new CreatePersonaCommand(persona.Codigo, persona.Codigo_Usuario, persona.Tipo_persona, persona.Nombre, persona.Apellido, persona.Cedula, persona.Direccion, persona.Celular,
                persona.Correo, persona.Observacion, persona.Estado, persona.ClaveMaestra, persona.Usuariomaq, persona.Maquina, persona.Clave, persona.TipoPeticion);
            _eventBus.SendCommand(createPersonaCommand);
        }
        public void Editar(PersonaModel persona)
        {
            var createPersonaCommand = new CreatePersonaCommand(persona.Codigo, persona.Codigo_Usuario, persona.Tipo_persona, persona.Nombre, persona.Apellido, persona.Cedula, persona.Direccion, persona.Celular,
                persona.Correo, persona.Observacion, persona.Estado, persona.ClaveMaestra, persona.Usuariomaq, persona.Maquina, persona.Clave, persona.TipoPeticion);
            _eventBus.SendCommand(createPersonaCommand);
        }

        public void Eliminar(PersonaModel persona)
        {
            var createPersonaCommand = new CreatePersonaCommand(persona.Codigo, persona.Codigo_Usuario, persona.Tipo_persona, persona.Nombre, persona.Apellido, persona.Cedula, persona.Direccion, persona.Celular,
                persona.Correo, persona.Observacion, persona.Estado, persona.ClaveMaestra, persona.Usuariomaq, persona.Maquina, persona.Clave, persona.TipoPeticion);
            _eventBus.SendCommand(createPersonaCommand);
        }
    }
}
