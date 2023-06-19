using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;
using System.Configuration;





namespace MicroRabbit.Transfer.Domain.EventHandlers.Inventario
{
    public class AjusteIngresoEventHandler : IEventHandler<AjusteIngresoCreateEvent>
    {
      //  private IConfiguration
        private readonly IAjusteIngresoRepository _repository;

        public AjusteIngresoEventHandler(IAjusteIngresoRepository repository)
        {
            _repository = repository;
        }

        public Task Handle(AjusteIngresoCreateEvent @event)
        {
            string valor = ConfigurationManager.AppSettings["Sucursal"];
            Console.WriteLine(valor);
            

            var grabarCabecera = new VenCabingresoTabla {
                Codigo = @event.Codigo,
                Sucursal = @event.Sucursal,
                Tipo = @event.Tipo,
                Serie = @event.Serie,
                Numero = (int)@event.Numero,
                Bodega = @event.Bodega,
                Cliente = @event.Cliente,
                Fechaemi = @event.Fechaemi,
                Fechaent = @event.Fechaent,
                Bodegaorigen = @event.Bodegaorigen,
                Vendedor = @event.Vendedor,
                Proveedor = @event.Proveedor,
                Peso = @event.Peso,
                Volumen = @event.Volumen,
                Motivo = @event.Motivo,
                Observacion = @event.Observacion,
                Comentario = @event.Comentario,
                Seccontable = @event.Seccontable,
                Estado = @event.Estado,
                Estadodoc = @event.Estadodoc,
                Codigorel = @event.Codigorel,
                Enviadosri = @event.Enviadosri == 1 ? true : false,
                Numautorizacion = "",
                ClaseAjuste = @event.ClaseAjuste,
                NumeroApertura = 0,
                Usuario = @event.Usuario,
                Fecha_ing = (DateTime)@event.Fecha_ing,
                Maquina = @event.Maquina
            };
            _repository.Grabar(grabarCabecera);
            var grabarCabeceraBod = new VenCabingresoBodTabla
            {
                Codigo = @event.Codigo,
                Sucursal = @event.Sucursal,
                Tipo = @event.Tipo,
                Serie = @event.Serie,
                Numero = (int)@event.Numero,
                Bodega = @event.Bodega,
                Cliente = @event.Cliente,
                Fechaemi = @event.Fechaemi,
                Fechaent = @event.Fechaent,
                Bodegaorigen = @event.Bodegaorigen,
                Vendedor = @event.Vendedor,
                Proveedor = @event.Proveedor,
                Peso = @event.Peso,
                Volumen = @event.Volumen,
                Motivo = @event.Motivo,
                Observacion = @event.Observacion,
                Comentario = @event.Comentario,
                Seccontable = @event.Seccontable,
                Estado = @event.Estado,
                Estadodoc = @event.Estadodoc,
                Codigorel = @event.Codigorel,
                Enviadosri = @event.Enviadosri == 1 ? true : false,
                Numautorizacion = "",
                Usuario = @event.Usuario,
                Fecha_ing = (DateTime)@event.Fecha_ing,
                Maquina = @event.Maquina
            };
            _repository.GrabarBod(grabarCabeceraBod);

            foreach (var item in @event.Productos)
            {
                var grabarDetalle = new VenDetingresoTabla
                {
                    Codigo = @event.Codigo,
                    Linea = item.Linea,
                    Producto = item.Producto,
                    Caja = item.Caja,
                    Unidad = item.Unidad,
                    Totalfun = (double)item.Totalfun,
                    Factor = item.Factor,
                    CostoP = item.CostoP,
                    CostoU = item.CostoU,
                    Precio = item.Precio,
                    Pagaiva = item.Pagaiva,
                    Poriva = item.Poriva,
                    Subtotal = item.Subtotal,
                    Pordes = (double)item.Pordes,
                    Descuento = (decimal)item.Descuento,
                    Iva = item.Iva,
                    Neto = item.Neto,
                    Lote = item.Lote,
                    Fechaela = item.Fechaela,
                    Fechaven = item.Fechaven,
                    Detalle = item.Detalle,
                    Bonificacion = 0

                };

                _repository.GrabarDetalle(grabarDetalle);
                var grabarDetalleBod = new VenDetingresoBodTabla
                {
                    Codigo = @event.Codigo,
                    Linea = item.Linea,
                    Producto = item.Producto,
                    Caja = item.Caja,
                    Unidad = item.Unidad,
                    Totalfun = (double)item.Totalfun,
                    Factor = item.Factor,
                    CostoP = item.CostoP,
                    CostoU = item.CostoU,
                    Precio = item.Precio,
                    Pagaiva = item.Pagaiva,
                    Poriva = item.Poriva,
                    Subtotal = item.Subtotal,
                    Pordes = (double)item.Pordes,
                    Descuento = (decimal)item.Descuento,
                    Iva = item.Iva,
                    Neto = item.Neto,
                    Lote = item.Lote,
                    Fechaela = item.Fechaela,
                    Fechaven = item.Fechaven,
                    Detalle = item.Detalle,

                };
                _repository.GrabarDetalleBod(grabarDetalleBod);

                var actualizarInvetario = new VenAgregarStockProductoBodAjusteIngresoProc
                {
                    Cantidad = item.Unidad + (item.Caja * item.Factor),
                    Codigo  = item.Producto,
                    Lote = item.Lote,
                    Bodega = @event.Bodega,
                    Fechaela = (DateTime)item.Fechaela,
                    Fechaven = (DateTime)item.Fechaven

                };
                _repository.ActualizarInventario(actualizarInvetario);

            }
            return Task.CompletedTask;
        }
    }
}
