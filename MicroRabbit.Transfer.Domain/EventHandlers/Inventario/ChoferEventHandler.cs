using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Transfer.Domain.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Inventario
{
    public class ChoferEventHandler : IEventHandler<ChoferCreateEvent>
    {
        private readonly IChoferRepository _choferRepository;

        public ChoferEventHandler(IChoferRepository ChoferRepository)
        {
            _choferRepository = ChoferRepository;
        }

        public Task Handle(ChoferCreateEvent @event)
        {
            var grabar = new ChoferTabla
            {
                Codigo = @event.Codigo,
                Nombre = @event.Nombre,
                Cedula = @event.Cedula,
                Direccion = @event.Direccion,
                Celular = @event.Celular,
                Observacion = @event.Observacion,
                Estado = @event.Estado,
                Fecha_Ingreso = @event.Fecha_Ingreso,
                Maquina = @event.Maquina,
                Usuario = @event.Usuario,

            };
            _choferRepository.Grabar(grabar);
            return Task.CompletedTask;
        }
    }
}
