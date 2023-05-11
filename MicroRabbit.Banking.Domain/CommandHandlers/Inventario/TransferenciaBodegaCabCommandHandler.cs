using MediatR;
using MicroRabbit.Banking.Domain.Commands.Inventario.TransferenciaBodega;
using MicroRabbit.Banking.Domain.Events.Inventario;
using MicroRabbit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.CommandHandlers.Inventario
{
    public class TransferenciaBodegaCabCommandHandler : IRequestHandler<CreateTransferenciaBodegaCabCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public TransferenciaBodegaCabCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateTransferenciaBodegaCabCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new TransferenciaBodegaCabCreateEvent(request.Codigo, request.Origen, request.Sucursal, request.SucursalD, request.Tipo, request.Tipoguia, request.Serie, request.Remision,
                request.Numero, request.Bodega, request.Numpedido, request.Numguia, request.Cliente, request.Fechaemi, request.Fechaven, request.Fechaent, request.Bodegadestino, request.Vendedor, 
                request.Proveedor, request.Peso, request.Volumen, request.Motivo, request.Observacion, request.Comentario, request.Seccontable, request.Estado, request.Estadodoc, request.Enviadosri,
                request.Numautorizacion, request.Codigorel, request.Fecha_ing, request.Maquina, request.Usuario, request.DireccionOrigen, request.Direcciondestino, request.Camion, request.Chofer));
            return Task.FromResult(true);
        }
    }
}
