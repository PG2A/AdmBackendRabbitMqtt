using MediatR;
using MicroRabbit.Banking.Domain.Commands.Inventario.Camion;
using MicroRabbit.Banking.Domain.Commands.Parametros.Persona;
using MicroRabbit.Banking.Domain.Events.Parametros;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers.Parametros
{
    public class PersonaCommandHandler : IRequestHandler<CreatePersonaCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public PersonaCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreatePersonaCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new PersonaCreateEvent(request.Codigo, request.Codigo_Usuario, request.Tipo_persona, request.Nombre, request.Apellido, request.Cedula, request.Direccion, request.Celular,
                request.Correo, request.Observacion, request.Estado, request.ClaveMaestra, request.Usuariomaq, request.Maquina, request.Clave, request.TipoPeticion));
            return Task.FromResult(true);
        }
    }
}
