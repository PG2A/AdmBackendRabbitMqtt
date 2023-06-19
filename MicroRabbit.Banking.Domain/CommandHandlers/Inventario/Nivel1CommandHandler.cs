using MediatR;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Events;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;


namespace MicroRabbit.Banking.Domain.CommandHandlers
{
    public class Nivel1CommandHandler : IRequestHandler<CreateNivel1Command, bool>
    {
        private readonly IEventBus _eventBus;
        private  ISucursalRepository _sucursalRepository;
        public Nivel1CommandHandler(IEventBus eventBus, ISucursalRepository sucursalRepository)
        {
            _eventBus = eventBus;
            _sucursalRepository = sucursalRepository;
            //      _sucursalRepository = sucursalRepository;

        private readonly IEventBus _eventBus; 
        private ISucursalRepository _sucursalRepository;

        public Nivel1CommandHandler(IEventBus eventBus, ISucursalRepository sucursalRepository)
        {
            _eventBus = eventBus; 
            _sucursalRepository = sucursalRepository;

        }

        public Task<bool> Handle(CreateNivel1Command request, CancellationToken cancellationToken)
        {


            dynamic sucursales = _sucursalRepository.Listar();

            for (int i = 0; i < sucursales.length; i++)
            {
                _eventBus.Publish(new Nivel1CreateEvent(request.Codigo, request.Nombre, request.Estado, request.Fecha_ing, request.Maquina, request.Usuario, request.Sucursal));
            }
            return Task.FromResult(true);
        }
    }
}
