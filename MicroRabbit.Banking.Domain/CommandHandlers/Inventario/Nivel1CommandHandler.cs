using MediatR;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;


namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    public class Nivel1CommandHandler : IRequestHandler<CreateNivel1Command, bool>
    {
        private readonly IEventBus _eventBus;

        public Nivel1CommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateNivel1Command request, CancellationToken cancellationToken)
        {
           _eventBus.Publish( new Nivel1CreateEvent(request.Codigo, request.Nombre, request.Estado,request.Fecha_ing,request.Maquina, request.Usuario, request.Sucursal));
            return Task.FromResult(true);
        }
    }
}
