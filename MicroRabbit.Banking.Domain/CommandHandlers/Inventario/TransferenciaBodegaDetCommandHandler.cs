using MediatR;
using MicroRabbit.Banking.Domain.Commands.Inventario.TransferenciaBodega;
using MicroRabbit.Banking.Domain.Events.Inventario;
using MicroRabbit.Domain.Core.Bus;


namespace MicroRabbit.Banking.Domain.CommandHandlers.Inventario
{
    public class TransferenciaBodegaDetCommandHandler : IRequestHandler<CreateTransferenciaBodegaDetCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public TransferenciaBodegaDetCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateTransferenciaBodegaDetCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new TransferenciaBodegaDetCreateEvent(request.Codigo, request.Id_producto, request.Linea, request.Marca, request.Producto, request.Caja, request.Unidad, request.Totalfun,
                request.Factor, request.CostoP, request.CostoU, request.Precio, request.Pagaiva, request.Poriva, request.Subtotal, request.Pordes, request.Descuento, request.Iva,
                request.Neto, request.Lote, request.Fechaela, request.Fechaven, request.Detalle, request.Formavta, request.Cantdevo, request.Cantconfirmada, request.Unidadestotales, request.Bodega,
                request.Bodegao));
            return Task.FromResult(true);
        }
    }
}

