using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events.Inventario;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Domain.EventHandlers.Inventario
{
    public class TranferenciaBodegaEventHandler : IEventHandler<TransferenciaBodegaCabCreateEvent>
    {

        private readonly ITranfrenciaBodegaRepository _repository;

        public TranferenciaBodegaEventHandler(ITranfrenciaBodegaRepository repository)
        {
            _repository = repository;
        }

        public Task Handle(TransferenciaBodegaCabCreateEvent @event)
        {
            var grabarCabecera = new VenCabEgresoTabla
            {
                Codigo = @event.Codigo,
                Origen = @event.Origen,
                Sucursal = @event.Sucursal,
                Tipo = @event.Tipo,
                Serie = @event.Serie,
                Numero = @event.Numero,
                Bodega = @event.Bodega,
                Numguia = @event.Numguia,
                Numpedido = @event.Numpedido,
                Cliente = @event.Cliente,
                Fechaemi = @event.Fechaemi,
                Fechaven = @event.Fechaven,
                Fechaent = @event.Fechaent,
                Bodegadestino = @event.Bodegadestino,
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
                Enviadosri = @event.Enviadosri,
                Numautorizacion = @event.Numautorizacion,
                Codigorel = @event.Codigorel,
                ClaseAjuste = "",
                NumeroApertura = 0,
                Credito = false,
                Cambio = 0,
                Pagado = 0,
                Fecha_ing = @event.Fecha_ing,
                Usuario = @event.Usuario,
                TipoRegistro = "",
            };
            _repository.Grabar(grabarCabecera);

            foreach (var item in @event.Productos)
            {
                var grabarDetalle = new VenDetEgresoTabla
                {
                    Codigo = item.Codigo,
                    Linea = item.Linea,
                    Producto = item.Producto,
                    Caja = item.Caja,
                    Unidad = item.Unidad,
                    Totalfun = item.Totalfun,
                    Factor = item.Factor,
                    CostoP = (float)item.CostoP,
                    CostoU = (float)item.CostoU,
                    Precio = (float)item.Precio,
                    Pagaiva = item.Pagaiva,
                    Poriva = item.Poriva,
                    Subtotal = item.Subtotal,
                    Pordes = item.Pordes,
                    Descuento = item.Descuento,
                    Iva = item.Iva,
                    Neto = item.Neto,
                    Lote = item.Lote,
                    Fechaela = item.Fechaela,
                    Fechaven = item.Fechaven,
                    Detalle = item.Detalle,
                    Formavta = item.Formavta,
                    Cantdevo = item.Cantdevo,
                    Cantconfirmada = item.Cantconfirmada,
                    Reversa = false,
                    CantCancelada = 0,
                    ConfirmaReversa = false,
                };

                _repository.GrabarDetalle(grabarDetalle);

                var actualizarInventario = new InvProductoBodegaTabla
                {
                    Producto = item.Producto,
                    Bodega = item.Bodega,
                };
                _repository.ActualizarInventario(actualizarInventario);
            }

            return Task.CompletedTask;
        }

        //public Task Handle(TransferenciaBodegaCabCreateEvent @event)
        //{
        //    var grabarCabecera = new VenCabEgresoTabla
        //    {
        //        Codigo = @event.Codigo,
        //        Origen = @event.Origen,
        //        Sucursal = @event.Sucursal,
        //        Tipo = @event.Tipo,
        //        Serie = @event.Serie,
        //        Numero = @event.Numero,
        //        Bodega = @event.Bodega,
        //        Numguia = @event.Numguia,
        //        Numpedido = @event.Numpedido,
        //        Cliente = @event.Cliente,
        //        Fechaemi = @event.Fechaemi,
        //        Fechaven = @event.Fechaven,
        //        Fechaent = @event.Fechaent,
        //        Bodegadestino = @event.Bodegadestino,
        //        Vendedor = @event.Vendedor,
        //        Proveedor = @event.Proveedor,
        //        Peso = @event.Peso,
        //        Volumen = @event.Volumen,
        //        Motivo = @event.Motivo,
        //        Observacion = @event.Observacion,
        //        Comentario = @event.Comentario,
        //        Seccontable = @event.Seccontable,
        //        Estado = @event.Estado,
        //        Estadodoc = @event.Estadodoc,
        //        Enviadosri = @event.Enviadosri,
        //        Numautorizacion = @event.Numautorizacion,
        //        Codigorel = @event.Codigorel,
        //        ClaseAjuste = "",
        //        NumeroApertura = 0,
        //        Credito = false,
        //        Cambio = 0,
        //        Pagado = 0,
        //        Fecha_ing = @event.Fecha_ing,
        //        Usuario = @event.Usuario,
        //        TipoRegistro = "",
        //    };
        //    _repository.Grabar(grabarCabecera);

        //    foreach (var item in @event.Productos)
        //    {
        //        var grabarDetalle = new VenDetEgresoTabla
        //        {
        //            Codigo = item.Codigo,
        //            Linea = item.Linea,
        //            Producto = item.Producto,
        //            Caja = item.Caja,
        //            Unidad = item.Unidad,
        //            Totalfun = item.Totalfun,
        //            Factor=  item.Factor,
        //            CostoP = (float)item.CostoP,
        //            CostoU = (float)item.CostoU,
        //            Precio = (float)item.Precio,
        //            Pagaiva = item.Pagaiva,
        //            Poriva = item.Poriva,
        //            Subtotal = item.Subtotal,
        //            Pordes = item.Pordes,
        //            Descuento = item.Descuento,
        //            Iva= item.Iva,
        //            Neto = item.Neto,
        //            Lote = item.Lote,
        //            Fechaela = item.Fechaela,
        //            Fechaven = item.Fechaven,
        //            Detalle = item.Detalle,
        //            Formavta = item.Formavta,
        //            Cantdevo = item.Cantdevo,
        //            Cantconfirmada = item.Cantconfirmada,
        //            Reversa= false,
        //            CantCancelada = 0,
        //            ConfirmaReversa = false,
        //        };

        //        _repository.GrabarDetalle(grabarDetalle);

        //        var actualizarInventario = new InvProductoBodegaTabla
        //        {
        //            Producto = item.Producto,
        //            Bodega = item.Bodega,
        //        };
        //        _repository.ActualizarInventario(actualizarInventario);
        //    }

        //    return Task.CompletedTask;
        //}
    }
}
