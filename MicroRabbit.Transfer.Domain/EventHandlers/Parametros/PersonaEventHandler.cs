using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Parametros;
using MicroRabbit.Transfer.Domain.Interfaces.Parametros;
using MicroRabbit.Transfer.Domain.Models.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Parametros
{
    public class PersonaEventHandler : IEventHandler<PersonaCreateEvent>
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaEventHandler(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public Task Handle(PersonaCreateEvent @event)
        {
            var grabar = new PersonaTabla
            {
                Codigo = @event.Codigo,
                Codigo_Usuario = @event.Codigo_Usuario,
                Tipo_persona = @event.Tipo_persona,
                Nombre = @event.Nombre,
                Apellido = @event.Apellido,
                Cedula = @event.Cedula,
                Direccion = @event.Direccion,
                Celular = @event.Celular,
                Correo = @event.Correo,
                Observacion = @event.Observacion,
                Estado = @event.Estado,
                ClaveMaestra = @event.ClaveMaestra,
                Clave = @event.Clave,
            };
            _personaRepository.Grabar(grabar);
            return Task.CompletedTask;
        }
    }
}
