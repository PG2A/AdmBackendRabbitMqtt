using MediatR;
using MicroRabbit.Banking.Domain.Commands.Inventario.Producto;
using MicroRabbit.Banking.Domain.Events.Inventario;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Banking.Domain.CommandHandlers.Inventario
{
    public class ProductoCommandHandler : IRequestHandler<CreateProductoCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public ProductoCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateProductoCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new ProductoCreateEvent(
                request.Codigo,
                request.Codigo_Producto,
                request.Sucursal,
                request.Codigo_Barra,
                request.Codigo_Barra2,
                request.Nombre,
                request.Nombre_Extra,
                request.Marca,
                request.Presentacion,
                request.Nivel1,
                request.Nivel2,
                request.Nivel3,
                request.Proveedor,
                request.Factor,
                request.Pagaiva,
                request.Poriva,
                request.Dispoventa,
                request.Regalo,
                request.Combo,
                request.Bien,
                request.Estado,
                request.Costou,
                request.Costop,
                request.Pvp,
                request.Principio_Activo,
                request.Laboratorio,
                request.Observacion,
                request.Fecha_Ingreso,
                request.Maquina,
                request.Usuario,
                request.Nivel1_Nombre,
                request.Nivel2_Nombre,
                request.Nivel3_Nombre,
                request.Nombremarca,
                request.Nombre_Proveedor,
                request.Nombre_Presentacion,
                request.Cuenta,
                request.Pvf,
                request.PorDes,
                request.ClaseTerapeuta,
                request.NombreClaseTerapeuta,
                request.ControlLote,
                request.SoloReceta,
                request.TraContinuo,
                request.Psicotropico,
                request.RegSanitario,
                request.Concentracion,
                request.FormaFarmaceutica,
                request.PresentacionFarmacion,
                request.StockPorBodega,
                request.Precio,
                request.StockGeneral,
                request.StockMatriz
                ));
            return Task.FromResult(true);
        }
    }
}
