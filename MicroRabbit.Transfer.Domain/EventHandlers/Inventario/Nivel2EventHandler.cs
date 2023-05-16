
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Inventario
{
    public class Nivel2EventHandler : IEventHandler<Nivel2CreateEvent>
    {
        private readonly INivel2Repository _repository;
        public Nivel2EventHandler(INivel2Repository repository)
        {
            _repository = repository;
        }

        public Task Handle(Nivel2CreateEvent @event)
        {
            var grabar = new Nivel2Tabla 
            {
                Codigo = @event.Codigo,
                Nombre = @event.Nombre,
                Estado = @event.Estado,
                Nivel1 = @event.Nivel1,
                Fecha_ing = @event.Fecha_ing,
                Maquina = @event.Maquina,
                Usuario = @event.Usuario,
            };
            return Task.CompletedTask;
        }
    }
}
