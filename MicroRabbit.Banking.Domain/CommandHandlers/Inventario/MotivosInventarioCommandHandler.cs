using MediatR;
using MicroRabbit.Banking.Domain.Commands.Inventario.MotivosInventario;
using MicroRabbit.Banking.Domain.Events.Inventario;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Domain.CommandHandlers.Inventario
{
    public class MotivosInventarioCommandHandler : IRequestHandler<CreateMotivosInventarioCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public MotivosInventarioCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateMotivosInventarioCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new MotivosInventarioCreateEvent(request.Codigo, request.Nombre, request.Cuenta, request.Estadistica, request.Sri, request.TipoDocInventario, request.Estado, request.Fecha_ing, request.Maquina, request.Usuario, request.TipoPeticion));
            return Task.FromResult(true);
        }
    }
}
