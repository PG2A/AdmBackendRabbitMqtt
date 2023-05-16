using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Inventario
{
    public class ProductoEventHandler : IEventHandler<ProductoCreateEvent>
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoEventHandler(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public Task Handle(ProductoCreateEvent @event)
        {
            var grabar = new ProductosTabla
            {
                Codigo = @event.Codigo,
                Codigo_Producto = @event.Codigo_Producto,
                Sucursal = @event.Sucursal,
                Codigo_Barra = @event.Codigo_Barra,
                Codigo_Barra2 = @event.Codigo_Barra2,
                Nombre = @event.Nombre,
                Nombre_Extra = @event.Nombre_Extra,
                Marca = @event.Marca,
                Presentacion = @event.Presentacion,
                Nivel1 = @event.Nivel1,
                Nivel2 = @event.Nivel2,
                Nivel3 = @event.Nivel3,
                Proveedor = @event.Proveedor,
                Factor = @event.Factor,
                Pagaiva = @event.Pagaiva,
                Poriva  = @event.Poriva,
                Dispoventa = @event.Dispoventa,
                Regalo = @event.Regalo,
                Combo = @event.Combo,
                Bien = @event.Bien,
                Estado = @event.Estado,
                Costou = @event.Costou,
                Costop = @event.Costop,
                Principio_Activo = @event.Principio_Activo,
                Laboratorio = @event.Laboratorio,
                Observacion = @event.Observacion,
                EsRubro = @event.EsRubro,
                Cuenta = @event.Cuenta,
                ControlLote = @event.ControlLote,
                SoloReceta = @event.SoloReceta,
                TraContinuo = @event.TraContinuo,
                Psicotropico = @event.Psicotropico,
                RegSanitario = @event.RegSanitario,
                Concentracion = @event.Concentracion,
                FormaFarmaceutica = @event.FormaFarmaceutica,
                PresentacionFarmacion = @event.PresentacionFarmacion,
                Pvf = @event.Pvf,
                PorDes = @event.PorDes,
                ClaseTerapeuta = @event.ClaseTerapeuta,
                Fecha_Ingreso = @event.Fecha_Ingreso,
                Maquina = @event.Maquina,
                Usuario = @event.Usuario,
                
            };
            _productoRepository.GrabarProducto(grabar);
            return Task.CompletedTask;
        }
    }
}
