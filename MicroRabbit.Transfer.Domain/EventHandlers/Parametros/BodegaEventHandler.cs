using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Parametros;
using MicroRabbit.Transfer.Domain.Interfaces.Parametros;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Parametros
{
    public class BodegaEventHandler : IEventHandler<BodegaCreateEvent>
    {
        private readonly IBodegaRepository _bodegaRepository;

        public BodegaEventHandler(IBodegaRepository bodegaRepository)
        {
            _bodegaRepository = bodegaRepository;
        }

        public Task Handle(BodegaCreateEvent @event)
        {
            _bodegaRepository.ObtenerRegistros();
            return Task.CompletedTask;
        }
    }
}
