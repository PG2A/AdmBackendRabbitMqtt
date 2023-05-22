using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Inventario
{
    public class MotivosInventarioEventHandler : IEventHandler<MotivosInventarioCreateEvent>
    {
        private readonly IMotivosInventarioRepository _motivosinvRepository;

        public MotivosInventarioEventHandler(IMotivosInventarioRepository motivosinvRepository)
        {
            _motivosinvRepository = motivosinvRepository;
        }

        public Task Handle(MotivosInventarioCreateEvent @event)
        {
            if (@event.TipoPeticion == "POST")
            {
                var grabar = new MotivosInventarioTabla
                {
                    Codigo = @event.Codigo,
                    Nombre = @event.Nombre,
                    Cuenta = @event.Nombre,
                    Estadistica = @event.Estadistica,
                    Sri = @event.Sri,
                    TipoDocInventario = @event.TipoDocInventario,
                    Estado = @event.Estado,
                    Fecha_ing = @event.Fecha_ing,
                    Maquina = @event.Maquina,
                    Usuario = @event.Usuario,
                };
                _motivosinvRepository.Grabar(grabar);
            }
            if (@event.TipoPeticion == "PUT")
            {
                var editar = new MotivosInventarioTabla
                {
                    Codigo = @event.Codigo,
                    Nombre = @event.Nombre,
                    Cuenta = @event.Nombre,
                    Estadistica = @event.Estadistica,
                    Sri = @event.Sri,
                    TipoDocInventario = @event.TipoDocInventario,
                    Estado = @event.Estado,
                    Fecha_ing = @event.Fecha_ing,
                    Maquina = @event.Maquina,
                    Usuario = @event.Usuario,
                };
                _motivosinvRepository.Editar(editar);
            }
            if (@event.TipoPeticion == "DELETE")
            {
                var eliminar = new MotivosInventarioTabla
                {
                    Codigo = @event.Codigo,
                    Nombre = @event.Nombre,
                    Cuenta = @event.Nombre,
                    Estadistica = @event.Estadistica,
                    Sri = @event.Sri,
                    TipoDocInventario = @event.TipoDocInventario,
                };
                _motivosinvRepository.Eliminar(eliminar);
            }
            return Task.CompletedTask;
        }
    }
}
