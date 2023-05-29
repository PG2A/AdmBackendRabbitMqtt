using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Parametros;
using MicroRabbit.Transfer.Domain.Interfaces.Parametros;
using MicroRabbit.Transfer.Domain.Models.Parametros;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Parametros
{
    public class PrecioEventHandler : IEventHandler<PrecioCreateEvent>
    {
        private readonly IPrecioRepository _precioRepository;

        public PrecioEventHandler(IPrecioRepository precioRepository)
        {
            _precioRepository = precioRepository;
        }

        public Task Handle(PrecioCreateEvent @event)
        {
            if (@event.TipoPeticion == "POST")
            {
                var grabar = new PrecioTabla
                {
                    Codigo = @event.Codigo,
                    Sucursal = (int)@event.Sucursal,
                    Tipo = (int)@event.Tipo,
                    Precio = (float)@event.Precio,
                    Producto = (int)@event.Producto,
                    Fecha_ing = (DateTime)@event.Fecha_ing,
                    Maquina = @event.Maquina,
                    Usuario = (int)@event.Usuario,
                    PorDes = @event.PorDes == null ? 0 : (float)@event.PorDes,
                };
                _precioRepository.GrabarTabla(grabar);
            }
            if (@event.TipoPeticion == "PUT")
            {
                var editar = new PrecioTabla
                {
                    Codigo = @event.Codigo,
                    Sucursal = (int)@event.Sucursal,
                    Tipo = (int)@event.Tipo,
                    Precio = (float)@event.Precio,
                    Producto = (int)@event.Producto,
                    Fecha_ing = (DateTime)@event.Fecha_ing,
                    Maquina = @event.Maquina,
                    Usuario = (int)@event.Usuario,
                    PorDes = @event.PorDes == null ? 0 : (float)@event.PorDes,
                };
                _precioRepository.EditarTabla(editar);
            }
            return Task.CompletedTask;
        }
    }
}
