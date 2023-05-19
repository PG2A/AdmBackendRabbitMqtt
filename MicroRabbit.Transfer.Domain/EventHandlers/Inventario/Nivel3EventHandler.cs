using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Inventario
{
    public class Nivel3EventHandler : IEventHandler<Nivel3CreateEvent>
    {
        private readonly INivel3Repository _nivel;

        public Nivel3EventHandler(INivel3Repository nivel)
        {
            _nivel = nivel;
        }

        public Task Handle(Nivel3CreateEvent @event)
        {
            var grabar = new Nivel3Tabla
            {
                Codigo = @event.Codigo,
                Nombre = @event.Nombre,
                Estado = @event.Estado,
                Nivel1 = @event.Nivel1,
                Nivel2 = @event.Nivel2,
                Fecha_ing = @event.Fecha_ing,
                Maquina = @event.Maquina,
                Usuario = @event.Usuario,

            };
            _nivel.Grabar(grabar);
            return Task.CompletedTask;
        }
    }
}
