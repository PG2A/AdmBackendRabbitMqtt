using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models;


namespace MicroRabbit.Transfer.Domain.EventHandlers.Inventario
{
    public class Nivel1EventHandler : IEventHandler<Nivel1CreateEvent>
    {
        private readonly INivelRepository _nivelRepository;

        public Nivel1EventHandler(INivelRepository nivelRepository)
        {
            _nivelRepository = nivelRepository;
        }

        public Task Handle(Nivel1CreateEvent @event)
        {
            var grabar = new Nivel1Tabla
            {
                Codigo = @event.Codigo,
                Nombre = @event.Nombre,
                Estado = @event.Estado,
                Fecha_ing = @event.Fecha_ing,
                Maquina = @event.Maquina,
                Usuario = @event.Usuario,

            };
            _nivelRepository.AddNivel1(grabar);
            return Task.CompletedTask;
        }
    }
}
