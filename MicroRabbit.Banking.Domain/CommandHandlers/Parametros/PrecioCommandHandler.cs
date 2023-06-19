using MediatR;
using MicroRabbit.Banking.Domain.Commands.Parametros.Precio;
using MicroRabbit.Banking.Domain.Events.Parametros;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers.Parametros
{
    public class PrecioCommandHandler : IRequestHandler<CreatePrecioCommand, bool>
    {
        private readonly IEventBus _eventBus;
        

        public PrecioCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreatePrecioCommand request, CancellationToken cancellationToken)
        {
            for (int i = 0; i < request.TodasSucursales; i++)
            {
                _eventBus.Publish(new PrecioCreateEvent(request.Codigo, request.Sucursal, request.Tipo, request.Precio, request.Producto, request.Fecha_ing, request.Maquina,
                request.Usuario, request.PorDes, request.TipoPeticion));
            }
            return Task.FromResult(true);
        }
    }
}
