using MediatR;
using MicroRabbit.Banking.Domain.Commands.Inventario.Nivel2;
using MicroRabbit.Banking.Domain.Events.Inventario;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Domain.CommandHandlers.Inventario
{
    public class Nivel2CommandHandler : IRequestHandler<CreateNivel2Command, bool>
    {
        private readonly IEventBus _eventBus;

        public Nivel2CommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateNivel2Command request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new Nivel2CreateEvent(request.Codigo, request.Nombre, request.Estado, request.Nivel1, request.Nombre_nivel1, request.Fecha_ing, request.Maquina, request.Usuario, request.Sucursal));
            return Task.FromResult(true);
        }
    }
}
