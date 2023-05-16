using MicroRabbit.Banking.Domain.Commands.Inventario.Camion;
using MicroRabbit.Banking.Domain.Commands.Inventario.Chofer;
using MicroRabbit.Banking.Domain.Events.Inventario;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers.Inventario
{
    public class CamionCommandHandler
    {
        private readonly IEventBus _eventBus;

        public CamionCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateCamionCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new CamionCreateEvent(request.Codigo, request.Nombre, request.Placa, request.Volumen, request.Anio, request.Peso, request.Chofer, request.Nombrechofer, request.Nombresucursal, request.Estado, 
                request.Detalle, request.Fecha_Ingreso, request.Maquina, request.Usuario, request.Sucursal));
            return Task.FromResult(true);
        }
    }
}
