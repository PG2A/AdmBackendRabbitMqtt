using MediatR;
using MicroRabbit.Banking.Domain.Commands.Inventario.Nivel3;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Banking.Domain.Events.Inventario;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Domain.CommandHandlers.Inventario
{
    public class Nivel3CommandHandler : IRequestHandler<CreateNivel3Command, bool>
    {
        private readonly IEventBus _eventBus;
        public Nivel3CommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateNivel3Command request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new Nivel3CreateEvent( request.Codigo, request.Nombre, request.Estado, request.Nivel1, request.Nivel2, request.Fecha_ing, request.Maquina, request.Usuario, request.Sucursal)
                
                );
            return Task.FromResult(true);
        }
    }
}
