using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Inventario
{
    public class ProductoBodegaEventHandler : IEventHandler<ProductoBodegaCreateEvent>
    {
        private readonly IProductoBodegaRepository _productobodegaRepository;

        public ProductoBodegaEventHandler(IProductoBodegaRepository productobodegaRepository)
        {
            _productobodegaRepository = productobodegaRepository;
        }

        public Task Handle(ProductoBodegaCreateEvent @event)
        {
            if (@event.TipoPeticion == "POST")
            {
                var grabar = new InvProductoBodegaTabla
                {
                    Bodega = @event.Bodega,
                    Producto = @event.Producto,
                    Stock = @event.Stock,
                    StockReservado = @event.StockReservado,
                    Fecha_Ult_Ing = @event.Fecha_Ult_Ing,
                    Fecha_Ult_Egr = @event.Fecha_Ult_Egr,
                    Lote = @event.Lote,
                    Fecha_Ven = @event.Fecha_Ven,
                    Fecha_Ela = @event.Fecha_Ela,
                };
                _productobodegaRepository.Grabar(grabar);
            }
            return Task.CompletedTask;
        }
    }
}
